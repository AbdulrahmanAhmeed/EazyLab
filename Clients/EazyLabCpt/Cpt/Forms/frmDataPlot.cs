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
using EazyLab;
using EazyLab.Classes;
using Syncfusion.XlsIO;

namespace Client.Forms
{
    public partial class frmDataPlot : frmTempDisp
    {
        private List<DataPacket> Data = new List<DataPacket>();
        private String FileName;
        public frmDataPlot()
        {
            InitializeComponent();
            foreach (var dp in Program.Chamber.Sample.StoreAllData) Data.Add(dp);
           FileName =   Program.Chamber.Sample.FileName; 
            combinedPlot1.XAxes[0].ScaleDisplay.TextFormatting.DateTimeFormat =  "dd / MMM HH: mm";
            combinedPlot1.XAxes[0].ScaleDisplay.TextFormatting.Style =EazyLab.Types.TextFormatDoubleStyle.DateTime; 
        
        }

        private void DataPlot_Load(object sender, EventArgs e)
        {
            //bSettings.Enabled = false;
            //tBConnect.Enabled = false;
            //bStart.Enabled = false;
            
            tableLayoutPanel2.Hide();
            tableLayoutPanel1.Height = this.Height - 200;
            timerPlot.Start();
        }



        double GetValueFromDataPacket(Client.Classes.DataPacket dp, string Name)
        {
            double res = 0;
            switch (Name)
            {
                case "InDoor DBT":
                    return dp.InDoorDbt;
                    
                case "InDoor WBT":
                    return dp.InDoorWbt;
                    
                case "InDoor Hum":
                    return dp.InDoorHum;
                     
                case "Volt":
                    return dp.Voltage;
                    
                case "Current":
                    return dp.Current;
                     
                case "Power":
                    return dp.Power;
                     
                case "Power Factor":
                    return dp.PowerFactor;
                    
                case "Ct DBT":
                    return dp.CodeTesterDbT;
                     
                case "Ct WBT":
                    return dp.CodeTesterWbt;
                     
                case "Ct Cooling Cap.":
                    return dp.CoolingCapacity;
                     
                case "Ct Static Press":
                    return dp.StaticPress;
                    
                case "Air Flow":
                    return dp.AirFlowRate;
                     
                case "Barometric Press":
                    return dp.AtmosphericPress;
                     
                case "OutDoor DBT":
                    return dp.OutDoorDbt;
                     
                case "OutDoor WBT":
                    return dp.OutDoorWbt;
                    
                case "OutDoor Hum":
                    return dp.OutDoorHum;
                   




            }
            return res;

        }

        private void timerPlot_Tick(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;  

            if (cb.Checked)  Subscribe(cb);
               else  UnSubscribe(cb);

            for (int i = 0; i < combinedPlot1.Channels.Count; i++)
            {
                var ch = Subscribers.First(T => T.Text == combinedPlot1.Channels[i].Name);
                for (int j = 0; j < Data.Count; j++)
                {
                    var v = GetValueFromDataPacket(Data[j], ch.Text);
                    combinedPlot1.Channels[i].AddXY(Data[j].Time, v);
                }

            }

        }

        private List<CheckBox> Subscribers = new List<CheckBox>();

        private void ConstructChannels()
        {
            combinedPlot1.Channels.Clear();
            foreach (var pv in Subscribers)
            {
                PlotChannelTrace p = new PlotChannelTrace();
                p.Name = pv.Text;

                combinedPlot1.Channels.Add(p);


            }

        }
        int NoOFChannels = 4;
        public void Subscribe(CheckBox pv)
        {
            if (!Subscribers.Contains(pv))
            {
                if (Subscribers.Count == NoOFChannels) // Subscribtion is full
                {
                    Subscribers.RemoveAt(0);
                }
                Subscribers.Add(pv);
            }
            ConstructChannels();
        }

        public void UnSubscribe(CheckBox pv)
        {
            if (Subscribers.Contains(pv))
            {
                Subscribers.Remove(pv);
                List<PlotChannelTrace> chanelstoremove = new List<PlotChannelTrace>();
            }
            ConstructChannels();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data = new List<DataPacket>(); 
            foreach (var dp in Program.Chamber.Sample.StoreAllData) Data.Add(dp);
            for (int i = 0; i < combinedPlot1.Channels.Count; i++)
            {
                combinedPlot1.Channels[i].Clear(); 
                var ch = Subscribers.First(T => T.Text == combinedPlot1.Channels[i].Name);
                for (int j = 0; j < Data.Count; j++)
                {
                    var v = GetValueFromDataPacket(Data[j], ch.Text);
                    combinedPlot1.Channels[i].AddXY(Data[j].Time, v);
                }

            }
        }

        public void ExportToExcel(ExcelVersion version)
        {
            try
            {
                using (ExcelEngine ee = new ExcelEngine())
                {
                    IApplication app = ee.Excel;
                    app.DefaultVersion = version;
                    IWorkbook workbook = app.Workbooks.Create(1);

           
                        IWorksheet worksheet = workbook.Worksheets[0];
                        var dt = Data.ToDataTable(); //
                        if (dt.Columns["CoolCapacityCalibration"] != null) dt.Columns.Remove("CoolCapacityCalibration");
                        if (dt.Columns["UnCorredtedCoolCapacity"] != null) dt.Columns.Remove("UnCorredtedCoolCapacity");
                        worksheet.ImportDataTable(dt, true, 1, 1);
                    

                    workbook.SaveAs(FileName + "_All.xls");

                }
            }
            catch (Exception e)
            {
                LoggerFile.WriteException(e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportToExcel(ExcelVersion.Excel2016);
        }
    }
}
