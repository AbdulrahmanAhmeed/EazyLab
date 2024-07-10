using Client.Classes;
using Syncfusion.XlsIO;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Reports;
using EazyLab;
using EazyLab.AHU;
using EzData;

using EazyLab.Server.Classes;
using MathNet.Numerics.Statistics;
using Microsoft.Build.Logging;

namespace Client.Forms
{

    public partial class frmMainDisp :  frmTempDisp
    {
       // private int graphUpdatePeriod = 60;
        private Classes.Chamber Chamber = Program.Chamber;
        public DataPacket Dp;
        private const int DefaultSegmentSize = 4;
        private bool StoppedDueToerror = false;
        public frmMainDisp()
        {
            InitializeComponent();
        }

        private void frmMainDisp_Load(object sender, EventArgs e)
        {

            glInDoor.Text = "";
            gloutDoor.Text = "";
            glSample.Text = "";
            foreach (EazyLab.Instrumentation.WF40.Combined.PV s in EazyLab.Instrumentation.WF40.Combined.PV.GetAll(this)) //Get All The PV objects 
            {
                s.SevenSegment.Segment.Size = DefaultSegmentSize; // change the size of the Segment to  Defualt
            }
            Dp = new DataPacket();

           // EazyLab.Fault.Intitialize.InitializeDb();
        }

        public void Stop()
        {

            Program.Chamber.Stop();
            bStart.Text = "Start";
            tBConnect.Enabled = true;
            sbSetUp.Enabled = true;
            timerRun.Enabled = false;

        }

        private Client.Classes.Method method = new Classes.Method();
        private int methodNo = 0;
        public override void Start()
        {
            StoppedDueToerror = false;
            timer1.Start();
            if (timerRun.Enabled)
            {
                DialogResult res = MessageBox.Show("Do you to stop This Run", "Warning", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Stop();
                    displayStringStatus.Text = "Run No. " + methodNo.ToString() + "Aborted";
                }
                return;
            }

            sbSetUp.Enabled = false;
            if (!Program.Server.IsStarted)
            {
                MessageBox.Show("system is not Connected");
                return;
            }
            Program.Server.Initialize();
            StartNewSample();


        }
        //private int RunEllapsedTime = 0;
        public bool VoidStabiltiyPeriod = false;
        private int NoOfWaterFalseReading = 0;

        private void timerRun_Tick(object sender, EventArgs e)
        {
            Chamber.UpdateReadings();
            Dp.Read();


            if (Chamber.OutDoorAhu.WaterFlow < 0 || Chamber.InDoorAhu.WaterFlow < 1)
            {
                NoOfWaterFalseReading++;

                if (NoOfWaterFalseReading > 50)
                {
                    Chamber.OutDoorAhu.PowerOn = false;
                    Chamber.InDoorAhu.PowerOn = false;
                    if (Chamber.OutDoorAhu.WaterFlow < 5)
                        Chamber.OutDoorAhu.Message = AHU.AhuMessage.Warring_No_Water_Flow;
                    if (Chamber.InDoorAhu.WaterFlow < 5)
                        Chamber.InDoorAhu.Message = AHU.AhuMessage.Warring_No_Water_Flow;
                    if (frm != null)
                    {
                        frm.Close();
                        frm.Dispose();
                        frm.Refresh();
                    }

                    glSample.Text = "No Water , system is shutting down";
                    Stop();
                }


            }
            else
            {
                NoOfWaterFalseReading = 0;
            }



            if (SystemStable && Dp.Current <= 0.10) glSample.Text = "Please Switch ON the Sample";
            if ((SystemStable || VoidStabiltiyPeriod) && TestReady() && Dp.Current >= 0.500)     // measure 
            {
                glSample.Text = Math.Round((method.MeasureTime - ((double)method.Data.Count * method.SamplingTime / 60)), 2).ToString() + " to complete Data Recording ";
                if (method.AddPacket(Dp)) //packet see if the finsihed
                {
                    timerRun.Stop();// thr timer run    //  Start();// stop  the system . 
                    timer1.Stop();
                    glSample.Text = "Saving Data";
                    Program.Chamber.Sample.Save();
                    glSample.Text = "Data Saved As " + Program.Chamber.Sample.FileName;
                    bool islastmethod = Program.Chamber.Sample.Methods[0].IsFinished;
                    foreach (Method m in Program.Chamber.Sample.Methods)
                    {
                        islastmethod = islastmethod && m.IsFinished;
                    }
                    if (islastmethod)
                    {
                        glSample.Text = "Exporting  Excel File";
                        Program.Chamber.Sample.ExportToExcel(ExcelVersion.Excel2016);
                        glSample.Text = "Excel File Exported  , Test Completed Successffuly ";
                        Stop();
                        return;
                    }
                    Stop();
                    return;

                    StartNewMethod();
                }
            }
        }
        public override void LoadDataProcessingForm()
        {
            bool alldone = true;
            foreach (var m in Program.Chamber.Sample.Methods)
            {
                if (!m.IsFinished) MessageBox.Show(m.Name + " method is not finished");
                alldone = alldone && m.IsFinished;

            }

            if (!alldone)
            {
                MessageBox.Show("YOu must complete all methods before Trying to compute results");
                return;
            }

            Cursor = System.Windows.Forms.Cursors.WaitCursor;
            Client.Forms.frmDataProcessing frm = new frmDataProcessing(Program.Chamber.Sample);
            Client.Reports.Report rpt = new Report(Program.Chamber.Sample);

            Hide();
            frm.ShowDialog();
            rpt.ShowDialog();
            double CsPF = Program.Chamber.Sample.CalcCSPF();

            MessageBox.Show("CSPF = " + CsPF.ToString());
            Show();
            Cursor = System.Windows.Forms.Cursors.Default;

        }

        public frmPrepSampleMessage frm;
        public void StartNewMethod()
        {
            for (int i = 0; i < Program.Chamber.Sample.Methods.Count; i++)
            {
                if (!Program.Chamber.Sample.Methods[i].IsFinished)
                {
                    method = Program.Chamber.Sample.Methods[i];
                    methodNo = i;
                    SystemStable = false;
                    VoidStabiltiyPeriod = false;
                    ReadyTime = 0;
                    Program.Chamber.ActivateMethod(methodNo);

                    if (Program.Chamber.IsStared())
                    {
                        glSample.Text = "Start  Method NO." + methodNo.ToString();
                        Program.Chamber.Restart();
                    }
                    else
                    {
                        Program.Chamber.Start();
                    }
                    tBConnect.Enabled = false;
                    //  sbSetUp.Enabled = false;
                    timerRun.Start();
                    timer1.Start();
                    bStart.Text = "Stop";
                    displayStringStatus.Value = "Run No. " + methodNo.ToString() + "Started";
                    timerRun.Interval = method.SamplingTime * 1000;
                    frm = new frmPrepSampleMessage(methodNo, method);
                    DialogResult result = frm.ShowDialog();
                    frm.Dispose();
                    GC.Collect();
                    if (result == DialogResult.No)
                    {
                        Stop();
                    }

                    //   Stop();
                    return;
                }
            }

        }




        public void StartNewSample()
        {
            bool startError = false;

            try
            {
                if (Program.Chamber.InDoorAhu.RunTask1 != null && Program.Chamber.InDoorAhu.RunTask1.Status == TaskStatus.Running)
                {
                    MessageBox.Show("System is not read " + Program.Chamber.InDoorAhu.RunTask1.Status.ToString());
                    startError = true;
                }
                if (Program.Chamber.OutDoorAhu.RunTask1 != null && Program.Chamber.OutDoorAhu.RunTask1.Status == TaskStatus.Running)
                {

                    MessageBox.Show("System is not read " + Program.Chamber.OutDoorAhu.RunTask1.Status.ToString());
                    startError = true;

                }
                if (startError) return;
                for (int i = 0; i < Program.Chamber.Sample.Methods.Count; i++)
                {
                    if (!Program.Chamber.Sample.Methods[i].IsFinished)
                    {
                        method = Program.Chamber.Sample.Methods[i];
                        methodNo = i;
                        SystemStable = false;
                        VoidStabiltiyPeriod = false;
                        ReadyTime = 0;
                        CoolCapSSD.Clear();
                        Program.Chamber.ActivateMethod(methodNo);
                        if (Program.Chamber.IsStared())
                        {
                            glSample.Text = "Start  Method NO." + methodNo.ToString();
                            Program.Chamber.Restart();
                        }
                        else
                        {
                            Program.Chamber.Start();
                        }
                        tBConnect.Enabled = false;
                        //  sbSetUp.Enabled = false;
                        timerRun.Start();
                        timer1.Start();
                        bStart.Text = "Stop";
                        displayStringStatus.Value = "Run No. " + methodNo.ToString() + "Started";
                        timerRun.Interval = method.SamplingTime * 1000;
                        frm = new frmPrepSampleMessage(methodNo, method);
                        DialogResult result = frm.ShowDialog();
                        //frm.Dispose();
                        //GC.Collect();
                        if (result == DialogResult.No)
                        {
                            Stop();
                        }


                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }

        }


        public bool SystemStable { set; get; }
        public bool IsReady { set; get; }

        public bool TestReady()
        {
            bool inDoorDbtRead = Program.Chamber.InDoorAhu.IsDbtReady;
            pvInDoorDBT.ForeColor = inDoorDbtRead ? Color.Black : Color.Red;
            bool inDoorWbtReady = Program.Chamber.InDoorAhu.IsWbtReady;
            pvInDoorWbt.ForeColor = inDoorWbtReady ? Color.Black : Color.Red;
            bool outDoorDbtReady = Program.Chamber.OutDoorAhu.IsDbtReady;
            pvOutDoorDbt.ForeColor = outDoorDbtReady ? Color.Black : Color.Red;
            bool outDoorWbtReady = Program.Chamber.OutDoorAhu.IsWbtReady;
            pvOutDoorWbt.ForeColor = outDoorWbtReady ? Color.Black : Color.Red;
            IsReady = inDoorDbtRead && inDoorWbtReady && outDoorDbtReady && outDoorWbtReady;// && Program.Chamber.InitializeFinished;
            return IsReady;
        }

        private double ReadyTime = 0;
        private double ThreaSholdCurrent = 0.05;
        Filter CoolCapFilter = new Filter(30 * 5);
        Ssd CoolCapSSD = new Ssd(15 * 30);
       // private int NoOfOutReading = 0;
        private bool CoolingCapacityReady = false;
        public override void UpdateDisplay()
        {
            Dp.Read();
            if (!timerRun.Enabled)
            {

                Chamber.UpdateReadings();
                // Dp.Read();
                // Program.Chamber.Sample.AddDp(Dp);
            }


            var tReady = TestReady();
            //if (!tReady) NoOfOutReading++;
            //else NoOfOutReading = 0;

            glInDoor.Text = Program.Chamber.InDoorAhu.GetLastMessage();
            gloutDoor.Text = Program.Chamber.OutDoorAhu.GetLastMessage();
            displayStringStatus.Value = DateTime.Today.ToString();
            ReadyTime += CoolingCapacityReady&& tReady && Dp.Current > ThreaSholdCurrent ? (double)timerUpdate.Interval / 60000 : 0;// Reset if the If not ready . 

            if (ReadyTime >= method.StabilityTime)
            {
                SystemStable = true;
            }
            else
            {

                if (bStart.Text == "Stop")
                {
                    if (tReady)
                    {
                        if (Dp.Current < ThreaSholdCurrent) glSample.Text = "System Ready => Please Switch On the Sample";
                        else glSample.Text = "Waiting for Stability time left " + Math.Round((method.StabilityTime - ReadyTime), 1).ToString() +
                                "min";
                    }
                    else glSample.Text = " System Not Ready";
                }
                else
                {
                    if (!StoppedDueToerror) glSample.Text = "Waiting for Start";
                }
            }

            double cc = Dp.ComputeCoolingCapacity();
            if (!Double.IsNaN(cc))
            {
                CoolCapFilter.Add(cc);
                Dp.CoolCapSSD = CoolCapSSD.Add(cc);
                pvCoolingCapacity.Value = CoolCapFilter.Average();
                Dp.CoolingCapacityAverage = CoolCapSSD.Average();
                Dp.CoolingCapacityMedian = CoolCapSSD.Median();
                Dp.CoolingCapacity = CoolCapSSD.Median();
                TextBoxSample.Clear();
                if (CoolCapSSD.IsBufferFull)
                {

                    TextBoxSample.Text = "CoolCapacity SSD = " + Dp.CoolCapSSD.ToString("000.00" + "\n\r average =") + Dp.CoolingCapacityAverage.ToString("00000")+"\n\r Median=" + Dp.CoolingCapacityMedian.ToString("00000");
                    if (Math.Abs(Dp.CoolCapSSD) <  Program.Chamber.ActiveMethod.SSD)
                    {
                        TextBoxSample.Text += " Sample is Ready";
                        pvCoolingCapacity.ForeColor = Color.Black;
                        CoolingCapacityReady = true; 
                    }

                    else
                    {
                        TextBoxSample.Text += " Sample is Not Ready";
                        pvCoolingCapacity.ForeColor = Color.Red;
                        CoolingCapacityReady = false;
                    }
                }
                else
                {
                    TextBoxSample.Text = "Cooling Capacity is not ready " + CoolCapSSD.Count.ToString();
                    pvCoolingCapacity.ForeColor = Color.Red;
                    CoolingCapacityReady = false;
                }
            }
            else
            {
                CoolCapSSD.Clear();
            }
            //  pvCoolingCapacity.Value = Dp.CoolingCapacity;

            pvAirFlow.Value = Dp.AirFlowRate;
            pv4.Value = Dp.PowerFactor;
            pv9.Value = Dp.Voltage;
            pv12.Value = Dp.Current;
            pv11.Value = Dp.Power;
            this.Text = "ACTU [" + Program.Chamber.Sample.FileName + "]";
            HdCheck();

        }



        private void frmMainDisp_Resize(object sender, EventArgs e)
        {
            var w = Screen.PrimaryScreen.Bounds.Width;// CreateGraphics().DpiX;
            var h = Screen.PrimaryScreen.Bounds.Height;//CreateGraphics().DpiY;
            int segWidth = 2;
            displayStringStatus.Value = this.Width + "," + this.Height + "---->" + w.ToString() + "," + h.ToString();
            if (this.Height < 760)
            {
                tableLayoutPanel4.RowStyles[4].Height = 0;
                //this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                tableLayoutPanel4.RowStyles[4].Height = tableLayoutPanel4.RowStyles[3].Height;
                //this.FormBorderStyle = FormBorderStyle.Sizable;
            }

            if (this.Width <= 1024)
            {
                tableLayoutPanel4.ColumnStyles[2].SizeType = SizeType.Absolute;

                tableLayoutPanel4.ColumnStyles[2].Width = 0;
                segWidth = 1;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Dock = DockStyle.Fill;

            }
            else
            {
                tableLayoutPanel4.ColumnStyles[2].SizeType = SizeType.Percent;

                tableLayoutPanel4.ColumnStyles[2].Width = tableLayoutPanel4.ColumnStyles[1].Width;
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
            }
            foreach (EazyLab.Instrumentation.WF40.Combined.PV s in EazyLab.Instrumentation.WF40.Combined.PV.GetAll(this)) //Get All The PV objects 
            {

                if (this.Width <= 1024) segWidth = 0;
                if (this.Width > 1024) segWidth = 2 + (int)(this.Width / 1024);
                s.SevenSegment.Segment.Size = segWidth; // change the size of the Segment to  Defualt
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void glSample_Click(object sender, EventArgs e)
        {
            ReadyTime -= 5;
        }

        private void pv6_Load(object sender, EventArgs e)
        {
            //Program.Chamber.CodeTester.NozzlePressAnCh.Offset +=
            //    Program.Chamber.CodeTester.NozzlePressAnCh.CalibFilteredValue;
        }


        override public void UpdateTitleBar()
        {
            this.Text = "ACTU [" + Program.Chamber.Sample.FileName + "]";
        }

        private void NetResize1_BeforeControlResize(object sender, Softgroup.NetResize.BeforeControlResizeEventArgs e)
        {
            Softgroup.NetResize.License.LicenseName = "Ahmed";
            Softgroup.NetResize.License.LicenseUser = "ahmed.shaaban@beta-elec.com";
            Softgroup.NetResize.License.LicenseKey = "MLAF3FRJXADPRBBRKBJI3DMUJ";
        }

        private void ButtonResetStbTime_Click(object sender, EventArgs e)
        {
            ReadyTime = 0;
        }

        private void ButtonAdd5Min_Click(object sender, EventArgs e)
        {
            ReadyTime -= 5;
        }

        private void CbAutoReset_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbAutoReset.Checked)
            //{
            //    MessageBox.Show("Error => This feature has been not emplemented yet");
            //    cbAutoReset.Checked = false;
            //    //buttonAdd5Min.Enabled = false;
            //    //buttonResetStbTime.Enabled = false;
            //}
            //else
            //{
            //    buttonAdd5Min.Enabled = true;
            //    buttonResetStbTime.Enabled = true;
            //}


        }



        public override void MaxmizePlot()
        {
            frmDataPlot frm = new frmDataPlot();
            Hide();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            Show();

            //if (tableLayoutPanel1.Dock != DockStyle.Fill)
            //{
            //    tableLayoutPanel4.Hide();
            //    tableLayoutPanel1.Dock = DockStyle.Fill;


            //}
            //else
            //{
            //    tableLayoutPanel1.Dock = DockStyle.Top;
            //    tableLayoutPanel4.Show();
            //}

        }



        private void HdCheck()
        {

            try
            {
                var errInDoor = Chamber.InDoorAhu.Check();
                if (Program.Server.DaqTasks.Find(T => T.Name == "InDoorAnalogRead").Result.Exception != null) errInDoor.Insert(0, AHU.ErrorCode.DataAcquisiton);
                var errOutDoor = Chamber.OutDoorAhu.Check();
                if (Program.Server.DaqTasks.Find(T => T.Name == "OutDoorAnalogRead").Result.Exception != null) errOutDoor.Insert(0, AHU.ErrorCode.DataAcquisiton);
                var errSample = Chamber.CodeTester.Check();
                if (Program.Server.DaqTasks.Find(T => T.Name == "CodeTesterAnalogRead").Result.Exception != null) errSample.Insert(0, EazyLab.CodeTester.ErrorCode.DataAcquisiton);


                textBoxInDoor.Clear();
                textBoxOutDoor.Clear();
                //TextBoxSample.Clear();
                textBoxInDoor.Text = "InDoor Air Handling is " + Program.Chamber.InDoorAhu.RunTask1?.Status.ToString() + "\r\n";
                if (errInDoor.Count == 0) textBoxInDoor.Text += "No Error";
                else foreach (var err in errInDoor)
                    {
                        if (err == AHU.ErrorCode.CompressorWaterFlowLow)
                        {
                            if (Chamber.IsStared())
                            {
                                Stop();
                                StoppedDueToerror = true;
                                glSample.Text = "System Stopped=> InDoor Water low";

                            }
                        }
                        textBoxInDoor.Text = textBoxInDoor.Text + err.ToString() + "\r\n";
                    }
                textBoxOutDoor.Text = "OutDoor Air Handling is " + Program.Chamber.OutDoorAhu.RunTask1?.Status.ToString() + "\r\n";
                if (errOutDoor.Count == 0) textBoxOutDoor.Text += "No Error";
                foreach (var err in errOutDoor)
                {
                    if (err == AHU.ErrorCode.CompressorWaterFlowLow)
                    {
                        if (Chamber.IsStared())
                        {
                            Stop();
                            StoppedDueToerror = true;
                            glSample.Text = "System Stopped=>OutDoor Water low";
                        }
                    }
                    textBoxOutDoor.Text = textBoxOutDoor.Text + err.ToString() + "\r\n";
                }

                //if (errSample.Count == 0) TextBoxSample.Text += "No Error";
                //else foreach (var err in errSample)
                //    {

                //        TextBoxSample.Text = TextBoxSample.Text + err.ToString() + "\r\n";
                //    }
            }
            catch (Exception ex)
            {
                EazyLab.LoggerFile.WriteException(ex);

            }



        }

        private void buttonPowerCT_Click(object sender, EventArgs e)
        {
            Chamber.CodeTester.PowerOn = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            Program.Chamber.Sample.AddDp(Dp);

        }
    }
}
