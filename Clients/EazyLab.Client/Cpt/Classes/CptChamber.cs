using CommunityToolkit.WinUI.Notifications;
using EazyLab.Model;
using LiteDB;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using Windows.Devices.WiFi;

namespace EazyLab.Cpt.Classes
{
    [Serializable]
    public class CptChamber : Entity
    {
        [BsonIgnore]
        public DbAccess DbAccess { set; get; } 
        private SerialPort serialPort;
        public string Comport { get; set; } = "Com1";
        public string WiFiAdapterName { get; set; }
        public string SSID { get; set; }
        public string Password { get; set; }
        public List<CptStation> Stations { set; get; }

        [BsonIgnore]
        Windows.Devices.WiFi.WiFiAdapter Adapter { get; set; }
        [BsonIgnore]
        WiFiAvailableNetwork WiFiAvailableNetwork { get; set; }
        public CptChamber()
        {
            Stations = new List<CptStation>();
            serialPort = new SerialPort(Comport);
            serialPort.BaudRate = 115200;
            serialPort.DataReceived += SerialPort_DataReceived;
             
               

        }

        async void ConnectWifi()
        {
            try
            {
                var result = await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(WiFiAdapter.GetDeviceSelector());

                var dev = result.First(T => T.Name == WiFiAdapterName);
                Adapter = await WiFiAdapter.FromIdAsync(dev.Id);
                await Adapter.ScanAsync();
                var wifis = Adapter.NetworkReport.AvailableNetworks.ToList();
                WiFiAvailableNetwork = wifis.First(T => T.Ssid == SSID);
                await Adapter.ConnectAsync(WiFiAvailableNetwork, WiFiReconnectionKind.Automatic);
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
        }
        public void ReInitialize()
        {
            try
            {
                serialPort.Close();
                Task.Delay(1000);
                serialPort = new SerialPort(Comport);
                serialPort.BaudRate = 115200;
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();


            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
                ToastMessage(ex.Message);
            }

        }
        public void Initialize()
        {
            try
            {
                Stations = Server.DbAccess.GetAll<CptStation>();
                
                serialPort = new SerialPort(Comport);
                serialPort.BaudRate = 115200;
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();
                

            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
                ToastMessage(ex.Message);
            }

            try
            {
                ConnectWifi();
                //if (Stations == null) Stations = new List<CptStation>();
                //else
                //{
                //    foreach (CptStation st in Stations)
                //    {
                //        st.Connect();
                //    }
                //}
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
                ToastMessage(ex.Message);
            }
        }






        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                var recvd = serialPort.ReadExisting(); //.ReadLine();
                if (recvd == null) return;
                if (recvd.Substring(0, 3) == "Cpt") //if scanned code is 
                {
                    var ss = recvd.Remove(recvd.Length - 1).Substring(3);
                    var st = Stations.First(T => T.SerialNumber == ss);
                    if (!st.IsConnected) st.Connect(false);
                    if (st.ReadDataPacket() == Types.ModbusResult.SUCCESS)//Station is connected 
                    {
                        if ((st.SampleStatus == CptStation.SAMPLESTATUS.Running))
                        {
                            ToastMessage("Another Sample is Running Please stop the Station first");
                            return;
                        }
                        if ((st.SampleStatus == CptStation.SAMPLESTATUS.NoSample || st.SampleStatus == CptStation.SAMPLESTATUS.Finished))
                        {
                            st.PutStationWaitForSample();
                            ToastMessage("Add Sample To station #" + st.SerialNumber);
                            return;
                        }
                    }
                    else//failed to read from the station 
                    {
                        ToastMessage("The Station is not  connected");
                    }


                }


                //ToastMessage(recvd);
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
                new ToastContentBuilder().AddText("Scanner Not Attached").Show();
            }
           // serialPort.Close();

        }


        private void ToastMessage(string msg)
        {
            try
            {

                new ToastContentBuilder().AddText(msg).Show();

            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }
        ~CptChamber()
        {
            serialPort.Close();
            serialPort.Dispose();

        }

    }
}
