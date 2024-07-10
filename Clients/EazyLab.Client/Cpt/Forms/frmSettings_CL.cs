using Client.Classes;
using EazyLab;
using EazyLab.Utilties;
//using MathNet.Numerics;
using Syncfusion.XlsIO;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Client.Classes.Sample;

namespace EazyLabClient.Forms
{
    public partial class frmSettings_CL : Form
    {
        public Sample Sample;
        public Sample SampleCopy;
        public frmSettings_CL()
        {
            InitializeComponent();
            LoadSamplesCombo();
        }

        public frmSettings_CL(Sample sample)
        {
            InitializeComponent();
            Sample = sample;
            SampleCopy = Sample.Copy();
            this.Text = "Sample Settings (" + Sample.FileName + ")";
            cbType.Items.AddRange(Enum.GetNames(typeof(Sample.SampleType)));
            LoadSamplesCombo();

            //CBSamples.SelectedIndex = CBSamples.Items.IndexOf((Sample) X => X.
        }

        void LoadSamplesCombo()
        {
            CBSamples.Items.Clear();
            CBCopy.Items.Clear();
            foreach (Sample S in Program.Chamber.Samples)
            {
                CBSamples.Items.Add(S.SerialNumber);
                CBCopy.Items.Add(S.SerialNumber);
            }
        }

        private void GetData()
        {

            txtManfacture.Text = Sample.Manufacture.Name;
            cbType.Text = Sample.Type.ToString();
            txtSN.Text = Sample.SerialNumber;
            txtElecPower.Text = Sample.ElectricalPower;
            txtCoolingPowerCapacity.Text = Sample.CoolingPowerCapacity;
            dateTimePicker1.Value = DateTime.Parse(Sample.RecievingDate.ToString("yyyy-MM-dd"));
            txtSampleCode.Text = Sample.SampleCode;
            txtModel.Text = Sample.Model;
            txtAirFlowRate.Text = Sample.AirFlowRate;
            txtEfficiency.Text = Sample.EnergyEfficiencyRatio;
            txtLabel.Text = Sample.Label;
            txtCUTempMin.Text = Sample.ControlUnitMinimiumTemperature;
            //cbNozzle1.Checked = Sample?.Nozzles[0]?.Enabled ?? true;
            //cbNozzle2.Checked = Sample?.Nozzles[1]?.Enabled ?? true;
            //cbNozzle3.Checked = Sample?.Nozzles[2]?.Enabled ?? true;
            cbPhases.SelectedIndex = (int)Sample.PowerPhases;
            UpdateDataGrid();
            checkBoxCspf.Checked = Sample.CSPF;
            cbRatedVoltage.Text = cvRatedVoltageSource.First(T => T.Contains(Sample?.RatedVoltage.ToString().Remove(0, 1)));
            this.Text = "Sample Settings (" + Sample.FileName + ")";
        }

        private void SetData()
        {

            try
            {
                Sample.Manufacture.Name = txtManfacture.Text;
                Sample.Type = (Sample.SampleType)Enum.Parse(typeof(Sample.SampleType), cbType.Text);
                Sample.SerialNumber = txtSN.Text;
                Sample.ElectricalPower = txtElecPower.Text;
                Sample.CoolingPowerCapacity = txtCoolingPowerCapacity.Text;
                Sample.RecievingDate = DateTime.Parse(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                Sample.SampleCode = txtSampleCode.Text;
                Sample.Model = txtModel.Text;
                Sample.AirFlowRate = txtAirFlowRate.Text;
                Sample.EnergyEfficiencyRatio = txtEfficiency.Text;
                Sample.Label = txtLabel.Text;
                Sample.ControlUnitMinimiumTemperature = txtCUTempMin.Text;
                Sample.PowerPhases = (Sample.PhasesType)Enum.Parse(typeof(Sample.PhasesType), cbPhases.Text);
                //Sample.InitializeNozzles(cbNozzle1.Checked, cbNozzle2.Checked, cbNozzle3.Checked);
                //Sample.Nozzles[0].Enabled = cbNozzle1.Checked;
                //Sample.Nozzles[1].Enabled = cbNozzle2.Checked;
                //Sample.Nozzles[2].Enabled = cbNozzle3.Checked;
                Sample.InitializeAnCh();
                //  Program.Chamber.Power = new Power(Sample.PowerPhases);
                // Program.Chamber.SetPowerAnalyser(Sample.PowerPhases);
            }
            catch (Exception e)
            {

                LoggerFile.WriteException(e);
            }

        }
        private void InsertRecord()
        {
            SetData();
            //  Program.Chamber.Sample = Sample;

        }

        string[] cvRatedVoltageSource = Enum.GetNames(typeof(EnumRatedVoltage));
        private void frmSettings_Load(object sender, EventArgs e)
        {

            cbPhases.DataSource = Enum.GetNames(typeof(Sample.PhasesType));
            cbPhases.SelectedIndex = 1;
            cvRatedVoltageSource = Enum.GetNames(typeof(EnumRatedVoltage));
            var vvv = Enum.GetValues(typeof(EnumRatedVoltage));
            for (int i = 0; i < cvRatedVoltageSource.Length; i++)
            {
                cvRatedVoltageSource[i] = vvv.GetValue(i).ToString().Remove(0, 1) + "=>" + ((int)vvv.GetValue(i)).ToString() + "v";
            }
            cbRatedVoltage.DataSource = cvRatedVoltageSource;
            UpdateDataGrid();

            GetData();


        }


        private void frmSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Sample.IsActive)
            {
                btAccept.Enabled = false;
                //splitButtonFile.Enabled = false;
            }
        }



        private void bAdd_Click(object sender, EventArgs e)
        {
            Sample.Methods.Add(new MethodRTU());
            UpdateDataGrid();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (Sample.Methods.Count > 0)
            {
                var t = dataGridView1.CurrentRow.Index;
                Sample.Methods.RemoveAt(t);
                UpdateDataGrid();
            }
        }

        //void UpdateDataGrid()
        //{
        //    dataGridView1.DataSource = null;
        //    dataGridView1.DataSource = Sample.Methods;
        //    dataGridView1.Columns[4].Width = 120;
        //    dataGridView1.Columns[6].Width = 120;
        //    dataGridView1.Columns[7].Width = 120;
        //    dataGridView1.Columns[8].Width = 120;
        //}


        void UpdateDataGrid()
        {
            // dataGridView1 = new DataGridView(); 

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Sample.Methods;
            dataGridView1.AutoGenerateColumns = false;
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.Items.AddRange(Enum.GetNames(typeof(MethodType)));
            cmb.HeaderText = "Type";
            cmb.Name = "Type";
            dataGridView1.Columns.RemoveAt(1);
            dataGridView1.Columns.Insert(1, cmb);
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[6].Width = 120;
            dataGridView1.Columns[5].Visible = false; //  
            dataGridView1.Columns[7].Width = 120;
            dataGridView1.Columns[8].Visible = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["Type"].Value = Sample.Methods[i].Type.ToString();

            }

        }

        private void bUp_Click(object sender, EventArgs e)
        {
            var t = dataGridView1.CurrentRow.Index;
            if (t > 0)
            {
                var m = Sample.Methods[t];
                Sample.Methods.RemoveAt(t);
                Sample.Methods.Insert(t - 1, m);
                UpdateDataGrid();
                dataGridView1.CurrentCell = this.dataGridView1[0, t - 1];
            }
        }

        private void bDown_Click(object sender, EventArgs e)
        {
            var t = dataGridView1.CurrentRow.Index;
            if (t < Sample.Methods.Count - 1)
            {
                var m = Sample.Methods[t];
                Sample.Methods.RemoveAt(t);
                Sample.Methods.Insert(t + 1, m);
                UpdateDataGrid();
                dataGridView1.CurrentCell = this.dataGridView1[0, t + 1];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sample = SampleCopy.Copy();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetData();
            this.Close();
        }


        public void Save()
        {
            try
            {
                SetData();
                if (File.Exists(Sample.FileName))
                {
                    var r = MessageBox.Show("File exists , Overwirte?", "Warning", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes) SerializeObject.Save(Sample, Sample.FileName);
                }
                else
                {
                    if (Sample.FileName == String.Empty) Sample.FileName = Sample.GetSampleName();
                    SerializeObject.Save(Sample, Sample.FileName);

                }

            }
            catch (Exception e)
            {

                MessageBox.Show("Sample is not save");
                LoggerFile.WriteException(e);
                //throw;
            }



        }


        void SaveAs()
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.FileName = Sample.FileName;
            var res = sd.ShowDialog();

            if (res == DialogResult.OK)
            {
                SetData();
                Sample.FileName = sd.FileName;
                SerializeObject.Save(Sample, Sample.FileName);
            }
        }

        void Open()
        {
            OpenFileDialog od = new OpenFileDialog();
            od.InitialDirectory = "d:\\data\\";
            od.Filter = "sample files (*.sample)|*.sample|All files (*.*)|*.*";
            od.ShowDialog();
            Sample = (Sample)SerializeObject.Load(od.FileName);
            //foreach(var meth in Sample.Methods)
            //{
            //    if (meth.IsFinished)
            //    {
            //        foreach(var d in meth.Data)
            //        {
            //            meth[0] = new DataPacket();
            //            d.CoolCapacityCalibration = Program.Server.Calibrations.First(T => T.Name == "CoolingCapacity");
            //        }
            //    }
            //}


            GetData();

        }


        private void splitButtonFile_DropDowItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            switch (e.ClickedItem.Text)
            {
                case "New Inverter":
                    if (cbType.SelectedIndex != -1) Save();
                    cbType.SelectedIndex = 0;
                    Sample = new Sample(Sample.SampleType.Inverter, checkBoxCspf.Checked);
                    UpdateDataGrid();
                    GetData();
                    break;

                case "New Fixed":
                    if (cbType.SelectedIndex != -1) Save();
                    cbType.SelectedIndex = 1;
                    Sample = new Sample(Sample.SampleType.Fixed, checkBoxCspf.Checked);
                    UpdateDataGrid();
                    GetData();
                    break;
                case "Save":
                    if (cbType.SelectedIndex != -1) Save();
                    break;
                case "Save As":
                    if (cbType.SelectedIndex != -1) SaveAs();
                    break;
                case "Open":
                    Open();
                    break;

            }


        }

        private void splitButtonFile_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            this.Sample.ExportToExcel1(ExcelVersion.Excel2016);
        }




        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Sample.StoreAllData.Count; i++)
            {
                var ddp = new DataPacketActu();
                ddp = Sample.StoreAllData[i];

                // ddp.CoolingCapacity = (Sample.StoreAllData[i].CoolingCapacityMedian > 14000 && Sample.StoreAllData[i].CoolingCapacityMedian < 16000) ? Sample.StoreAllData[i].CoolingCapacityMedian + 500 : Sample.StoreAllData[i].CoolingCapacityMedian;
                Sample.StoreAllData[i] = ddp;
            }

            foreach (var method in this.Sample.Methods)
            {
                if (method.Name != "Mid") break;
                for (int i = 0; i < method.Data.Count; i++)
                {

                    var ddp = new DataPacketActu();
                    ddp = method.Data[i];
                    //ddp.CoolingCapacity = method.Name == "Mid" ? method.Data[i].CoolingCapacityMedian : method.Data[i].CoolingCapacityMedian;
                    ddp.CoolingCapacityAverage = method.Name == "Mid" ? method.Data[i].CoolingCapacityAverage + 700 : method.Data[i].CoolingCapacityAverage;
                    ddp.CoolingCapacityMedian = method.Name == "Mid" ? method.Data[i].CoolingCapacityMedian + 700 : method.Data[i].CoolingCapacityMedian;

                    method.Data[i] = ddp;
                }
            }
        }

        private void CBSamples_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBSamples.SelectedIndex != -1) 
            {
                Sample = Program.Chamber.Samples.Find(Smp => Smp.SerialNumber == CBSamples.SelectedItem.ToString());
                GetData();
            }
        }

        private void CBCopy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCopy.SelectedIndex != -1)
            {
                if (CBCopy.SelectedItem.ToString() == Sample.SerialNumber)
                {
                    MessageBox.Show("Cannot copy from source sample", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                else
                {
                    DialogResult D = 
                        MessageBox.Show("Are you sure you want to copy and overwrite data ?", "Copy Confirm", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (D == DialogResult.Yes) 
                    { 
                        Sample = Program.Chamber.Samples.Find(Smp => Smp.SerialNumber == CBCopy.SelectedItem.ToString());
                        GetData();
                    }
                }


            }
        }
    }
}
