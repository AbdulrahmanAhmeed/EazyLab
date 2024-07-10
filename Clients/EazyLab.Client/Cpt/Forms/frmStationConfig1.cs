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

namespace EazyLabClient.SimpleDaq.Forms
{
    public partial class frmStationConfig1 : Form
    {
        public List<EazyLab.Model.AnalogInputConfig> AnalogInputConfigs = new List<EazyLab.Model.AnalogInputConfig>();
        public Server Server = new Server();
        public int StationNo = 0;
        public frmStationConfig1()
        {
            InitializeComponent();
        }

        public frmStationConfig1(Server ser, int stationNo)
        {
            InitializeComponent();
            Server = ser;
        }


        private void Configuration_Load(object sender, EventArgs e)
        {

        }



        void InitializeTree()
        {

            foreach (var config in AnalogInputConfigs)
            {
                TreeNode t = new TreeNode(config.Name);
                t.Tag = config;
                //treeView.Nodes.Add(t);
            }


        }

        void Initialize()
        {
            try
            {
                DataPacket dp = new DataPacket();
                var config = new EazyLab.Model.AnalogInputConfig();
                var props = config.GetType().GetProperties();
                props = dp.GetType().GetProperties();
                AnalogInputConfigs.Clear();
                for (int i = 1; i < props.Length; i++)
                {
                    config = new EazyLab.Model.AnalogInputConfig();
                    config.Name = props[i].Name;
                    config.CommChannel = new EazyLab.Model.CommChannel();
                    config.Device = new EazyLab.Model.Device();
                    config.DaqTask = new EazyLab.Model.DaqTask();
                    config.AnalogInput = new EazyLab.Model.AnalogInput();
                    AnalogInputConfigs.Add(config);

                }



            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);

            }



        }


        private void button1_Click(object sender, EventArgs e)
        {
            Initialize();
        }

    }
}
