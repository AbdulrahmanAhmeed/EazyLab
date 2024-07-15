using EazyLab;
using EazyLab.AHU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Classes;

namespace Client.Forms
{
    public partial class frmHardwareCodeTester : frmTempDisp
    {
        const int SegmentSize = 2;
        public CodeTester CodeTester;
        private enum Type { AHU, CodeTester };
        //private Type type;
        public frmHardwareCodeTester(CodeTester codetester)
        {
            CodeTester = codetester;
            InitializeComponent();
            //type = Type.CodeTester;
            //sbSetUp.Enabled = false;
            //sbSetUp.Enabled = true ;
            bHome.Text = "Return";
            CodeTester.StartPID = true;
            CodeTester.Blower.Start = true; 
        }

        private void GetData()
        {
            try
            {
                pv2.AnCh = CodeTester.DBTempAnCh;
                pv1.AnCh = CodeTester.StaticPressAnCh;
                pv6.AnCh = CodeTester.NozzlePressAnCh;
                pv8.AnCh = CodeTester.WBTempAnCh;
                pv3.AnCh = CodeTester.AtmosPressAnCh;
             
                pidLoop1.PID = CodeTester.PressurePid;
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }

        }
        //public override void ShutDownWarning()
        //{
        //    this.Close();
        //}
        private void frmHardwareChamber_Load(object sender, EventArgs e)
        {

            Softgroup.NetResize.License.LicenseName = "Ahmed";
            Softgroup.NetResize.License.LicenseUser = "ahmed.shaaban@beta-elec.com";
            Softgroup.NetResize.License.LicenseKey = "MLAF3FRJXADPRBBRKBJI3DMUJ";

            GetData();
            foreach (var s in EazyLab.Instrumentation.WF40.Combined.PV.GetAll(this))
            {
                s.SevenSegment.Segment.Size = SegmentSize;
            }
        }

        private void DOPower_CheckedChanged(object sender, EventArgs e)
        {
            CodeTester.PowerOn = DOPower.Checked; 
        }

        private void nudCompressor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbCompressor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbBlower_CheckedChanged(object sender, EventArgs e)
        {
           CodeTester.Blower.Start=  cbBlower.Checked;
        }

        private void nudBlower_ValueChanged(object sender, EventArgs e)
        {
           CodeTester.Blower.Speed =  (double)nudBlower.Value;
        }


        public override void UpdateDisplay()
        {
            DataPacket dp= new DataPacket();
 
            dp.Read();
            pv5.Value = dp.AirFlowRate;
            nudBlower.Value =  (decimal)Program.Chamber.CodeTester.Blower.Speed;
            UpdateControls();
        }

        public void UpdateControls()
        {
            if (Program.Server.IsStarted)
            {
                tBConnect.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
            }
            cbNozzle1.Checked = Program.Chamber.Sample.Nozzles[0].Enabled;
            cbNozzle2.Checked = Program.Chamber.Sample.Nozzles[1].Enabled;
            cbNozzle3.Checked = Program.Chamber.Sample.Nozzles[2].Enabled;


        }

        private void cbNozzle1_CheckedChanged(object sender, EventArgs e)
        {
            Program.Chamber.Sample.Nozzles[0].Enabled = cbNozzle1.Checked;

        }

        private void cbNozzle2_CheckedChanged(object sender, EventArgs e)
        {
            Program.Chamber.Sample.Nozzles[1].Enabled = cbNozzle2.Checked;
        }

        private void cbNozzle3_CheckedChanged(object sender, EventArgs e)
        {
            Program.Chamber.Sample.Nozzles[2].Enabled = cbNozzle3.Checked;
        }

        private void buttonCalibrateFlow_Click(object sender, EventArgs e)
        {
            DataPacket dp = new DataPacket();
        
            dp.Read();
            var flow = dp.AirFlowRate;


        }
    }
}
