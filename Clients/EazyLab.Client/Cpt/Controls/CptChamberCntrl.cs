using EazyLab.Classes;
using EazyLab.Cpt.Classes;
using EazyLab.Instrumentation.Standard;
using EazyLabClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EazyLab.Cpt.Controls
{


    public partial class CptChamberCntrl : UserControl
    {
        private CptChamber chamber;
        public CptChamber Chamber { get => chamber; set => chamber = value; }
        int number_of_Graphs = 0, Maximum_Grphs = 3;

        public List<StdControlBase> StdControls;// = new List<StdControlBase>();// List to hold all PV in this user control

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
            StdControls = new List<StdControlBase>();
            GetPVControls(this.Controls);
            foreach (Control C in StdControls)
            {
                C.Dock = DockStyle.Fill;
                ((PV)C).Plot = this.Plot; 
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
                if (control.GetType().IsSubclassOf(typeof(StdControlBase)))
                    StdControls.Add((StdControlBase)control);
                else GetPVControls(((Control)control).Controls);
            }
        }

        /// <summary>
        /// Updates the All the  Controls in this display.
        /// </summary>
        /// <param name="dp">The Lastdp.</param>
        public void UpdateDisplay()
        {

            try
            {
                pvTemp1.Value = Lastdp.Temp0;
                pvTemp2.Value = Lastdp.Temp1;
                pvTemp3.Value = Lastdp.Temp2;
                pvTemp4.Value = Lastdp.Temp3;
                pvTemp5.Value = Lastdp.Temp4;
                pvTemp6.Value = Lastdp.Temp5;
                pvCurrent.Value = Lastdp.Current;
                pvPower.Value = Lastdp.Power;
                pvVoltage.Value = Lastdp.Voltage;
                pvEnergy.Value = Lastdp.Energy;
                slStart.Value = SelectedStation.IsConnected;
                Plot.Update(Lastdp.Time);
                RefreshPlot();
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
        }

        void RefreshPlot()
        {
            if (Plot.XAxes.Count > 0)
            {
                Plot.XAxes[0].Tracking.ZoomToFitAll();
                Plot.XAxes[0].Tracking.Enabled = true;

            }
            if (Plot.YAxes.Count > 0)
            {
                Plot.YAxes[0].Tracking.ZoomToFitAll();
                Plot.YAxes[0].Tracking.Enabled = true;
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

        private void DataReady(object sender, DataReadyEventArgs e)
        {
            Lastdp = e.DataPacket;
            ledStatus.Value = !ledStatus.Value;
            UpdateDisplay();
        }

        private void CbStation_DropDown(object sender, EventArgs e)
        {
            try
            {
                CbStation.DataSource = chamber.Stations;
                CbStation.DisplayMember = "SerialNo";
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConnect.State)
                {
                    SelectedStation.Connect();

                }
                else
                {
                    SelectedStation.DisConnect();

                }
                btnConnect.State = SelectedStation.IsConnected;
                tbtnStart.State= SelectedStation.IsConnected;
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
                    if (!SelectedStation.IsStarted) 
                    {  if(tbtnStart.State)  SelectedStation.Start(); 
                       else SelectedStation.Stop();
                    
                    }
                 
                }
                else
                {
                    MessageBox.Show("Station is not Connected");

                }
            }
            tbtnStart.State=SelectedStation.IsStarted;
        }


        private void CbStation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (SelectedStation != null) SelectedStation.DataReadyEvent -= DataReady;
                SelectedStation = Chamber.Stations[CbStation.SelectedIndex];
                SelectedStation.DataReadyEvent += DataReady;
                btnConnect.State = SelectedStation.IsConnected;
                tbtnStart.State = SelectedStation.IsStarted;
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
        }


    }
}
