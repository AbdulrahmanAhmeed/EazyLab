using EazyLab.Classes;
using EazyLab.Types;
using EazyLabClient;
using LiteDB;
using SuperSimpleTcp;
using Syncfusion.Styles;
using Syncfusion.XlsIO;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using EazyLab.Model;
using Modbus;

namespace EazyLab.Cpt.Classes
{
    [Serializable]
    public class CptStation : Entity, IDisposable
    { 

        public enum SamplesStatus { NoSample, SampleWaiting, SampleOn, SampleRunning, SampleFinished };

        public enum Registers : ushort { DigitalOutput = 12 }
        public enum Commands
        {
            ResetCpu = 0xD1, StartTest = 0xD4, StopSample = 0xD3, SampleOnOff = 0xD4, SetDigitalOut = 0xD5, SetOverCurrrent = 0xD8
        }
        /*
   enum Commands
{
    SetLedMode = 1,
    SetLedState = 2,
    SetDoState = 3,
    ReadAllData = 4,
    CALIBCHANNEL = 5,
    SetMaxCurrent = 6,
    SetMaxCurrentPeriod = 7,
    SetOverCurrent = 8,
    SoftWareReset = 255
};
         */
        System.Timers.Timer Timer = new System.Timers.Timer();
        public CptDataPacketVer1 Lastdp = new CptDataPacketVer1();
        private Modbus.Modbus modbus;
        private LiteDatabase db;


        public ValueDouble min = new ValueDouble(0);
        public ValueDouble max = new ValueDouble(100);

        public string DataBaseLocation { get; set; }
        public int Id { get; set; } = 1;
        public string Name => "Station" + Id.ToString();
        public string SerialNumber { set; get; } = String.Empty;
        public string IPAddress { set; get; } = "192.168.0.100";
        public int Timeout { set; get; } = 5000;
        public int Port { set; get; } = 9000;
        [BsonIgnore]
        public EventHandler<DataSentEventArgs> DataSent { get; set; }
        [BsonIgnore]
        public bool IsConnected => modbus.IsConnected;
        [BsonIgnore]
        public bool IsTestStarted => Test.IsStarted;
        [BsonIgnore]
        public bool Initiazlized { get => initiazlized; }
        [BsonIgnore]
        public CptTest Test { get => test; set => test = value; }
        public int ReadingInterval { set => Timer.Interval = (double)value; get => (int)Timer.Interval; }
        [BsonIgnore]
        public DateTime StartTime { get => startTime; }
        [BsonIgnore]
        public SamplesStatus SampleStatus => (SamplesStatus)(Lastdp.Status & 0x00FF);

        [BsonIgnore]
        public EventHandler<DataReadyEventArgs> DataReadyEvent { get => dataReadyEvent; set => dataReadyEvent = value; }

        protected virtual void OnDataReadyEvent(DataReadyEventArgs e)
        {
            EventHandler<DataReadyEventArgs> handler = DataReadyEvent;
            if (handler != null)
            {
                handler(this, e);
            }

        }

        public CptStation()
        {
            Timer.Elapsed += new System.Timers.ElapsedEventHandler(UpdateData);
            Timer.Interval = 20000;
            modbus = new Modbus.Modbus(Mode.TCP_IP);

        }

        public bool IsEventHandlerRegisteredInDataReady(EventHandler<DataReadyEventArgs> prospectiveHandler)
        {
            if (this.DataReadyEvent != null)
            {
                foreach (EventHandler<DataReadyEventArgs> existingHandler in this.DataReadyEvent.GetInvocationList())
                {
                    if (existingHandler == prospectiveHandler)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public void Initialize()
        {
            try
            {

                IPAddress ip = System.Net.IPAddress.Parse(IPAddress);
                modbus.IP = IPAddress;
                modbus.Port = Port;
                modbus.ResponseTimeout = this.Timeout;
                modbus.Mode = Mode.TCP_IP;// must be the last
                initiazlized = true;
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
        }

        short[] data = new short[36];

        public void StartTimer()
        {
            Timer.Start();
        }

        public Result SetOverCurrent(int ovrcurr)
        {
            Result result = Result.CONNECT_ERROR;
            try
            {

                lock (this.modbus)
                {
                    if (!modbus.IsConnected) modbus.Connect();
                    result = modbus.WriteSingleRegister(1, (ushort)Commands.SetOverCurrrent, (short)ovrcurr);
                    if (result == Result.ISCLOSED)// one more time trial
                    {
                        modbus.Disconnect();
                        modbus.Connect();
                        result = modbus.WriteSingleRegister(1, (ushort)Commands.SetOverCurrrent, (short)ovrcurr);
                    }
                }

            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
            return result;



        }


        public Result ReadDataPacket()
        {
            Result result = Result.CONNECT_ERROR;
            try
            {
                lock (this.modbus)
                {
                    if (!modbus.IsConnected) modbus.Connect();
                    result = modbus.ReadHoldingRegisters(1, 0, (ushort)data.Length, data);
                    if (result == Result.ISCLOSED)
                    {
                        modbus.Disconnect();
                        modbus.Connect();
                        result = modbus.ReadHoldingRegisters(1, 0, (ushort)data.Length, data);
                    }
                    if (result == Result.SUCCESS)
                    {
                        Lastdp = new CptDataPacketVer1();
                        Lastdp.Temp0 = (double)data[0] / 100;
                        Lastdp.Temp1 = (double)data[1] / 100;
                        Lastdp.Temp2 = (double)data[2] / 100;
                        Lastdp.Temp3 = (double)data[3] / 100;
                        Lastdp.Temp4 = (double)data[4] / 100;
                        Lastdp.Temp5 = (double)data[5] / 100;
                        Lastdp.Aux0 = data[6];
                        Lastdp.Aux1 = data[7];
                        Lastdp.Aux2 = data[8];
                        Lastdp.Aux3 = data[9];
                        Lastdp.Current_LR=( ushort) data[10];
                        Lastdp.DigitalInput = (ushort)data[11];
                        Lastdp.DigitalOutput = (ushort)data[12];
                        Lastdp.Error = (ushort)data[13];
                        Lastdp.Voltage = (double)data[14] / 10;
                        Lastdp.Current = (double)(data[15] + (0xffff0000 & data[16] << 16)) / 1000;
                        Lastdp.Power = (double)(data[17] + (0xffff0000 & data[18] << 16)) / 10;
                        Lastdp.Energy = (double)(data[19] + (0xffff0000 & data[20] << 16));
                        Lastdp.Frequency = (double)data[21] / 10;
                        Lastdp.Pf = data[22];
                        Lastdp.Alarm = (ushort)data[23];
                        Lastdp.Status = (ushort)data[24];
                        byte[] bytes = new byte[8];
                        Buffer.BlockCopy(data, (data.Length - 8) * 2, bytes, 0, bytes.Length);
                        Lastdp.MillisTime = BitConverter.ToUInt64(bytes, 0);
                        Lastdp.WifiStrength = (short)data[25];
                        if (IsTestStarted)
                        {
                            test.CptSample.Profiles.Where(x => x.UpperLimitSubs.PlotChannel.Enabled && x.LowerLimitSubs.PlotChannel.Enabled).First().UpdateLimits((DateTime.Now - Test.StartTime).TotalMinutes);

                        }
                                



                        return result;
                    }
                }

            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
            return result;
        }

        int TempCounter = 0;
        public async void UpdateData(object sender, ElapsedEventArgs e)
        {
            var result = false;
            try
            {
                Timer.Stop();
                DataReadyEventArgs eee = new DataReadyEventArgs();
                eee.Result = ReadDataPacket();
                eee.DataPacket = Lastdp;
                eee.SerialNo = this.SerialNumber;
                if(IsTestStarted)
                   result =  CheckTemp(this.test.CptSample.SelectedSource, eee.DataPacket);
                OnDataReadyEvent(eee);
                test.Add(eee.DataPacket);
                if (IsTestStarted) 
                    Server.DbAccess.Upsert(test);
                //  db.GetCollection<CptDataPacketVer1>().Upsert(eee.DataPacket);


            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
            
            await Task.Delay(20000);
            Timer.Start();
        }

        private bool CheckTemp(CptProfile.ProfileSource source, CptDataPacketVer1 data)
        {
            try
            {
                var profiles = test.CptSample.Profiles.Where(x =>
                x.UpperLimitSubs != null && x.LowerLimitSubs != null &&
                x.UpperLimitSubs!.PlotChannel.Enabled && x.LowerLimitSubs!.PlotChannel.Enabled).ToList();

                //message = string.Empty;
                CptError error = new CptError();
                foreach (var Profile in profiles)
                {
                    switch (Profile.Source)
                    {
                        case CptProfile.ProfileSource.Temp1:
                            if (!(data.Temp0 < Profile.UpperLimit))
                            {
                                //message = "The temp1 hase exceeded its profile limit";
                                //pvTemp1.BackColor = System.Drawing.Color.Red;
                                data.CptError.Temp1 = CptError.ErrorState.upperLimit;
                                //this.Test.Errors.Add(error);
                                //Server.DbAccess.Upsert(SelectedStation.Test);
                            }
                            if (data.Temp0 < Profile.LowerLimit)
                            {
                                data.CptError.Temp1 = CptError.ErrorState.lowerLimit;
                            }
                            break;
                        case CptProfile.ProfileSource.Temp2:
                            if (!(data.Temp1 < Profile.UpperLimit))
                            {
                                //message = "The temp2 hase exceeded its profile limit";
                                //pvTemp2.BackColor = System.Drawing.Color.Red;
                                data.CptError.Temp2 = CptError.ErrorState.upperLimit;
                                //data.CptError = error;
                                //SelectedStation.Test.Errors.Add(error);
                                //Server.DbAccess.Upsert(SelectedStation.Test);
                            }
                            if (data.Temp1 < Profile.LowerLimit)
                            {
                                data.CptError.Temp2 = CptError.ErrorState.lowerLimit;
                                //data.CptError = error;
                                //SelectedStation.Test.Errors.Add(error);
                                //Server.DbAccess.Upsert(SelectedStation.Test);
                            }
                            break;
                        case CptProfile.ProfileSource.Temp3:
                            if (!(data.Temp2 < Profile.UpperLimit))
                            {
                                //message = "The temp3 hase exceeded its profile limit";
                                //pvTemp3.BackColor = System.Drawing.Color.Red;
                                data.CptError.Temp3 = CptError.ErrorState.upperLimit;
                                //data.CptError = error;
                                //SelectedStation.Test.Errors.Add(error);
                                //Server.DbAccess.Upsert(SelectedStation.Test);
                            }
                            if (data.Temp2 < Profile.LowerLimit)
                            {
                                data.CptError.Temp3 = CptError.ErrorState.lowerLimit;
                                //data.CptError = error;
                            }
                            break;
                        case CptProfile.ProfileSource.Temp4:
                            if (!(data.Temp3 < Profile.UpperLimit))
                            {
                                //message = "The temp4 hase exceeded its profile limit";
                                //pvTemp4.BackColor = System.Drawing.Color.Red;
                                data.CptError.Temp4 = CptError.ErrorState.upperLimit;
                                //data.CptError = error;
                                //SelectedStation.Test.Errors.Add(error);
                                //Server.DbAccess.Upsert(SelectedStation.Test);
                            }
                            if (data.Temp3 < Profile.LowerLimit)
                            {
                                data.CptError.Temp4 = CptError.ErrorState.lowerLimit;
                                //data.CptError = error;
                                //SelectedStation.Test.Errors.Add(error);
                                //Server.DbAccess.Upsert(SelectedStation.Test);
                            }
                            break;
                        case CptProfile.ProfileSource.Temp5:
                            if (!(data.Temp4 < Profile.UpperLimit))
                            {
                                //message = "The temp5 hase exceeded its profile limit";
                                //pvTemp5.BackColor = System.Drawing.Color.Red;
                                data.CptError.Temp5 = CptError.ErrorState.upperLimit;
                                //data.CptError = error;
                                //SelectedStation.Test.Errors.Add(error);
                                //Server.DbAccess.Upsert(SelectedStation.Test);
                            }
                            if (data.Temp4 < Profile.LowerLimit)
                            {
                                data.CptError.Temp5 = CptError.ErrorState.lowerLimit;
                                //data.CptError = error;
                                //SelectedStation.Test.Errors.Add(error);
                                //Server.DbAccess.Upsert(SelectedStation.Test);
                            }
                            break;
                        case CptProfile.ProfileSource.Temp6:
                            if (!(data.Temp5 < Profile.UpperLimit))
                            {
                                //message = "The temp5 hase exceeded its profile limit";
                                //pvTemp6.BackColor = System.Drawing.Color.Red;
                                data.CptError.Temp6 = CptError.ErrorState.upperLimit;
                                //data.CptError = error;
                                //SelectedStation.Test.Errors.Add(error);
                                //Server.DbAccess.Upsert(SelectedStation.Test);
                            }
                            if (data.Temp5 < Profile.LowerLimit)
                            {
                                data.CptError.Temp6 = CptError.ErrorState.lowerLimit;
                                //data.CptError = error;
                                //SelectedStation.Test.Errors.Add(error);
                                //Server.DbAccess.Upsert(SelectedStation.Test);
                            }
                            break;



                    }
                }

                return true;
            }
            catch (Exception ex) { 
                return false;
            }
        }


        UInt16[] serno = new UInt16[4];
        public void Connect(bool readSerial)
        {
            try
            {
                Initialize();
                var result = modbus.Connect(IPAddress, Port);

                if (result != Result.SUCCESS)
                {
                    modbus.Disconnect();
                    MessageBox.Show("Could not connect  Please check the Wifi Network");
                    return;
                }
                else if (readSerial)
                {
                    //Task.Delay(Timeout).Wait();
                    result = modbus.ReadHoldingRegisters(1, 0, (ushort)data.Length, data);

                    if (result != Result.SUCCESS)
                    {
                        MessageBox.Show("Could not Read Device Serial NO.");
                        modbus.Disconnect();
                        return;
                    }
                    PutStationWaitForSample();
                    byte[] bytes = new byte[8];
                    Buffer.BlockCopy(data, (data.Length - 4) * 2, bytes, 0, bytes.Length);
                    var tempSN = BitConverter.ToUInt64(bytes, 0).ToString();

                    if (this.SerialNumber != tempSN)
                    {
                        var btnselected = MessageBox.Show("The connected Box SerialNO Does not match Do you want to intialize the station this " +
                               "will cause all the previous data to be lost ? ", "New Serial Found", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                        if (btnselected == DialogResult.OK)
                        {
                            this.SerialNumber = tempSN;
                            this.Id = 0;
                        }
                        else return;
                    }
                }

                db = new LiteDatabase(Program.DataDir + this.SerialNumber + ".db");
                db.CheckpointSize = 10;
                Timer.Start();
            }
            catch (IOException ex) when (ex.Message.Contains(".db"))
            {
                MessageBox.Show("Please Close LiteDB ");
                LoggerFile.WriteException(ex);
                DisConnect();
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
                DisConnect();
            }


        }
        public void Connect(EventHandler<DataReadyEventArgs> dataReady)
        {
            try
            {
                Initialize();
                var result = modbus.Connect(IPAddress, Port);
                result = modbus.ReadHoldingRegisters(1, 0, (ushort)data.Length, data);
                if (result != Result.SUCCESS)
                {
                    MessageBox.Show("Could not connect  Please check the Wifi Network");
                    return;
                }

                byte[] bytes = new byte[8];
                Buffer.BlockCopy(data, (data.Length - 4) * 2, bytes, 0, bytes.Length);
                var tempSN = BitConverter.ToUInt64(bytes, 0).ToString();

                if (this.SerialNumber != tempSN)
                {
                    var btnselected = MessageBox.Show("The connected Box SerialNO Does not match Do you want to intialize the station this " +
                           "will cause all the previous data to be lost ? ", "New Serial Found", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                    if (btnselected == DialogResult.OK)
                    {
                        this.SerialNumber = tempSN;
                        this.Id = 0;

                    }
                    else return;
                }

                //Todo
                DataReadyEvent += dataReady;
                db = new LiteDatabase(Program.DataDir + this.SerialNumber + ".db");
                db.CheckpointSize = 10;
                Timer.Start();
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }

        public void DisConnect()
        {
            try
            {
                modbus.Disconnect();
                Timer.Stop();
                db.Checkpoint();
                db.Dispose();
                foreach (Delegate d in DataReadyEvent.GetInvocationList())
                {
                    DataReadyEvent -= (EventHandler<DataReadyEventArgs>)d;
                }

            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }



        public Result StartTest(bool start)
        {
            Result result = Result.CONNECT_ERROR;
            try
            {
                lock (this.modbus)
                {
                    if (!modbus.IsConnected) modbus.Connect();
                    result = modbus.WriteSingleRegister(1, (ushort)Commands.StartTest, (short)(start ? 0xff : 0x00));
                 if(test==null)   test = new CptTest(db);
                    Server.DbAccess.Upsert(test);
                    if(result == Result.SUCCESS && start )  Test.Start(); ;   // must be  updated from DAtapacket 
                   
                }

            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
            return result;
        }

        private bool dataReady;
        private bool initiazlized;
        private EventHandler<DataReadyEventArgs> dataReadyEvent;
        private DateTime startTime;
        private CptTest test = new CptTest();

        //public void ExportToExcel(ExcelVersion version)
        //{
        //    try
        //    {
        //        //ExcelEngine ee = new ExcelEngine();
        //        //IApplication app = ee.Excel;
        //        //app.DefaultVersion = version;
        //        //IWorkbook workbook = app.Workbooks.Create(1);
        //        //IWorksheet worksheet = workbook.Worksheets[0];
        //        //DataTable dt = Data.ToDataTable();
        //        //worksheet.ImportDataTable(dt, isFieldNameShown: true, 1, 1);
        //        //SaveFileDialog fileDialog = new SaveFileDialog();
        //        //fileDialog.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
        //        //fileDialog.FilterIndex = 2;
        //        //fileDialog.RestoreDirectory = true;
        //        //fileDialog.FileName = "S" + Position + DateTime.Now.ToString("_yy-MM-dd-hh-mm") + ".xls";
        //        //fileDialog.ShowDialog();
        //        //string FileName = fileDialog.FileName;
        //        //workbook.SaveAs(FileName.Substring(0, FileName.Length));
        //    }
        //    catch (Exception e)
        //    {
        //        LoggerFile.WriteException(e);
        //    }
        //}

        //public void ExportToExcel(ExcelVersion version, string dataDir)
        //{
        //    try
        //    {
        //        //List<RtuDataPacket> dataToBeSaved = new List<RtuDataPacket>();
        //        //dataToBeSaved.Add(RecordedData[0]);
        //        //for (int i = 1; i < RecordedData.Count; i++)
        //        //{
        //        //    dataToBeSaved.Add(RecordedData[i]); 
        //        //    //if ((Data[i].Time - dataToBeSaved.Last().Time) >= RecordingTime) dataToBeSaved.Add(Data[i]);
        //        //}
        //        //ExcelEngine ee = new ExcelEngine();
        //        //IApplication app = ee.Excel;
        //        //app.DefaultVersion = version;
        //        //IWorkbook workbook = app.Workbooks.Create(1);
        //        //IWorksheet worksheet = workbook.Worksheets[0];
        //        //DataTable dt = dataToBeSaved.ToDataTable();
        //        //SetColumnsHeader(dt);
        //        //worksheet.ImportDataTable(dt, isFieldNameShown: true, 1, 1);
        //        //string FileName = dataDir + "S" + Position + DateTime.Now.ToString("_yy-MM-dd-hh-mm") + ".xls";
        //        //workbook.SaveAs(FileName.Substring(0, FileName.Length));
        //    }
        //    catch (Exception e)
        //    {
        //        LoggerFile.WriteException(e);
        //    }
        //}

        void SetColumnsHeader(DataTable Dt)
        {
            // Initialize to avoid column dublication in naming
            for (int i = 0; i < Dt.Columns.Count; i++)
                Dt.Columns[i].ColumnName = i.ToString() + "Nan";

            //Dt.Columns[0].ColumnName = "Time";
            //Dt.Columns[1].ColumnName = Program.Chamber.PV_Names["pvDbt"];
            //Dt.Columns[2].ColumnName = Program.Chamber.PV_Names["pvWbt"];
            //Dt.Columns[3].ColumnName = Program.Chamber.PV_Names["pvVoltage"];
            //Dt.Columns[4].ColumnName = Program.Chamber.PV_Names["pvCurrent"];
            //Dt.Columns[5].ColumnName = Program.Chamber.PV_Names["pvPower"];
            //Dt.Columns[6].ColumnName = Program.Chamber.PV_Names["pvEnergy"];
            //Dt.Columns[7].ColumnName = Program.Chamber.PV_Names["pvPress1"];
            //Dt.Columns[8].ColumnName = Program.Chamber.PV_Names["pvPress2"];
            //Dt.Columns[9].ColumnName = Program.Chamber.PV_Names["pvTemp0"];
            //Dt.Columns[10].ColumnName = Program.Chamber.PV_Names["pvTemp1"];
            //Dt.Columns[11].ColumnName = Program.Chamber.PV_Names["pvTemp2"];
            //Dt.Columns[12].ColumnName = Program.Chamber.PV_Names["pvTemp3"];
            //Dt.Columns[13].ColumnName = Program.Chamber.PV_Names["pvTemp4"];
            //Dt.Columns[14].ColumnName = Program.Chamber.PV_Names["pvTemp5"];
            //Dt.Columns[15].ColumnName = Program.Chamber.PV_Names["pvTemp6"];
            //Dt.Columns[16].ColumnName = Program.Chamber.PV_Names["pvTemp7"];
            //Dt.Columns[17].ColumnName = Program.Chamber.PV_Names["pvTemp8"];
            //Dt.Columns[18].ColumnName = Program.Chamber.PV_Names["pvTemp9"];
            //Dt.Columns[19].ColumnName = Program.Chamber.PV_Names["pvTemp10"];
            //Dt.Columns[20].ColumnName = Program.Chamber.PV_Names["pvTemp11"];
            //Dt.Columns[21].ColumnName = Program.Chamber.PV_Names["pvTemp12"];
            //Dt.Columns[22].ColumnName = Program.Chamber.PV_Names["pvTemp13"];
            //Dt.Columns[23].ColumnName = Program.Chamber.PV_Names["pvTemp14"];
            //Dt.Columns[24].ColumnName = Program.Chamber.PV_Names["pvTemp15"];
            //Dt.Columns[25].ColumnName = Program.Chamber.PV_Names["pvTemp16"];
            //Dt.Columns[26].ColumnName = Program.Chamber.PV_Names["pvTemp17"];
            //Dt.Columns[27].ColumnName = Program.Chamber.PV_Names["pvTemp18"];
            //Dt.Columns[28].ColumnName = Program.Chamber.PV_Names["pvTemp19"];
            //Dt.Columns[29].ColumnName = Program.Chamber.PV_Names["pvTemp20"];
            //Dt.Columns[30].ColumnName = Program.Chamber.PV_Names["pvTemp21"];
            //Dt.Columns[31].ColumnName = Program.Chamber.PV_Names["pvTemp22"];
            //Dt.Columns[32].ColumnName = Program.Chamber.PV_Names["pvTemp23"];
            //Dt.Columns[33].ColumnName = Program.Chamber.PV_Names["pvTemp24"];
            //Dt.Columns[34].ColumnName = Program.Chamber.PV_Names["pvTemp25"];
            //Dt.Columns[35].ColumnName = Program.Chamber.PV_Names["pvTemp26"];
            //Dt.Columns[36].ColumnName = Program.Chamber.PV_Names["pvTemp27"];
            //Dt.Columns[37].ColumnName = Program.Chamber.PV_Names["pvTemp28"];
            //Dt.Columns[38].ColumnName = Program.Chamber.PV_Names["pvTemp29"];
            //Dt.Columns[39].ColumnName = Program.Chamber.PV_Names["pvTemp30"];
            //Dt.Columns[40].ColumnName = Program.Chamber.PV_Names["pvTemp31"];

        }

        #region Station Generating Methods 

        public bool SwitchSample(bool onOff)
        {

            Result result = Result.CONNECT_ERROR;
            try
            {

                lock (this.modbus)
                {
                    short data = (short)(onOff ? 0xfffff : 0x0000);

                    if (!modbus.IsConnected) modbus.Connect();
                    result = modbus.WriteSingleRegister(1, (ushort)Commands.SampleOnOff, data);
                    if (result == Result.ISCLOSED)
                    {
                        modbus.Disconnect();
                        modbus.Connect();
                        result = modbus.WriteSingleRegister(1, 0, data);//resend 
                    }
                    if (result == Result.SUCCESS)
                    {
                        //read the status of the buttton. 
                        short[] data1 = new short[1];
                        result = modbus.ReadHoldingRegisters(1, (ushort)Registers.DigitalOutput, 1, data1);

                        if (result != Result.SUCCESS) return false;
                        var res = data1[0] & 0x0001;
                        return res == 1;  // return true if the Do is set to 1



                    }
                }

            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
            return result == Result.SUCCESS;
        }




        public bool SetDO(int position, bool value)
        {

            Result result = Result.CONNECT_ERROR;
            try
            {

                lock (this.modbus)
                {
                    short data = (short)(value ? 0x00ff : 0x00000);
                    data = (short)((short)(position << 8) | data);
                    if (!modbus.IsConnected) modbus.Connect();
                    result = modbus.WriteSingleRegister(1, (ushort)Commands.SetDigitalOut, data);
                    if (result == Result.ISCLOSED)
                    {
                        modbus.Disconnect();
                        modbus.Connect();
                        result = modbus.WriteSingleRegister(1, 0, data);//resend 
                    }
                    if (result == Result.SUCCESS)
                    {
                        //read the status of the buttton. 
                        short[] data1 = new short[1];
                        result = modbus.ReadHoldingRegisters(1, (ushort)Registers.DigitalOutput, 1, data1);

                        if (result != Result.SUCCESS) return false;
                        var res = data1[0] & 0x0001;
                        return res == 1;  // return true if the Do is set to 1



                    }
                }

            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
            return result == Result.SUCCESS;
        }




        #endregion

        #region Station Calibration Methods 
        const int CalibrationBaseRegister = 1000;
        public void ZeroChannel(int ch)
        {
            modbus.WriteSingleRegister(1, (ushort)(ch + 0xe0), 0);
        }

        public void PutStationWaitForSample()
        {
            modbus.WriteSingleRegister(1, (ushort)(0xD0), 0);
        }

        public void SpanChannel(int ch, double value)
        {
            lock (this.modbus)
            {
                modbus.WriteSingleRegister(1, (ushort)(ch + 0xe0), (short)value);
            }
        }



        public override string ToString()
        {
            return "Station " + Id.ToString();
        }

        internal void GetID()
        {

        }
        public SamplesStatus GetSampleStatus()
        {
            return SampleStatus;
        }

        public void Reset()
        {
            modbus.WriteSingleRegister(1, (ushort)(Commands.ResetCpu), 0);
        }

        #endregion

        public void Dispose()
        {
            db.Checkpoint();
            db.Dispose();

        }
    }
}
