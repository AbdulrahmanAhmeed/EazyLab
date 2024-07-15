using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EazyLabClient.SimpleDaq.Classes;
using EazyLab;
using EazyLab.Model;

namespace EazyLabClient.SimpleDaq.Forms
{
    public partial class frmStationConfig : Form
    {
        public List<EazyLab.Model.AnalogInputConfig> AnalogInputConfigs = new List<EazyLab.Model.AnalogInputConfig>();
        public Server Server = new Server();
        public int StationNo = 0;
        EazyDaqStation Station;
        public frmStationConfig()
        {
            InitializeComponent();
        }

        public frmStationConfig(Server ser, EazyDaqStation station)
        {
            InitializeComponent();
            Server = ser;
            Server.Initialize();
            Station = station;
            AnalogInputConfigs = Station.AnalogInputConfigs;
        }


        private void Configuration_Load(object sender, EventArgs e)
        {
            InitializeComboBoxs();
            cbCommChannel.SelectedIndex = 0;
            cbDevice.SelectedIndex = 0;
            cbDaqTask.SelectedIndex = 0;
            cbAnalogInput.SelectedIndex = 0;
            Initialize();
        }

        void Initialize()
        {
            try
            {


                AhuDp dp = new AhuDp();
                var config = new EazyLab.Model.AnalogInputConfig();
                dataGridView1.Columns.Clear();
                var props = dp.GetType().GetProperties();
                // AnalogInputConfigs.Clear();
                if (AnalogInputConfigs.Count == 0)
                {
                    for (int i = 1; (i < props.Length); i++)
                    {
                        config = new EazyLab.Model.AnalogInputConfig();
                        config.Name = props[i].Name;
                        AnalogInputConfigs.Add(config);
                    }
                }
                dataGridView1.DataSource = AnalogInputConfigs.ToDataTable();
                dataGridView1.Columns[1].Width = dataGridView1.Width - dataGridView1.Columns[0].Width - dataGridView1.RowHeadersWidth;

                dataGridView1.Update();
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);

            }



        }


        int rowIndex = 0;
        int columnIndex = 0;
        AnalogInputConfig AnalogInputConfig = new EazyLab.Model.AnalogInputConfig();
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            columnIndex = e.ColumnIndex;
        }


        void InitializeComboBoxs()
        {
            //if (AnalogInputConfigs[columnIndex].AnalogInput == null) return;
            cbAnalogInput.DataSource = Server.AnalogInputs.ToDataTable();
            cbAnalogInput.DisplayMember = "Name";
            cbAnalogInput.ValueMember = "Name";
            cbAnalogInput.SelectedIndex = 0;

            cbDaqTask.DataSource = Server.DaqTasks.ToDataTable();
            cbDaqTask.DisplayMember = "Name";
            cbDaqTask.ValueMember = "Name";
            cbDaqTask.SelectedItem = 0;

            cbDevice.DataSource = Server.Devices.ToDataTable();
            cbDevice.DisplayMember = "Name";
            cbDevice.ValueMember = "Name";
            cbDevice.SelectedItem = 0;

            cbCommChannel.DataSource = Server.CommChannels.ToDataTable();
            cbCommChannel.DisplayMember = "Name";
            cbCommChannel.ValueMember = "Name";
            cbCommChannel.SelectedItem = 0;

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            columnIndex = e.ColumnIndex;
            //   InitializeComboBoxs();

        }

        void UpdateDgvRow()
        {
            try
            {

                dataGridView1.DataSource = AnalogInputConfigs.ToDataTable();
                rowIndex++;
                if (rowIndex >= (dataGridView1.Rows.Count - 1)) rowIndex = 0;
                this.dataGridView1.CurrentCell = this.dataGridView1[columnIndex, rowIndex];

            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }

        void apply()
        {
            AnalogInputConfigs[rowIndex].AnalogInput = Server.AnalogInputs.First(T => T.Name == cbAnalogInput.Text);
            if (cbAnalogInput.SelectedIndex < (cbAnalogInput.Items.Count - 1)) cbAnalogInput.SelectedIndex++;
            UpdateDgvRow();
        }
        private void buttonApply_Click(object sender, EventArgs e)
        {
            apply();
        }

        private void cbCommChannel_DropDown(object sender, EventArgs e)
        {
            cbCommChannel.DataSource = Server.CommChannels.ToDataTable();
            cbCommChannel.DisplayMember = "Name";
            cbCommChannel.ValueMember = "Name";
        }
        private void cbCommChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dvs = Server.Devices.FindAll(x => x.CommChannel.Name == cbCommChannel.Text);
            cbDevice.DataSource = dvs.ToDataTable();
            cbDevice.DisplayMember = "Name";
            cbDevice.ValueMember = "Name";

        }

        private void cbDevice_DropDown(object sender, EventArgs e)
        {
            if (cbCommChannel.SelectedIndex < 0)
            {
                MessageBox.Show("CommChannel Must be selected first");
                return;
            }
            cbDevice.DataSource = Server.Devices.FindAll(T => T.CommChannel.Name == cbCommChannel.Text).ToDataTable();
            cbDevice.DisplayMember = "Name";
            cbDevice.ValueMember = "Name";

        }

        private void cbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDaqTask.DataSource = Server.DaqTasks.FindAll(x => x.Device.Name == cbDevice.Text);
            cbDaqTask.DisplayMember = "Name";
            cbDaqTask.ValueMember = "Name";

        }

        private void cbDaqTask_DropDown(object sender, EventArgs e)
        {
            if (cbDevice.SelectedIndex < 0)
            {
                MessageBox.Show("Device Must be selected first");
                return;
            }

            cbDaqTask.DataSource = Server.DaqTasks.FindAll(T => T.Device.Name == cbDevice.Text).ToDataTable();
            cbDaqTask.DisplayMember = "Name";
            cbDaqTask.ValueMember = "Name";
        }

        private void cbDaqTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAnalogInput.DataSource= Server.AnalogInputs.FindAll(T=>T.Task.Name == cbDaqTask.Text).ToDataTable();  
        }

        private void cbAnalogInput_DropDown(object sender, EventArgs e)
        {
            if (cbDaqTask.SelectedIndex < 0)
            {
                MessageBox.Show("DaqTask Must be selected first");
                return;
            }

            cbAnalogInput.DataSource = Server.AnalogInputs.FindAll(T => T.Task.Name == cbDaqTask.Text).ToDataTable();
            cbAnalogInput.DisplayMember = "Name";
            cbAnalogInput.ValueMember = "Name";
        }

        private void cbAnalogInput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            apply();
        }

        private void cbAnalogInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Station.Inititialize();
            this.Close();
        }

        private void nudScanningTime_ValueChanged(object sender, EventArgs e)
        {
            Station.SamplingTime = (int)nudScanningTime.Value;
        }


    }
}
