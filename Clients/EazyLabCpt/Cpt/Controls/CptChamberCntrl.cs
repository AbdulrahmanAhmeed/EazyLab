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
            foreach (var C in StdControls)
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


        public void LoadEvents()
        {

            if (chamber.SampleReadyEvent == null) chamber.SampleReadyEvent += SampleReady;
            if (chamber.SelectStationEvent == null) chamber.SelectStationEvent += SelectStation;
        }

        /// <summary>
        /// Updates the All the  Controls in this display.
        /// </summary>
        /// <param name="dp">The Lastdp.</param>
        public void UpdateDisplay(CptDataPacketVer1 dp)
        {

            try
            {
                try
                {
                    if (!SelectedStation.IsTestStarted)
                    {
                        if (tbtnStart.State)
                        {
                            StopTest();
                        }
                    }
                }
                catch (Exception ex) { 
                    LoggerFile.WriteException(ex);
                }
                editString1.Value.AsString = SelectedStation.Test.CptSample == null ? editString1.Name : SelectedStation.Test.CptSample.SerialNo;
                pvTemp1.Value.AsDouble = dp.Temp0;
                pvTemp2.Value.AsDouble = dp.Temp1;
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
                tbtnStart.State = SelectedStation.IsTestStarted;
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
        }
        void CheckSelectedStationStatus()
        {
            if (SelectedStation != null)
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
        int yMax = 100;
        int yMin = 1;

        void UpdateControls(CptDataPacketVer1 dp, string text)
        {
            Lastdp = dp;
            ledStatus.Value = !ledStatus.Value;
            UpdateDisplay(dp);
        }

        void UpdateSampleControl(string text)
        {
            editString1.Value.AsString = text;
        }

        private void DataReady(object sender, DataReadyEventArgs e)
        {
            bool status = true;
            string errorMessages = string.Empty;
            if (SelectedStation.IsTestStarted && e.DataPacket.CptError != null)
                CheckTemp(e.DataPacket);

            Invoke(new Action(() => UpdateControls(e.DataPacket, e.Result.ToString())));
            //Lastdp = e.DataPacket;
            //ledStatus.Value = !ledStatus.Value;

        }

        private bool CheckTemp(CptDataPacketVer1 data)
        {
            bool error = false;
            if (data.CptError.Temp1 != CptError.ErrorState.noError)
            {
                pvTemp1.ForeColor = System.Drawing.Color.Red;
                error = true;
            }
            if (data.CptError.Temp2 != CptError.ErrorState.noError)
            {
                pvTemp2.ForeColor = System.Drawing.Color.Red;
                error = true;
            }
            if (data.CptError.Temp3 != CptError.ErrorState.noError)
            {
                pvTemp3.ForeColor = System.Drawing.Color.Red;
                error = true;
            }
            if (data.CptError.Temp4 != CptError.ErrorState.noError)
            {
                pvTemp4.ForeColor = System.Drawing.Color.Red;
                error = true;
            }
            if (data.CptError.Temp5 != CptError.ErrorState.noError)
            {
                pvTemp5.ForeColor = System.Drawing.Color.Red;
                error = true;
            }
            if (data.CptError.Temp6 != CptError.ErrorState.noError)
            {
                pvTemp6.ForeColor = System.Drawing.Color.Red;
                error = true;
            }
            if(data.CptError.Current != CptError.ErrorState.noError)
            {
                pvCurrent.ForeColor = System.Drawing.Color.Red;
                error = true;
            }
            if (error) SelectedStation.SetDO(5, true);
            return true;
        }

        private void SampleReady(object sender, SampleReadyEventArgs e)
        {
            sample = e.cptSample;
            SelectedStation.Test.CptSample = sample;
            SelectedStation.StartTest(true);
            

            Invoke(new Action(() => UpdateSampleControl(e.cptSample.SerialNo)));
            //Lastdp = e.DataPacket;
            //ledStatus.Value = !ledStatus.Value;

        }

        private void SelectStation(object sender , EventArgs e)
        {
            if(SelectedStation != null)
                SelectedStation.Selected = false;
            SelectedStation = chamber.Stations.First(x => x.Selected);

        }

        void UpdateCbStation()
        {
            try
            {
                CbStation.DataSource = chamber.Stations;
                CbStation.DisplayMember = "Name";
                CbStation.ValueMember = "Name";
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
                tbtnStart.State = SelectedStation.IsTestStarted;
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }

        }

        private void StopTest()
        {
                SelectedStation.StartTest(false);
                tbtnStart.State = false;
                return;
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
                    if (sample != null)
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
            tbtnStart.State = SelectedStation.IsTestStarted;
        }

        public void SelectStation(int stNo)
        {
            try
            {
                UpdateCbStation();
                CbStation.SelectedIndex = stNo;
                CbStation.SelectedValue = Chamber.Stations[stNo].Name;
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
        }

        private void Plot_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
                
                if (SelectedStation != null) { 
                    SelectedStation.DataReadyEvent -= DataReady;
                    UnSubscribeAllPVs();
                    SelectedStation!.Selected = false;
                }
                SelectedStation = Chamber.Stations[CbStation.SelectedIndex];
                SelectedStation.Selected = true;
                SelectedStation.DataReadyEvent += DataReady;
                btnConnect.State = SelectedStation.IsConnected;
                tbtnStart.State = SelectedStation.IsTestStarted;
                var lastDq = new CptDataPacketVer1();
                SubscribeAllPVs();
                foreach (var data in SelectedStation.Test.Data)
                {
                    pvTemp1.Value.AsDouble = data.Temp0;
                    pvTemp2.Value.AsDouble = data.Temp1;
                    pvTemp3.Value.AsDouble = data.Temp2;
                    pvTemp4.Value.AsDouble = data.Temp3;
                    pvTemp5.Value.AsDouble = data.Temp4;
                    pvTemp6.Value.AsDouble = data.Temp5;
                    pvCurrent.Value.AsDouble = data.Current;
                    pvPower.Value.AsDouble = data.Power;
                    pvVoltage.Value.AsDouble = data.Voltage;
                    pvEnergy.Value.AsDouble = data.Energy;
                    Plot.Update(data.Time);
                    RefreshPlot();
                    lastDq = data;
                }

                UpdateDisplay(lastDq);
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
        }
        private void SubscribeAllPVs()
        {
            if (pvTemp1.IsSelectedForPloting)
            {
                Subscribe(pvTemp1);
            }
            if (pvTemp2.IsSelectedForPloting)
            {
                Subscribe(pvTemp2);
            }
            if (pvTemp3.IsSelectedForPloting)
            {
                Subscribe(pvTemp3);
            }
            if (pvTemp4.IsSelectedForPloting)
            {
                Subscribe(pvTemp4);

            }
            if (pvTemp5.IsSelectedForPloting)
            {
                Subscribe(pvTemp5);

            }
            if (pvTemp6.IsSelectedForPloting)
            {
                Subscribe(pvTemp6);
            }
        }
        private void UnSubscribeAllPVs()
        {
            if (pvTemp1.IsSelectedForPloting) {

                UnSubscribe(pvTemp1);
                pvTemp1.IsSelectedForPloting = false;
                pvTemp1.IsSelectedForPloting = true;
                //UnSubscribe(pvTemp1);
                //Subscribe(pvTemp1);
            }
            if (pvTemp2.IsSelectedForPloting) {
                
                
                pvTemp2.IsSelectedForPloting = false;
                UnSubscribe(pvTemp2);
                pvTemp2.IsSelectedForPloting = true;
            }
            if (pvTemp3.IsSelectedForPloting)
            {
               
                
                pvTemp3.IsSelectedForPloting = false;
                UnSubscribe(pvTemp3);
                pvTemp3.IsSelectedForPloting = true;

            }
            if (pvTemp4.IsSelectedForPloting)
            {
                
                
                pvTemp4.IsSelectedForPloting = false;
                UnSubscribe(pvTemp4);
                pvTemp4.IsSelectedForPloting = true;

            }
            if (pvTemp5.IsSelectedForPloting)
            {
                
                
                pvTemp5.IsSelectedForPloting = false;
                UnSubscribe(pvTemp5);
                pvTemp5.IsSelectedForPloting = true;

            }
            if (pvTemp6.IsSelectedForPloting)
            {
                
                pvTemp6.IsSelectedForPloting = false;
                UnSubscribe(pvTemp6);
                pvTemp6.IsSelectedForPloting = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedStation.Test.CptSample = Server.DbAccess.GetAll<CptSample>().Where(x => x.SerialNo == "2401000").FirstOrDefault();
                sample = SelectedStation.Test.CptSample;
                
                UpdateSampleControl(SelectedStation.Test.CptSample.SerialNo);
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }

        private void checkLimit_CheckedChanged(object sender, EventArgs e)
        {

            PlotYAxis axis = null;

            try
            {
                
                foreach (CptProfile profile in SelectedStation.Test.CptSample.Profiles)
                {
                    axis = Plot.YAxes[profile.Source.ToString()];
                    if (axis == null)
                    {
                        continue;
                    }
                    if (profile.LowerLimitSubs == null && profile.UpperLimitSubs == null)
                    {
                        profile.InitializeSubscribers(axis);
                    }
                    if(!checkLimit.Checked)
                    {
                        if(profile.UpperLimitSubs != null) Plot.UnSubscribe(profile.UpperLimitSubs);
                        if(profile.LowerLimitSubs != null)Plot.UnSubscribe(profile.LowerLimitSubs);
                    }
                    else
                    {
                        profile.UpperLimitSubs.YAxis = axis;
                        profile.LowerLimitSubs.YAxis = axis;
                        if (profile.UpperLimitSubs != null) Plot.Subscribe(profile.UpperLimitSubs);
                        if (profile.LowerLimitSubs != null) Plot.Subscribe(profile.LowerLimitSubs);

                    }

    
                }

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

        private void Subscribe(PV pV)
        {
            var profile = SelectedStation.Test.CptSample.Profiles.Where(x => x.Source == (CptProfile.ProfileSource)Enum.Parse(typeof(CptProfile.ProfileSource), pV.TagName.Replace("►", ""))).FirstOrDefault();
            if (profile != null)
            {
                var axis = Plot.YAxes[profile.Source.ToString()];
                InitializeSubscribers(profile);
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
                    Plot.UnSubscribe(profile.LowerLimitSubs);
                    Plot.UnSubscribe(profile.UpperLimitSubs);
                }
                else
                {
                    Plot.UnSubscribe(profile.LowerLimitSubs);
                    Plot.UnSubscribe(profile.UpperLimitSubs);
                }
            }
        }
        private void pvTemp_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var pv = (PV)sender;
                
                
                if (pv.IsSelectedForPloting)
                {
                    if (SelectedStation.IsTestStarted)
                    {
                        var lastDb = new CptDataPacketVer1();


                        foreach (var data in SelectedStation.Test.Data)
                        {
                            if (pv == pvTemp1)
                                pv.Value.AsDouble = data.Temp0;
                            else if (pv == pvTemp2)
                                pv.Value.AsDouble = data.Temp1;
                            else if (pv == pvTemp3)
                                pv.Value.AsDouble = data.Temp2;
                            else if (pv == pvTemp4)
                                pv.Value.AsDouble = data.Temp3;
                            else if (pv == pvTemp5)
                                pv.Value.AsDouble = data.Temp4;
                            else if (pv == pvTemp6)
                                pv.Value.AsDouble = data.Temp5;
                            else if (pv == pvCurrent)
                                pv.Value.AsDouble = data.Current;
                            else if (pv == pvPower)
                                pv.Value.AsDouble = data.Power;
                            else if (pv == pvVoltage)
                                pv.Value.AsDouble = data.Voltage;
                            else if (pv == pvEnergy)
                                pv.Value.AsDouble = data.Energy;
                            Plot.Update(pv.PlotSubscriber, data.Time);
                            lastDb = data;
                        }
                        RefreshPlot();
                        UpdateDisplay(lastDb);
                        if (checkLimit.Checked)
                        {

                            Subscribe(pv);
                        }
                        else
                        {
                            UnSubscribe(pv);
                        }
                    }

                }
                else
                {
                    UnSubscribe(pv);
                }



            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
