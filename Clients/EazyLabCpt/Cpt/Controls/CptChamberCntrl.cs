using EazyLab.Classes;
using EazyLab.Cpt.Classes;
using EazyLab.Instrumentation.Plotting;
using EazyLab.Instrumentation.Standard;
using EazyLabClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Windows.UI;

namespace EazyLab.Cpt.Controls
{


    public partial class CptChamberCntrl : UserControl
    {
        private CptChamber chamber;
        private CptSample sample;
        
        public CptChamber Chamber { get => chamber; set => chamber = value; }
        int number_of_Graphs = 0, Maximum_Grphs = 3;

        public List<PV> StdControls;// = new List<StdControlBase>();// List to hold all PV in this user control
        public CptStation SelectedStation;
        public int SelectedStationIndex = 0;
        public bool Chamber_Reading = false;
        CptDataPacketVer1 Lastdp = new CptDataPacketVer1();


        public CptChamberCntrl()
        {
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
            InitializeComponent();
            StdControls = new List<PV>();
            GetPVControls(this.Controls);
            foreach (var  C in StdControls)
            {
                C.Dock = DockStyle.Fill;
                C.Plot = this.Plot; 
            }

        }

        /// <summary>
        /// Gets the All the PV controls in this form.
        /// and store them to StdControl list
        /// </summary>
        /// <param name="controls">The controls.</param>
        private void GetPVControls(ControlCollection controls)
        {
            foreach (var control in controls)
            {
                //if (((StdControlBase) control).GetType() == typeof(StdControlBase)) 
                //    StdControls.Add((StdControlBase)control);
                //else GetPVControls(((Control)control).Controls);
                ////////////////////////////////////////
                //if (control.GetType().IsSubclassOf(typeof(StdControlBase)))
                //    StdControls.Add((StdControlBase)control);
                //else GetPVControls(((Control)control).Controls);
                if (control.GetType().IsSubclassOf(typeof(StdControlBase)))
                    StdControls.Add((PV)control);
                else GetPVControls(((Control)control).Controls);
            }
        }

        /// <summary>
        /// Updates the All the  Controls in this display.
        /// </summary>
        /// <param name="dp">The Lastdp.</param>
        public void UpdateDisplay(CptDataPacketVer1 dp  )
        {

            try
            {
                if (chamber.SampleReadyEvent == null) chamber.SampleReadyEvent += SampleReady;
                
                pvTemp1.Value.AsDouble = dp.Temp0;
                pvTemp2.Value.AsDouble  = dp.Temp1;
                pvTemp3.Value.AsDouble = dp.Temp2;
                pvTemp4.Value.AsDouble = dp.Temp3;
                pvTemp5.Value.AsDouble = dp.Temp4;
                pvTemp6.Value.AsDouble = dp.Temp5;
                pvCurrent.Value.AsDouble = dp.Current;
                pvPower.Value.AsDouble = dp.Power;
                pvVoltage.Value.AsDouble = dp.Voltage;
                pvEnergy.Value.AsDouble = dp.Energy;
                Plot.Update(dp.Time);
                //RefreshPlot();
                CheckSelectedStationStatus();
                led1.Indicator.Text = SelectedStation.SampleStatus.ToString();
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
        }
        void CheckSelectedStationStatus()
        {
            if(SelectedStation != null)
            {
                EnableButtons();
            }
            else
            {
                DisableButtons();
            }
            
        }

        void EnableButtons()
        {
            btnConnect.Enabled = true;
            tbtnStart.Enabled = true;
            btnSampleOn.Enabled = true;
        }
        void DisableButtons()
        {
            btnConnect.Enabled = false;
            tbtnStart.Enabled = false;
            btnSampleOn.Enabled = false;
        }

        void RefreshPlot()
        {
            if (Plot.XAxes.Count > 0)
            {
                Plot.XAxes[0].Tracking.ZoomToFitAll();
                //Plot.XAxes[0].Tracking.Enabled = true;

            }
            if (Plot.YAxes.Count > 0)
            {
                Plot.YAxes[0].Tracking.ZoomToFitAll();
               // Plot.YAxes[0].Tracking.Enabled = true;
            }
            
        }

        public void ResetPVs()
        {
            foreach (var ss in StdControls)
            {
                var pv = (PV)ss;
                pv.IsSelectedForPloting = false;
            }
        }

        public void SetStation(int index)
        {
            // CBSamples.DataSource = Program.Chamber.Stations;

            foreach (var R in Program.Chamber.Stations)
                CbStation.Items.Add(R);
            CbStation.SelectedIndex = index;
        }
        int x = 1;
        int yMax=100;
        int yMin=1;

        void UpdateControls(CptDataPacketVer1 dp, string text)
        {
            Lastdp = dp;
            ledStatus.Value = !ledStatus.Value;
            UpdateDisplay(dp);
        }

        void UpdateSampleControl( string text)
        {
            editString1.Value.AsString = text;
        }

        private void DataReady(object sender, DataReadyEventArgs e)
        {
            Invoke(new Action(() => UpdateControls(e.DataPacket, e.Result.ToString())));
            //Lastdp = e.DataPacket;
            //ledStatus.Value = !ledStatus.Value;
            
        }

        private void SampleReady(object sender, SampleReadyEventArgs e)
        {
            sample = e.cptSample;
            Invoke(new Action(() => UpdateSampleControl( e.cptSample.SerialNo)));
            //Lastdp = e.DataPacket;
            //ledStatus.Value = !ledStatus.Value;

        }

        void UpdateCbStation()
        {
            try
            {
                CbStation.DataSource = chamber.Stations;
                CbStation.DisplayMember = "SerialNumber";
                CbStation.ValueMember = "SerialNumber";
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
        }

        private void CbStation_DropDown(object sender, EventArgs e)
        {
            UpdateCbStation(); 

        }

        

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedStation.DataReadyEvent == null) SelectedStation.DataReadyEvent += DataReady;
                
                if (btnConnect.State)
                {
                    SelectedStation.Connect(true);

                }
                else
                {
                    SelectedStation.DisConnect();
                    
                }
                btnConnect.State = SelectedStation.IsConnected;
                tbtnStart.State= SelectedStation.IsTestStarted;
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }

        }

        private void tbtnStart_Click(object sender, EventArgs e)
        {
            if (SelectedStation != null)
            {
                if (SelectedStation.IsConnected)
                {
                    // user should add smaple before start test
                   if(sample != null)
                    {
                        SelectedStation.StartTest(tbtnStart.State);
                        //SelectedStation.Test.CptSample = sample;

                    }         
                    else
                        MessageBox.Show("Please add sample first");



                }
                else
                {
                    MessageBox.Show("Station is not Connected");

                }
            }
            tbtnStart.State=SelectedStation.IsTestStarted;
        }

        public void SelectStation(int stNo)
        {
            try
            {
                UpdateCbStation(); 
                CbStation.SelectedIndex = stNo;
                CbStation.SelectedValue = Chamber.Stations[stNo].SerialNumber; 
            }
            catch (Exception ex)
            {
                 LoggerFile.WriteException (ex);
            }
        }

        private void Plot_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CbStation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pvVoltage_ValueChanged(object sender, ValueDoubleEventArgs e)
        {

        }

        private void btnSampleOn_Click(object sender, EventArgs e)
        {
            SelectedStation.SwitchSample(btnSampleOn.State);    
        }

        private void pvTemp1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (SelectedStation.Test.CptSample.Profile.Source == CptProfile.ProfileSource.Temp1)
                {
                    //Plot.Subscribe(SelectedStation.min);
                    //Plot.Subscribe(SelectedStation.max);
                }

            }
            catch (Exception  ex)
            {

                LoggerFile.WriteException(ex);
            }
        }

        private void pvTemp1_ValueChanged(object sender, ValueDoubleEventArgs e)
        {

        }

        private void CbStation_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (SelectedStation != null) SelectedStation.DataReadyEvent -= DataReady;
                SelectedStation = Chamber.Stations[CbStation.SelectedIndex];
                SelectedStation.DataReadyEvent += DataReady;
                btnConnect.State = SelectedStation.IsConnected;
                tbtnStart.State = SelectedStation.IsTestStarted;
                UpdateDisplay(new CptDataPacketVer1());
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SelectedStation.Test.CptSample = Server.DbAccess.GetAll<CptSample>().Where(x=>x.SerialNo == "2401000").FirstOrDefault();
            sample = SelectedStation.Test.CptSample;
            UpdateSampleControl(SelectedStation.Test.CptSample.SerialNo);
        }

        private void checkUpperLimit_CheckedChanged(object sender, EventArgs e)
        {
            PlotYAxis axis = null; 
            try
            {
                var source = SelectedStation.Test.CptSample.Profile.Source.ToString();
                axis = Plot.YAxes[source];
                if (axis == null)
                {
                    MessageBox.Show(" Please select " + "source");
                    checkUpperLimit.Checked = false;
                    return; 
                }
                SelectedStation.Test.CptSample.Profile.InitializeSubscribers(axis);


                Plot.Subscribe(SelectedStation.Test.CptSample.Profile.LowerLimitSubs); 
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);

            }
        }

        private void editString1_ValueChanged(object sender, ValueStringEventArgs e)
        {

        }

        //private void CbStation_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (SelectedStation != null) SelectedStation.DataReadyEvent -= DataReady;
        //        SelectedStation = Chamber.Stations[CbStation.SelectedIndex];
        //        SelectedStation.DataReadyEvent += DataReady;
        //        if (!SelectedStation.IsConnected) SelectedStation.Connect(true); // if not connected  try to connect
        //        btnConnect.State = SelectedStation.IsConnected;
        //        tbtnStart.State = SelectedStation.IsStarted;
        //        UpdateDisplay(new CptDataPacketVer1());
        //    }
        //    catch (Exception ex)
        //    {
        //        LoggerFile.WriteException(ex);
        //    }
        //}


    }
}
