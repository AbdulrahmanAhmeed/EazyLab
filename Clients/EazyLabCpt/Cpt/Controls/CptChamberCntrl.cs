using EazyLab.Classes;
using EazyLab.Cpt.Classes;
using EazyLab.Design;
using EazyLab.Design.Components;
using EazyLab.Instrumentation.Plotting;
using EazyLab.Instrumentation.Standard;
using EazyLabClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Windows.UI;
using static System.Net.Mime.MediaTypeNames;

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
                RefreshPlot();
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
            bool status = true;
            string errorMessages = string.Empty;
            if(SelectedStation.IsTestStarted && e.DataPacket.CptError != null) 
                CheckTemp(e.DataPacket);
            
            Invoke(new Action(() => UpdateControls(e.DataPacket, e.Result.ToString())));
            //Lastdp = e.DataPacket;
            //ledStatus.Value = !ledStatus.Value;
            
        }

        private bool CheckTemp( CptDataPacketVer1 data)
        {
            if (data.CptError.Temp1 != CptError.ErrorState.noError)
                pvTemp1.ForeColor = System.Drawing.Color.Red;
            if(data.CptError.Temp2 != CptError.ErrorState.noError)
                pvTemp2.ForeColor = System.Drawing.Color.Red;
            if(data.CptError.Temp3 != CptError.ErrorState.noError)
                pvTemp3.ForeColor = System.Drawing.Color.Red;
            if(data.CptError.Temp4 != CptError.ErrorState.noError)
                pvTemp4.ForeColor = System.Drawing.Color.Red;
            if(data.CptError.Temp5 != CptError.ErrorState.noError)
                pvTemp5.ForeColor = System.Drawing.Color.Red;
            if(data.CptError.Temp6 != CptError.ErrorState.noError)
                pvTemp6.ForeColor = System.Drawing.Color.Red;
            return true;
        }

        private void SampleReady(object sender, SampleReadyEventArgs e)
        {
            sample = e.cptSample;
            SelectedStation.Test.CptSample = sample;
            cbSource.Items.Clear();
            try
            {
                foreach (var profile in SelectedStation.Test.CptSample.Profiles)
                {
                    cbSource.Items.Add(profile.Source.ToString());
                }
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
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
            if (!tbtnStart.State)
            {
                SelectedStation.StartTest(false);
                tbtnStart.State = false;
                return;
            }
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
            cbSource.Items.Clear();
            try
            {
                foreach (var profile in SelectedStation.Test.CptSample.Profiles)
                {
                    cbSource.Items.Add(profile.Source.ToString());
                }
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
            UpdateSampleControl(SelectedStation.Test.CptSample.SerialNo);
        }

        private void checkUpperLimit_CheckedChanged(object sender, EventArgs e)
        {
            
            PlotYAxis axis = null;
            
            try
            {
                //CptProfile profile = SelectedStation.Test.CptSample.Profiles.
                //    Where(x => x.Source == (CptProfile.ProfileSource)Enum.Parse(typeof(CptProfile.ProfileSource), cbSource.Text)).First();
                foreach(CptProfile profile in SelectedStation.Test.CptSample.Profiles)
                {
                    
                    var source = cbSource.Text;
                    SelectedStation.Test.CptSample.SelectedSource = (CptProfile.ProfileSource)Enum.Parse(typeof(CptProfile.ProfileSource), profile.Source.ToString());
                    axis = Plot.YAxes[profile.Source.ToString()];
                    if (axis == null)
                    {
                        continue;
                    }
                    if (profile.LowerLimitSubs == null && profile.UpperLimitSubs == null)
                    {
                        profile.InitializeSubscribers(axis);
                    }
                    try
                    {
                        var data = Server.DbAccess.GetAll<CptTagController>();
                        profile.LowerLimitSubs.Color = profile.LowerLimitRGP == 0 ? System.Drawing.Color.Gray: System.Drawing.Color.FromArgb(profile.LowerLimitRGP);  //System.Drawing.Color.FromArgb(data.Find(x => x.Name == nameof(CptProfile.LowerLimit)).RGB);
                        profile.UpperLimitSubs.Color = profile.UpperLimitRGP == 0 ? System.Drawing.Color.Yellow : System.Drawing.Color.FromArgb(profile.UpperLimitRGP);
                        if(profile.Source.ToString() == pvTemp1.TagName.Replace("►","") && pvTemp1.IsSelectedForPloting && checkUpperLimit.Checked)
                        {
                            Plot.Subscribe(profile.LowerLimitSubs);
                            Plot.Subscribe(profile.UpperLimitSubs);
                        }
                        else if (profile.Source.ToString() == pvTemp2.TagName.Replace("►", "") && pvTemp2.IsSelectedForPloting && checkUpperLimit.Checked)
                        {
                            Plot.Subscribe(profile.LowerLimitSubs);
                            Plot.Subscribe(profile.UpperLimitSubs);
                        }
                        else if (profile.Source.ToString() == pvTemp3.TagName.Replace("►", "") && pvTemp3.IsSelectedForPloting && checkUpperLimit.Checked)
                        {
                            Plot.Subscribe(profile.LowerLimitSubs);
                            Plot.Subscribe(profile.UpperLimitSubs);
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }

                //SelectedStation.Test.CptSample.Profile.LowerLimitSubs.Color = lowerLimitColor.Color;
                    
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);

            }
        }

        private void InitializeSubscribers(CptProfile profile)
        {
            var axis = Plot.YAxes[profile.Source.ToString()];
            if (axis == null)
            {
                return;
            }
            profile.InitializeSubscribers(axis);
            var data = Server.DbAccess.GetAll<CptTagController>();
            profile.LowerLimitSubs.Color = System.Drawing.Color.FromArgb(profile.LowerLimitRGP);  //System.Drawing.Color.FromArgb(data.Find(x => x.Name == nameof(CptProfile.LowerLimit)).RGB);
            profile.UpperLimitSubs.Color = System.Drawing.Color.FromArgb(profile.UpperLimitRGP);
        }

        //private void btLower_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogResult = colorDialog1.ShowDialog();
        //    // = colorDialog1.ShowDialog();
        //    if (dialogResult == DialogResult.OK)
        //    {

        //        try
        //        {
        //            var obj = new CptTagController()
        //            {
        //                Name = nameof(CptProfile.LowerLimitSubs),
        //                RGB = colorDialog1.Color.ToArgb(),
        //            };
        //            if (SelectedStation.Test.CptSample.Profiles.Where(x => x.Source == CptProfile.ProfileSource.Temp1).First().LowerLimitSubs != null)
        //            {
        //                SelectedStation.Test.CptSample.Profiles.Where(x => x.Source == CptProfile.ProfileSource.Temp1).First().LowerLimitSubs.Color = colorDialog1.Color;

        //            }
        //            Server.DbAccess.Upsert(obj);
        //        }
        //        catch (Exception ex)
        //        {

        //            MessageBox.Show("Please Add Sample");
        //        }
        //        //btColorDialog.BackColor = colorDialog1.Color;
        //    }
        //}

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbSource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void multiSelectionComboBox1_Click(object sender, EventArgs e)
        {
        }

        private void Subscribe(PV pV)
        {
            var profile = SelectedStation.Test.CptSample.Profiles.Where(x => x.Source == (CptProfile.ProfileSource)Enum.Parse(typeof(CptProfile.ProfileSource), pV.TagName.Replace("►", ""))).FirstOrDefault();
            if (profile != null)
            {
                if (profile.LowerLimitSubs == null && profile.UpperLimitSubs == null)
                {
                    InitializeSubscribers(profile);
                }
                Plot.Subscribe(profile.LowerLimitSubs);
                Plot.Subscribe(profile.UpperLimitSubs);
                
            }
        }
        private void UnSubscribe(PV pV)
        {
            var profile = SelectedStation.Test.CptSample.Profiles.Where(x => x.Source == (CptProfile.ProfileSource)Enum.Parse(typeof(CptProfile.ProfileSource), pV.TagName.Replace("►", ""))).FirstOrDefault();
            if (profile != null)
            {
                if (profile.LowerLimitSubs == null && profile.UpperLimitSubs == null)
                {
                    InitializeSubscribers(profile);
                }

                Plot.UnSubscribe(profile.LowerLimitSubs);
                Plot.UnSubscribe(profile.UpperLimitSubs);
            }
        }
        private void pvTemp1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
               if(pvTemp1.IsSelectedForPloting && checkUpperLimit.Checked)
                {
                    Subscribe(pvTemp1);
                }
                else
                {
                    UnSubscribe(pvTemp1);
                }

            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }

        private void pvTemp2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (pvTemp2.IsSelectedForPloting && checkUpperLimit.Checked)
                {
                    Subscribe(pvTemp2);
                }
                else
                {
                    UnSubscribe(pvTemp2);
                }

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
