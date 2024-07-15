
using EazyLab.Model;
using System;
using System.Threading.Tasks;
using Math = System.Math;
using System.Collections.Generic;
using PsychrometryLib;
using EazyLab.Interfaces; 

namespace EazyLab
{
    [Serializable]
    public class CodeTester
    {
        [NonSerialized()]
         private PsychrometricPointSI Psychrometry = new PsychrometricPointSI(0);
        public enum ErrorCode
        {
            non,
            CouldNotCoolDownEvaporator,
            DbtSensor, WbtSensor, HumSensor, InverterStopped, AirSampler, DataAcquisiton, CompressorWaterFlowLow,InverterCommunication,
            NozzleDoorOpened
        }


        private readonly double _flow = 0;

        public double Flow => _flow;
        public PID PressurePid { set; get; }
        public AnalogInput DBTempAnCh { set; get; }
        public Filter DbtFilter = new Filter(60);
        public AnalogInput WBTempAnCh { set; get; }
        public Filter WbtFilter = new Filter(60);
        public AnalogInput AtmosPressAnCh { set; get; }

        // pressure sensor Connected to the AC 
        public AnalogInput NozzlePressAnCh { set; get; }

        // To measure the flow 
        public AnalogInput StaticPressAnCh { set; get; }
        public AnalogInput Dac;
        private string Name { set; get; }
        public DigitalOutput PowerDO;
        public DigitalOutput BlowerDo;
        [NonSerialized]
        public Server Server;
        [NonSerialized]
        public IInverter Blower;

        public bool IsReady()
        {
            return  (Math.Abs(PressurePid.Error) > 5);            
        }
                
        public bool PowerOn
        {
            get => PowerDO.Value;
            set => PowerDO.Value = value;
        }

        public void UpdateReadings()
        {
            DbtFilter.Add(DBTempAnCh.CalibFilteredValue);
            WbtFilter.Add(WBTempAnCh.CalibratedValue);
        }
        public bool BlowerOn
        {
            set
            {
                Blower.Start = value; if (value)
                {
                    PressurePid.LoopOn(PID.StatesEnum.ActiveRunning);
                }
                else
                {
                    PressurePid.LoopOff();
                }
            }
            //get => BlowerDo.Value;
        }
        public double StaticPress => StaticPressAnCh.CalibFilteredValue;

        private double _StaticPressSp = 0;
        public double StaticPressSp
        {
            get => _StaticPressSp;
            set => PressurePid.SetPoint = _StaticPressSp = value;

        }

        public bool StartPID
        {
            set => Blower.Start = value;
        }

        public void Start()
        {
            Task.Factory.StartNew(() =>
            {
                PowerOn = true;
                Task.Delay(5000).Wait();
                BlowerOn = true;
                PressurePid.LoopOn(PID.StatesEnum.ActiveRunning);
            });

        }


        public void Stop()
        {
            PowerOn = false;
            Task.Delay(5000);
            BlowerOn = true;
            PressurePid.LoopOff();
        }

        public void Stop1()
        {
            PowerOn = false;
            Task.Delay(5000);
            BlowerOn = true;
            PressurePid.LoopOff();
        }
        public CodeTester(string name, Server server)
        {
            Name = name;
            Server = server;
            try
            {
                //DBTempAnCh = Server.AnChannels.Find(T => T.Name == Name + "AnalogRead:0");
                //WBTempAnCh = Server.AnChannels.Find(T => T.Name == Name + "AnalogRead:1");
                //AtmosPressAnCh = Server.AnChannels.Find(T => T.Name == Name + "AnalogRead:2");
                //StaticPressAnCh = Server.AnChannels.Find(T => T.Name == Name + "AnalogRead:3");
                //NozzlePressAnCh = Server.AnChannels.Find(T => T.Name == Name + "AnalogRead:4");
                //PowerDO = Server.DigChannels.Find(T => T.Name == Name + "DO:0");
                //BlowerDo = Server.DigChannels.Find(T => T.Name == Name + "DO:1");
                //Dac = server.AnChannels.Find(T => T.Name == Name + "AnalogWrite:0");
                //Blower = new NL1000Inverter(Name + "Inverter", Server);
                Blower.MaxSpeed = 100;
                PressurePid = server.Pids.Find(T => T.Name == Name + "StaticPressurePid");

            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);

            }
        }
        public List<ErrorCode> Check()
        {

            List<ErrorCode> err = new List<ErrorCode>();

            try
            {
                if (DBTempAnCh.CalibratedValue < 0 | DBTempAnCh.CalibratedValue > 50) err.Add(ErrorCode.DbtSensor);
                if (WBTempAnCh.CalibratedValue < 0 | WBTempAnCh.CalibratedValue > 50) err.Add(ErrorCode.WbtSensor);
                if (err.Count == 2) err.Add(ErrorCode.DataAcquisiton);
                if (Math.Abs(DBTempAnCh.CalibFilteredValue - WBTempAnCh.CalibFilteredValue) < 0.5) err.Add(ErrorCode.AirSampler);
                if (Math.Abs(NozzlePressAnCh.CalibFilteredValue) < 100 && PressurePid.OutPut==-1 ) err.Add(ErrorCode.NozzleDoorOpened);
                if (Math.Abs(StaticPressAnCh.CalibFilteredValue) > PressurePid.PVMax * 2 && PressurePid.OutPut==1 ) err.Add(ErrorCode.NozzleDoorOpened);
                Psychrometry.CalcAllUsingDbWb(DBTempAnCh.CalibratedValue, WBTempAnCh.CalibratedValue);
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex); 
            }
            return err;



        }
    }
}
