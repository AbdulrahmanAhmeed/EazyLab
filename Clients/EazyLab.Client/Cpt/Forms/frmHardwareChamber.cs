using EazyLab;
using EazyLab.Ahus;
using EazyLab.Instrumentation.Combined;
using EazyLab.Instrumentation.WF40.Combined;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class frmHardwareChamber : frmTempDisp
    {
        private const int SegmentSize = 2;
        public AHU Ahu;
        public CodeTester CodeTester;
        private enum Type { AHU, CodeTester };
      
        public frmHardwareChamber(AHU ahu)
        {
            Ahu = ahu;
            InitializeComponent();
            Text = ahu.Name + " Maintenance";

            bStart.Enabled = false;
            bHome.Text = "Return";
            
        }

        private void GetData()
        {
            try
            {

                pv2.AnCh = Ahu.DBTempAnCh;
                pv1.AnCh = Ahu.EvaporatorTempAnCh;
                pv6.AnCh = Ahu.DewPointAnCh;
                pv3.AnCh = Ahu.AirTempAnCh;
                pv8.AnCh = Ahu.WBTempAnCh;
                pv5.AnCh = Ahu.HUMAnCh;
                WbtPid.PID = Ahu.WbtPid;
                DbtPid.PID = Ahu.DbtPid;
                EvapTempPid.PID = Ahu.EvapTempPid;
                DOComp1.DigChName = Ahu.Comp1ChName;
                DOComp2.DigChName = Ahu.Comp2ChName;
                DOHum.DigChName = Ahu.HumChName;
                DOWater.DigChName = Ahu.WaterChName;
                DOPower.DigChName = Ahu.PowerChName;
                DOAir.DigChName = Ahu.AirChName;


            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }

        }

        private void EnableAll(bool OnOff)
        {
            foreach (DigOut s in DigOutList)
            {
                s.Enabled = OnOff;
            }
            foreach (PV s in PVList)
            {
                s.Enabled = OnOff;
            }
            cbCoolFanStart.Enabled = OnOff;
            cbUpperFanStart.Enabled = OnOff;
            cbCompressor.Enabled = OnOff;
        }


        public void UpdateContol()

        {
            try
            {
                foreach (PV s in PVList)
                {
                    s.SevenSegment.Segment.Size = SegmentSize;
                }
                foreach (DigOut s in DigOutList)
                {
                    s.EzUpdate();
                }
                cbUpperFanStart.CheckState = Ahu.UpperFan.Start ? CheckState.Checked : CheckState.Unchecked;
                cbCoolFanStart.CheckState = Ahu.CoolingFan.Start ? CheckState.Checked : CheckState.Unchecked;
                cbCompressor.CheckState = Ahu.Compressor.Start ? CheckState.Checked : CheckState.Unchecked;
                nudCompressor.Value = (decimal)Ahu.Compressor.Speed;
                nudCoolingFan.Value = (decimal)Ahu.CoolingFan.Speed;
                nudUpperFan.Value = (decimal)Ahu.UpperFan.Speed;
                nudHeater.Value = (decimal)Ahu.HeaterPower;
               if (Program.Server.IsStarted)
                {
                    tBConnect.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
                }
                //   sLedConnect.Value = true; // Program.Server.IsStarted;
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }


        }

        private List<EazyLab.Instrumentation.WF40.Combined.PV> PVList = new List<PV>();
        private List<EazyLab.Instrumentation.Combined.DigOut> DigOutList = new List<DigOut>();

        private void frmHardwareChamber_Load(object sender, EventArgs e)
        {
            GetData();
            PVList = EazyLab.Instrumentation.WF40.Combined.PV.GetAll(this);
            DigOutList = EazyLab.Instrumentation.Combined.DigOut.GetAll(this);
            UpdateContol();
            if (tBConnect.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active)
            {
                timerUpdate.Start();
            }

            disableHardwareButtons();
            timerUpdate.Enabled = true;
            Program.Chamber.ActivateCurrentMethod();
            DbtPid.Update_controls();
            WbtPid.Update_controls();
            EvapTempPid.Update_controls();
            //Task.Factory.StartNew(() =>
            //{
            //    UpdateContol();
            //    if (sLedConnect.Value) timerUpdate.Start();
            //    disableHardwareButtons();
            //    timerUpdate.Enabled = true; 
            //}
            //);
        }



        private void cbCoolFanStart_CheckedChanged(object sender, EventArgs e)
        {
            Ahu.CoolingFan.Start = cbCoolFanStart.Checked;
        }

        private void cbUpperFanStart_CheckedChanged(object sender, EventArgs e)
        {
            Ahu.UpperFan.Start = cbUpperFanStart.Checked;
        }


        private void sLedStart_ValueChanged(object sender, EazyLab.Classes.ValueBooleanEventArgs e)
        {
            if (sLedStart.Value.AsBoolean)
            {
                Ahu.Start();
            }
            else
            {
                Ahu.Stop();
            }

            // Ahu.InitializeTask(!sLedStart.Value.AsBoolean);



        }

        private void DisableAllButons()
        {


        }



        private void digOut1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbCompressor_CheckedChanged(object sender, EventArgs e)
        {
            Ahu.Compressor.Start = cbCompressor.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudCompressor_ValueChanged(object sender, EventArgs e)
        {
            Ahu.Compressor.Speed = (double)nudCompressor.Value;
        }

        private void nudCoolingFan_ValueChanged(object sender, EventArgs e)
        {

            Ahu.CoolingFan.Speed = (double)nudCoolingFan.Value;
        }

        private void nudUpperFan_ValueChanged(object sender, EventArgs e)
        {
            Ahu.UpperFan.Speed = (double)nudUpperFan.Value;
        }

        private void DOHum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nudHeater_ValueChanged(object sender, EventArgs e)
        {
            Ahu.HeaterPower = (double)nudHeater.Value;
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            UpdateContol();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbtPid.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WbtPid.Save();
        }

        private void tBNoFF_Click(object sender, EventArgs e)
        {

            if (tBNoFF.ToggleState != Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active)
            {
                displayStringStatus.Value = "Starting the AHU";
            }
            else
            {
                displayStringStatus.Value = "Stopping the AHU";
            }

            Enabled = false; // tBNoFF.Enabled = false;
            Ahu.InitializeTask(tBNoFF.ToggleState != Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active);
            Enabled = true; //  tBNoFF.Enabled = true; 
            if (tBNoFF.ToggleState != Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active)
            {
                displayStringStatus.Value = "Started";
            }
            else
            {
                displayStringStatus.Value = "Stopped";
            }
        }

        private void EvapTempPid_Load(object sender, EventArgs e)
        {

        }

        private void pv1_Load(object sender, EventArgs e)
        {

        }

        private void pv8_Load(object sender, EventArgs e)
        {

        }

        private void pv6_Load(object sender, EventArgs e)
        {

        }

      //public   override void ShutDownWarning()
      //{
      //    this.Close();
      //}

        private void nudEvapPIDSteadyState_ValueChanged(object sender, EventArgs e)
        {
           // Ahu.Compressor.MinSpeed =
                Ahu.EvapTempPid.SteadyState =
                    -(double) nudEvapPIDSteadyState
                        .Value;  //(Ahu.EvapTempPid.AnCoolOut.Calibration.Calibrate((double) nudEvapPIDSteadyState.Value))/10;

            Ahu.DbtPid.SteadyState = -(double) nudEvapPIDSteadyState.Value; 
        }
    }
}