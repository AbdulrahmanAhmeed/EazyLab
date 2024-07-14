using CommunityToolkit.WinUI.Notifications;
using EazyLab.Cpt.Classes;
using EazyLab.Model;
using LiteDB;
using SharpZebra;
using SharpZebra.Commands;
using SharpZebra.Printing;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.WiFi;
namespace EazyLab.Cpt.Forms
{
    public partial class frmCptStation : Form
    {

        DbAccess DbAccess = Server.DbAccess;
        private CptChamber Chamber;
        List<CptStation> Stations;
        public frmCptStation(CptChamber _chamber)
        {
            InitializeComponent();
            maskedTextBoxIp.ValidatingType = typeof(System.Net.IPAddress);
            Chamber = _chamber;

        }
        BarcodeStandard.Barcode brcd = new BarcodeStandard.Barcode();
        void GenerateBarCode()
        {

            brcd.IncludeLabel = true;
            var img = brcd.Encode(BarcodeStandard.Type.Code128, "Cpt" + tempStation.SerialNumber.ToString(), SKColors.Black, SKColors.White, panel1.Width, panel1.Height);
            panel1.BackgroundImage = Bitmap.FromStream(img.Encode().AsStream());




        }

        CptStation tempStation = new CptStation();

        private async void frmCptStation_Load(object sender, EventArgs e)
        {

            Stations = Chamber.Stations;
            cbSerialNo.DataSource = Stations;
            cbSerialNo.DisplayMember = "SerialNumber";
            FindAllWifiDevices();
            var result = await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(WiFiAdapter.GetDeviceSelector());
            cbDevices.DataSource = result.ToList();
            cbDevices.DisplayMember = "Name";
            var dev = result.First(T => T.Name == cbDevices.Text);
            var adapter = await WiFiAdapter.FromIdAsync(dev.Id);
            await adapter.ScanAsync();
            var wifis = adapter.NetworkReport.AvailableNetworks.ToList();
            cbWifis.DataSource = wifis;
            cbWifis.DisplayMember = "Ssid";
            //if (Stations.Count > 0)
            //{
            //    cbSerialNo.SelectedIndex = 0;
            //    tempStation = Stations[0];
            //}
            UpdateDisplay();
        }

        void UpdateDisplay()
        {
            try
            {
                nudId.Value = (decimal)tempStation.Id;
                NudTimeout.Value = (decimal)tempStation.Timeout;
                nudScanningInterval.Value = tempStation.ReadingInterval;
                maskedTextBoxIp.Text = tempStation.IPAddress.ToString();
                cbSerialNo.Text = tempStation.SerialNumber.ToString();
                GenerateBarCode();
                btnConnect.State = tempStation.IsConnected;
                cbComPort.Text = Chamber.Comport;
                cbDevices.Text = Chamber.WiFiAdapterName;
                cbWifis.Text = Chamber.SSID;
                edName.Text = tempStation.Name;
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }



        private void buttonNew_Click(object sender, EventArgs e)
        {
            tempStation = new CptStation();

        }

        async void FindAllWifiDevices()
        {
            try
            {
                WiFiAdapter wa;
                var result = await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(WiFiAdapter.GetDeviceSelector());

                cbDevices.DataSource = result.ToList();
                cbDevices.DisplayMember = "Name";


            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }



        }
        CptDataPacketVer1 dp = new CptDataPacketVer1();
        private void DataReady(object sender, DataReadyEventArgs e)
        {
            //btnConnect.OnText = CptStation.ConnectionStatus.DisConnect.ToString();
            btnConnect.State = tempStation.IsConnected;
            Task.Factory.StartNew(() =>
            {
                try
                {
                    led1.Value = true;
                    Task.Delay(tempStation.ReadingInterval / 2 - 100).Wait();
                    led1.Value = false;
                }
                catch (Exception ex)
                {
                    LoggerFile.WriteException(ex);
                }
            });

            dp = e.DataPacket;
            tbStatus.Text = e.Result.ToString();
            if (listBox1.Items.Count == 0)
            {
                foreach (var stat in dp.GetType().GetProperties())
                {
                    try
                    {
                        string s = stat.Name + "=" + stat.GetValue(dp, null).ToString();
                        listBox1.Items.Add(s);
                        //listBox1.DataSource = dp;
                    }
                    catch (Exception ex)
                    {
                        LoggerFile.WriteException(ex);
                    }
                }
            }
            else
            {
                int i = 0;
                foreach (var stat in dp.GetType().GetProperties())
                {
                    try
                    {
                        string s = stat.Name + "= " + stat.GetValue(dp, null).ToString();
                        listBox1.Items[i] = s;
                        if (i == listBox1.SelectedIndex) //update the calibtation PV
                        {
                            if (pv1.Visible) pv1.Value = (double)stat.GetValue(dp, null);
                        }
                        i++;
                    }
                    catch (Exception ex)
                    {
                        LoggerFile.WriteException(ex);
                    }
                }
            }


        }

 
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (btnConnect.State)
                {

                    tempStation.IPAddress = maskedTextBoxIp.Text;
                    tempStation.Port = 9000;
                    if (!tempStation.Initiazlized) tempStation.Initialize();
                    tempStation.ReadingInterval = (int)nudScanningInterval.Value;
                    if (tempStation.DataReadyEvent == null)
                    {
                        tempStation.DataReadyEvent += DataReady;
                    }
                    else
                    {
                        if (!tempStation.IsEventHandlerRegisteredInDataReady(DataReady)) tempStation.DataReadyEvent += DataReady;
                    }
                    tempStation.Connect(true);

                }
                else
                {
                    tempStation.DisConnect();
                }

            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
            UpdateDisplay();
            this.Cursor = Cursors.Default;
        }

        private void nudScanningInterval_ValueChanged(object sender, EventArgs e)
        {
            tempStation.ReadingInterval = (int)nudScanningInterval.Value;
        }


        private void cbSerialNo_TextChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
            GenerateBarCode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DbAccess.Upsert(tempStation);
            Chamber.Initialize();
            Stations = Chamber.Stations;


        }


        private void nudId_ValueChanged(object sender, EventArgs e)
        {
            tempStation.Id = (int)nudId.Value;
        }

        int SelectedChannelIndex = 0;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedChannelIndex = listBox1.SelectedIndex - 3;
            if (listBox1.SelectedIndex >= 3 && listBox1.SelectedIndex <= 8)
            {
                edCalibValue.Value = 10000.0;
                gbCalibration.Text = "Calibration of Temp" + (listBox1.SelectedIndex - 3).ToString();
                pv1.TagName = "Temp" + (listBox1.SelectedIndex - 3).ToString();
                gbCalibration.Enabled = true;
                pv1.Visible = true;
                return;
            }
            else
            {
                if (listBox1.SelectedIndex >= 9 && listBox1.SelectedIndex <= 12)
                {
                    edCalibValue.Value = 5000.0;
                    gbCalibration.Text = "Calibration of Aux" + (listBox1.SelectedIndex - 9).ToString();
                    gbCalibration.Enabled = true;
                    pv1.TagName = "Aux" + (listBox1.SelectedIndex - 9).ToString();
                    pv1.Visible = true;
                    return;
                }
                else
                if (listBox1.SelectedIndex >= 13 && listBox1.SelectedIndex <= 19)
                {
                    switch (listBox1.SelectedIndex)
                    {
                        case 13:
                            edCalibValue.Value = 5000.0;
                            gbCalibration.Text = "Calibration of LR Current" + (listBox1.SelectedIndex - 9).ToString();
                            pv1.TagName = " LR Current";
                            break;
                        case 14:
                            edCalibValue.Value = 5000.0;
                            gbCalibration.Text = "Calibration of Voltage" + (listBox1.SelectedIndex - 9).ToString();
                            pv1.TagName = "Voltage";
                            break;
                        case 15:
                            edCalibValue.Value = 5000.0;
                            gbCalibration.Text = "Calibration of Current" + (listBox1.SelectedIndex - 9).ToString();
                            pv1.TagName = "Current";
                            break;
                        case 16:
                            edCalibValue.Value = 5000.0;
                            gbCalibration.Text = "Calibration of Power" + (listBox1.SelectedIndex - 9).ToString();
                            pv1.TagName = "Power";
                            break;

                        case 17:
                            edCalibValue.Value = 5000.0;
                            gbCalibration.Text = "Calibration of Energy" + (listBox1.SelectedIndex - 9).ToString();
                            pv1.TagName = "Energy";
                            break;
                        case 18:
                            edCalibValue.Value = 5000.0;
                            gbCalibration.Text = "Calibration of Frequency" + (listBox1.SelectedIndex - 9).ToString();
                            pv1.TagName = "Frequency";
                            break;
                        case 19:
                            edCalibValue.Value = 5000.0;
                            gbCalibration.Text = "Calibration of PF" + (listBox1.SelectedIndex - 9).ToString();
                            pv1.TagName = "PF";
                            break;

                    }
                    gbCalibration.Enabled = true;
                    pv1.Visible = true;
                    return;
                }

            }
            gbCalibration.Text = "calibration-No ch";
            gbCalibration.Enabled = false;
            pv1.Visible = false;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            tempStation.ZeroChannel(SelectedChannelIndex);
        }

        private void btnSpan_Click(object sender, EventArgs e)
        {
            tempStation.SpanChannel(SelectedChannelIndex, edCalibValue.Value);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                SharpZebra.Printing.PrinterSettings ps = new SharpZebra.Printing.PrinterSettings();
                ps.PrinterName = "ZDesigner ZD220-203dpi ZPL";
                int lableWidth = 100;
                int lableHeight = 50;
                ps.Width = 8 * 100;
                ps.Length = 8 * 50;
                ps.Darkness = 15;
                // ps.PrintSpeed= 30;

                List<byte> page = new List<byte>();
                page.AddRange(ZPLCommands.ClearPrinter(ps));
                SharpZebra.Barcode b = new SharpZebra.Barcode();
                b.Type = BarcodeType.CODE128_AUTO;
                //page.AddRange(ZPLCommands.TextWrite(10, 150, ElementDrawRotation.NO_ROTATION, ZPLFont.STANDARD_SCALABLE, 15, 10, "Hello World!"));
                page.AddRange(ZPLCommands.BarCodeWrite(75, 25, 8 * (lableHeight - 10), ElementDrawRotation.NO_ROTATION, b, true, "Cpt" + tempStation.SerialNumber.ToString()));
                page.AddRange(ZPLCommands.PrintBuffer(1));
                new SpoolPrinter(ps).Print(page.ToArray());
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }

        }

        private void cbComPort_DropDown(object sender, EventArgs e)
        {
            cbComPort.Items.AddRange(SerialPort.GetPortNames());
        }

        private void frmCptStation_FormClosed(object sender, FormClosedEventArgs e)
        {
            //tempStation.DisConnect();
            GC.Collect();

        }

        private void cbComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Chamber.Comport = cbComPort.Text;
                Chamber.Initialize();
                Server.DbAccess.Upsert(Chamber);
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
                new ToastContentBuilder().AddText(ex.Message).Show();

            }

        }

        private void btnSaveChamber_Click(object sender, EventArgs e)
        {
            Stations = Server.DbAccess.GetAll<CptStation>();
            if (Chamber.Stations == null) Chamber.Stations = new List<CptStation>();
            else Chamber.Stations.Clear();
            Chamber.SSID = cbWifis.Text;
            Chamber.WiFiAdapterName = cbDevices.Text;
            Chamber.Password = tbPassword.Text;
            foreach (var s in Stations) { Chamber.Stations.Add(s); }
            DbAccess.Upsert(Chamber);
            Chamber.Initialize();
        }

        private async void cbDevices_DropDown(object sender, EventArgs e)
        {
            var result = await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(WiFiAdapter.GetDeviceSelector());
            cbDevices.DataSource = result.ToList();
            cbDevices.DisplayMember = "Name";

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tempStation.Reset();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            var col = DbAccess.db.GetCollection<CptStation>();

            var rr = col.Exists(T => T.SerialNumber == tempStation.SerialNumber);
            var yy = col.Delete(tempStation.Id);
            DbAccess.Delete(tempStation);
            Stations.Remove(tempStation);

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tempStation.Timeout = (int)NudTimeout.Value;
        }

        private void cbSerialNo_DropDown(object sender, EventArgs e)
        {
            cbSerialNo.DataSource = Stations;
            cbSerialNo.DisplayMember = "SerialNo";
        }

        private void cbSerialNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tempStation.DataReadyEvent -= DataReady;
            tempStation = Stations[cbSerialNo.SelectedIndex];
            tempStation.DataReadyEvent += DataReady;
            listBox1.Items.Clear();
            UpdateDisplay();
        }
    }
}
