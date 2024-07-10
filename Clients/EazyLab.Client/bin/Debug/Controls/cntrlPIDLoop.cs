using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EazyLab.Cntrls;
using EazyLab.Data.Forms;
using EazyLab.Model;
using EazyLab.Equipments.Equipments;


//using Syncfusion.Windows.Forms.Tools;

namespace EazyLab.Equipments.Controls
{

    public partial class cntrlPIDLoop : UserControl
    {
        EazyLab.Model.PID _pid;
        private bool dataChanged = false;
        public bool DataChanged { get => dataChanged; set => ledChangeIndicator.Value = dataChanged = value; }
        public cntrlPIDLoop()
        {
            InitializeComponent();
        }
        public cntrlPIDLoop(PID pid)
        {
            InitializeComponent();
            _pid = pid;
        }

        public EazyLab.Model.PID PID
        {
            set
            {
                _pid = value;
                PGain = value != null ? value.PGain : 1;
                IGain = value != null ? value.IGain : 0;
                DGain = value != null ? value.DGain : 0;
                ScanningTime = value != null ? value.ScanningTime:1000;
            }
            get => _pid;
        }

        

        private void bAutoTune_Click(object sender, EventArgs e)
        {
            if (PID != null)
            {
               frmPidAutoTune frm = new frmPidAutoTune();
                frm.Pid = PID; 
                frm.ShowDialog();
                PID = frm.Pid; // get data after autotune
                frm.Dispose();
                Update_controls();
                _pid.LoopOff();
            }
            else
            {
                MessageBox.Show("No PID loop is defind ");
            }
        }

        public void Update_controls()
        {
            nudP.Value = _pid.PGain;
            nudI.Value = _pid.IGain;
            nudD.Value = _pid.DGain;
            nudScanningTime.Value = _pid.ScanningTime;
            nudSetPoint.Value = (decimal)_pid.SetPoint;
            if (PID.State == Model.PID.StatesEnum.ActiveRunning || PID.State == Model.PID.StatesEnum.PassiveRunning) tbOnOff.State = true;
            else tbOnOff.State = false;
            Update_Status();
            this.Validate(); 
            Refresh();
        }

        void Update_Status()
        {
            switch (_pid.State)
            {
                case PID.StatesEnum.ActiveRunning: labelStatus.Text = "Active Running"; break;
                case PID.StatesEnum.AutoTune: labelStatus.Text = "Auto Tune Running"; break;
                case PID.StatesEnum.Idle: labelStatus.Text = "Idle PID"; break;
                case PID.StatesEnum.ProIdentStepResponse: labelStatus.Text = "Pro Ident Step Response"; break;
            }
            
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            PID.LoopOn(EazyLab.Model.PID.StatesEnum.ActiveRunning);
        }

        private void nudP_ValueChanged(object sender, EventArgs e)
        {
          if(PID !=null)   PID.PGain = (double)nudP.Value;
        }

        private void nudI_ValueChanged(object sender, EventArgs e)
        {
            if (PID != null) PID.IGain = (double)nudI.Value;
        }

        private void nudD_ValueChanged(object sender, EventArgs e)
        {
            if (PID != null) PID.DGain = (double)nudD.Value;
        }

        private void nudSetPoint_ValueChanged(object sender, EventArgs e)
        {
            if (PID != null) PID.SetPoint = (double)nudSetPoint.Value; 
        }

        private void nudScanningTime_ValueChanged(object sender, EventArgs e)
        {
            if (PID != null) PID.ScanningTime = (int)nudScanningTime.Value;
        }

        public void Save()
        {
            //_dataAccess.Update(_pid);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            // _dataAccess.Update(_pid); 
        }


        private void tbOnOff_Click(object sender, EventArgs e)
        {
            if (tbOnOff.State )
            {
                tbOnOff.State  = _pid.LoopOn(EazyLab.Model.PID.StatesEnum.ActiveRunning);
            }
            else _pid.LoopOff();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            DataChanged = true;
            var cntrl = new EazyLab.Cntrls.CntrlPIDs();
            cntrl.ClsIntity = _pid;
            var frm = new EazyLab.Equipments.Forms.FrmDialog(cntrl);

            frm.ShowDialog();
            _pid = cntrl.ClsIntity;
            Update_controls();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nudSetPoint_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
