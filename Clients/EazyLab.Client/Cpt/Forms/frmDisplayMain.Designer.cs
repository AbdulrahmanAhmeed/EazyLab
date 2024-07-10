namespace Client.Forms
{
    partial class frmDisplayMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EzData.Model.AnChannel anChannel9 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel10 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel11 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel12 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel1 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel2 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel3 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel4 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel5 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel6 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel7 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel8 = new EzData.Model.AnChannel();
            this.panelInDoor = new EazyLab.Instrumentation.Professional.Panel();
            this.pv2 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv4 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv5 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv3 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.panelOutDoor = new EazyLab.Instrumentation.Professional.Panel();
            this.pv1 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv7 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv8 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.panel2 = new EazyLab.Instrumentation.Professional.Panel();
            this.pv15 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv9 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv14 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv13 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv11 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv12 = new EazyLab.Instrumentation.WF40.Combined.PV();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelInDoor.SuspendLayout();
            this.panelOutDoor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelOutDoor);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panelInDoor);
            this.splitContainer1.Size = new System.Drawing.Size(1021, 766);
            this.splitContainer1.SplitterDistance = 268;
            // 
            // panelInDoor
            // 
            this.panelInDoor.LoadingBegin();
            this.panelInDoor.Controls.Add(this.pv2);
            this.panelInDoor.Controls.Add(this.pv4);
            this.panelInDoor.Controls.Add(this.pv5);
            this.panelInDoor.Controls.Add(this.pv3);
            this.panelInDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInDoor.Location = new System.Drawing.Point(12, 12);
            this.panelInDoor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInDoor.Name = "panelInDoor";
            this.panelInDoor.Size = new System.Drawing.Size(251, 400);
            this.panelInDoor.Title.Text = "In Door";
            this.panelInDoor.Title.TextLayout.Alignment.Style = System.Drawing.StringAlignment.Center;
            this.panelInDoor.LoadingEnd();
            // 
            // pv2
            // 
            anChannel9.Address = 0;
            anChannel9.CalibratedValue = 0D;
            anChannel9.Calibration = null;
            anChannel9.CalibrationId = null;
            anChannel9.DaqTask = null;
            anChannel9.DaqTaskId = null;
            anChannel9.Description = null;
            anChannel9.FilterType = EzData.Filter.FilterType.Average;
            anChannel9.HighPriority = false;
            anChannel9.Id = 0;
            anChannel9.Name = null;
            anChannel9.Offset = 0D;
            anChannel9.Pids = null;
            anChannel9.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel9.Unit = null;
            anChannel9.UnitId = null;
            anChannel9.Value = 0D;
            anChannel9.WindowSize = 10;
            this.pv2.AnCh = anChannel9;
            this.pv2.AnChName = "InDoorAnalogRead:0";
            this.pv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv2.Location = new System.Drawing.Point(27, 39);
            this.pv2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pv2.Max = 1D;
            this.pv2.Min = 0D;
            this.pv2.Name = "pv2";
            this.pv2.Plot = this.combinedPlot1;
            this.pv2.PlotTraceName = "InDoor DBT";
            this.pv2.Size = new System.Drawing.Size(200, 100);
            this.pv2.TabIndex = 0;
            this.pv2.Tag = "DBTemp(oC)";
            // 
            // pv4
            // 
            anChannel10.Address = 0;
            anChannel10.CalibratedValue = 0D;
            anChannel10.Calibration = null;
            anChannel10.CalibrationId = null;
            anChannel10.DaqTask = null;
            anChannel10.DaqTaskId = null;
            anChannel10.Description = null;
            anChannel10.FilterType = EzData.Filter.FilterType.Average;
            anChannel10.HighPriority = false;
            anChannel10.Id = 0;
            anChannel10.Name = null;
            anChannel10.Offset = 0D;
            anChannel10.Pids = null;
            anChannel10.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel10.Unit = null;
            anChannel10.UnitId = null;
            anChannel10.Value = 0D;
            anChannel10.WindowSize = 10;
            this.pv4.AnCh = anChannel10;
            this.pv4.AnChName = "";
            this.pv4.Location = new System.Drawing.Point(475, 238);
            this.pv4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pv4.Max = 1D;
            this.pv4.Min = 0D;
            this.pv4.Name = "pv4";
            this.pv4.Size = new System.Drawing.Size(159, 94);
            this.pv4.TabIndex = 0;
            this.pv4.Tag = "Process Variable";
            // 
            // pv5
            // 
            anChannel11.Address = 0;
            anChannel11.CalibratedValue = 0D;
            anChannel11.Calibration = null;
            anChannel11.CalibrationId = null;
            anChannel11.DaqTask = null;
            anChannel11.DaqTaskId = null;
            anChannel11.Description = null;
            anChannel11.FilterType = EzData.Filter.FilterType.Average;
            anChannel11.HighPriority = false;
            anChannel11.Id = 0;
            anChannel11.Name = null;
            anChannel11.Offset = 0D;
            anChannel11.Pids = null;
            anChannel11.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel11.Unit = null;
            anChannel11.UnitId = null;
            anChannel11.Value = 0D;
            anChannel11.WindowSize = 10;
            this.pv5.AnCh = anChannel11;
            this.pv5.AnChName = "InDoorHygroclip:0";
            this.pv5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv5.Location = new System.Drawing.Point(27, 276);
            this.pv5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pv5.Max = 1D;
            this.pv5.Min = 0D;
            this.pv5.Name = "pv5";
            this.pv5.Plot = this.combinedPlot1;
            this.pv5.PlotTraceName = "INDoor Hum";
            this.pv5.Size = new System.Drawing.Size(200, 100);
            this.pv5.TabIndex = 0;
            this.pv5.Tag = "Humidity(%)";
            this.pv5.Load += new System.EventHandler(this.pv3_Load);
            // 
            // pv3
            // 
            anChannel12.Address = 0;
            anChannel12.CalibratedValue = 0D;
            anChannel12.Calibration = null;
            anChannel12.CalibrationId = null;
            anChannel12.DaqTask = null;
            anChannel12.DaqTaskId = null;
            anChannel12.Description = null;
            anChannel12.FilterType = EzData.Filter.FilterType.Average;
            anChannel12.HighPriority = false;
            anChannel12.Id = 0;
            anChannel12.Name = null;
            anChannel12.Offset = 0D;
            anChannel12.Pids = null;
            anChannel12.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel12.Unit = null;
            anChannel12.UnitId = null;
            anChannel12.Value = 0D;
            anChannel12.WindowSize = 10;
            this.pv3.AnCh = anChannel12;
            this.pv3.AnChName = "InDoorAnalogRead:1";
            this.pv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv3.Location = new System.Drawing.Point(27, 164);
            this.pv3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pv3.Max = 1D;
            this.pv3.Min = 0D;
            this.pv3.Name = "pv3";
            this.pv3.Plot = this.combinedPlot1;
            this.pv3.PlotTraceName = "InDoor WBT";
            this.pv3.Size = new System.Drawing.Size(200, 100);
            this.pv3.TabIndex = 0;
            this.pv3.Tag = "WBTemp(oC)";
            this.pv3.Load += new System.EventHandler(this.pv3_Load);
            // 
            // panelOutDoor
            // 
            this.panelOutDoor.LoadingBegin();
            this.panelOutDoor.Controls.Add(this.pv1);
            this.panelOutDoor.Controls.Add(this.pv7);
            this.panelOutDoor.Controls.Add(this.pv8);
            this.panelOutDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOutDoor.Location = new System.Drawing.Point(766, 12);
            this.panelOutDoor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOutDoor.Name = "panelOutDoor";
            this.panelOutDoor.Size = new System.Drawing.Size(243, 400);
            this.panelOutDoor.Title.Text = "Out Door";
            this.panelOutDoor.Title.TextLayout.Alignment.Style = System.Drawing.StringAlignment.Center;
            this.panelOutDoor.LoadingEnd();
            // 
            // pv1
            // 
            this.pv1.AnCh = null;
            this.pv1.AnChName = "OutDoorAnalogRead:0";
            this.pv1.Location = new System.Drawing.Point(19, 39);
            this.pv1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pv1.Max = 1D;
            this.pv1.Min = 0D;
            this.pv1.Name = "pv1";
            this.pv1.Plot = this.combinedPlot1;
            this.pv1.PlotTraceName = "OutDoor DBT";
            this.pv1.Size = new System.Drawing.Size(200, 101);
            this.pv1.TabIndex = 0;
            this.pv1.Tag = "DBTemp(oC)";
            // 
            // pv7
            // 
            anChannel1.Address = 0;
            anChannel1.CalibratedValue = 0D;
            anChannel1.Calibration = null;
            anChannel1.CalibrationId = null;
            anChannel1.DaqTask = null;
            anChannel1.DaqTaskId = null;
            anChannel1.Description = null;
            anChannel1.FilterType = EzData.Filter.FilterType.Average;
            anChannel1.HighPriority = false;
            anChannel1.Id = 0;
            anChannel1.Name = null;
            anChannel1.Offset = 0D;
            anChannel1.Pids = null;
            anChannel1.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel1.Unit = null;
            anChannel1.UnitId = null;
            anChannel1.Value = 0D;
            anChannel1.WindowSize = 10;
            this.pv7.AnCh = anChannel1;
            this.pv7.AnChName = "OutDoorHygroclip:0";
            this.pv7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv7.Location = new System.Drawing.Point(19, 276);
            this.pv7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pv7.Max = 1D;
            this.pv7.Min = 0D;
            this.pv7.Name = "pv7";
            this.pv7.Plot = this.combinedPlot1;
            this.pv7.PlotTraceName = "OutDoor Hum";
            this.pv7.Size = new System.Drawing.Size(200, 100);
            this.pv7.TabIndex = 0;
            this.pv7.Tag = "Humidity(%)";
            this.pv7.Load += new System.EventHandler(this.pv3_Load);
            // 
            // pv8
            // 
            anChannel2.Address = 0;
            anChannel2.CalibratedValue = 0D;
            anChannel2.Calibration = null;
            anChannel2.CalibrationId = null;
            anChannel2.DaqTask = null;
            anChannel2.DaqTaskId = null;
            anChannel2.Description = null;
            anChannel2.FilterType = EzData.Filter.FilterType.Average;
            anChannel2.HighPriority = false;
            anChannel2.Id = 0;
            anChannel2.Name = null;
            anChannel2.Offset = 0D;
            anChannel2.Pids = null;
            anChannel2.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel2.Unit = null;
            anChannel2.UnitId = null;
            anChannel2.Value = 0D;
            anChannel2.WindowSize = 10;
            this.pv8.AnCh = anChannel2;
            this.pv8.AnChName = "OutDoorAnalogRead:1";
            this.pv8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv8.Location = new System.Drawing.Point(19, 164);
            this.pv8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pv8.Max = 1D;
            this.pv8.Min = 0D;
            this.pv8.Name = "pv8";
            this.pv8.Plot = this.combinedPlot1;
            this.pv8.PlotTraceName = "OutDoor WBT";
            this.pv8.Size = new System.Drawing.Size(200, 100);
            this.pv8.TabIndex = 0;
            this.pv8.Tag = "WBTemp(oC)";
            this.pv8.Load += new System.EventHandler(this.pv3_Load);
            // 
            // panel2
            // 
            this.panel2.LoadingBegin();
            this.panel2.Controls.Add(this.pv15);
            this.panel2.Controls.Add(this.pv9);
            this.panel2.Controls.Add(this.pv14);
            this.panel2.Controls.Add(this.pv13);
            this.panel2.Controls.Add(this.pv11);
            this.panel2.Controls.Add(this.pv12);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(275, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 400);
            this.panel2.Title.Text = "Sample";
            this.panel2.Title.TextLayout.Alignment.Style = System.Drawing.StringAlignment.Center;
            this.panel2.LoadingEnd();
            // 
            // pv15
            // 
            anChannel3.Address = 0;
            anChannel3.CalibratedValue = 0D;
            anChannel3.Calibration = null;
            anChannel3.CalibrationId = null;
            anChannel3.DaqTask = null;
            anChannel3.DaqTaskId = null;
            anChannel3.Description = null;
            anChannel3.FilterType = EzData.Filter.FilterType.Average;
            anChannel3.HighPriority = false;
            anChannel3.Id = 0;
            anChannel3.Name = null;
            anChannel3.Offset = 0D;
            anChannel3.Pids = null;
            anChannel3.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel3.Unit = null;
            anChannel3.UnitId = null;
            anChannel3.Value = 0D;
            anChannel3.WindowSize = 10;
            this.pv15.AnCh = anChannel3;
            this.pv15.AnChName = "CodeTesterAnalogRead:0";
            this.pv15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv15.Location = new System.Drawing.Point(260, 39);
            this.pv15.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pv15.Max = 1D;
            this.pv15.Min = 0D;
            this.pv15.Name = "pv15";
            this.pv15.PlotTraceName = "Sample DBT";
            this.pv15.Size = new System.Drawing.Size(200, 100);
            this.pv15.TabIndex = 0;
            this.pv15.Tag = "DBTemp(oC)";
            this.pv15.Load += new System.EventHandler(this.pv2_Load);
            // 
            // pv9
            // 
            anChannel4.Address = 0;
            anChannel4.CalibratedValue = 0D;
            anChannel4.Calibration = null;
            anChannel4.CalibrationId = null;
            anChannel4.DaqTask = null;
            anChannel4.DaqTaskId = null;
            anChannel4.Description = null;
            anChannel4.FilterType = EzData.Filter.FilterType.Average;
            anChannel4.HighPriority = false;
            anChannel4.Id = 0;
            anChannel4.Name = null;
            anChannel4.Offset = 0D;
            anChannel4.Pids = null;
            anChannel4.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel4.Unit = null;
            anChannel4.UnitId = null;
            anChannel4.Value = 0D;
            anChannel4.WindowSize = 10;
            this.pv9.AnCh = anChannel4;
            this.pv9.AnChName = "1PhPowerlogicVolt:0";
            this.pv9.DecimalPos = 0;
            this.pv9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv9.Location = new System.Drawing.Point(27, 39);
            this.pv9.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pv9.Max = 1D;
            this.pv9.Min = 0D;
            this.pv9.Name = "pv9";
            this.pv9.Plot = this.combinedPlot1;
            this.pv9.PlotTraceName = "Voltage";
            this.pv9.Size = new System.Drawing.Size(200, 100);
            this.pv9.TabIndex = 0;
            this.pv9.Tag = "Voltage";
            this.pv9.Load += new System.EventHandler(this.pv2_Load);
            // 
            // pv14
            // 
            anChannel5.Address = 0;
            anChannel5.CalibratedValue = 0D;
            anChannel5.Calibration = null;
            anChannel5.CalibrationId = null;
            anChannel5.DaqTask = null;
            anChannel5.DaqTaskId = null;
            anChannel5.Description = null;
            anChannel5.FilterType = EzData.Filter.FilterType.Average;
            anChannel5.HighPriority = false;
            anChannel5.Id = 0;
            anChannel5.Name = null;
            anChannel5.Offset = 0D;
            anChannel5.Pids = null;
            anChannel5.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel5.Unit = null;
            anChannel5.UnitId = null;
            anChannel5.Value = 0D;
            anChannel5.WindowSize = 10;
            this.pv14.AnCh = anChannel5;
            this.pv14.AnChName = "CodeTesterAnalogRead:3";
            this.pv14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv14.Location = new System.Drawing.Point(260, 276);
            this.pv14.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pv14.Max = 1D;
            this.pv14.Min = 0D;
            this.pv14.Name = "pv14";
            this.pv14.Plot = this.combinedPlot1;
            this.pv14.PlotTraceName = "Flow Rate";
            this.pv14.Size = new System.Drawing.Size(200, 100);
            this.pv14.TabIndex = 0;
            this.pv14.Tag = "Static Press(Pa)";
            this.pv14.Load += new System.EventHandler(this.pv3_Load);
            // 
            // pv13
            // 
            anChannel6.Address = 0;
            anChannel6.CalibratedValue = 0D;
            anChannel6.Calibration = null;
            anChannel6.CalibrationId = null;
            anChannel6.DaqTask = null;
            anChannel6.DaqTaskId = null;
            anChannel6.Description = null;
            anChannel6.FilterType = EzData.Filter.FilterType.Average;
            anChannel6.HighPriority = false;
            anChannel6.Id = 0;
            anChannel6.Name = null;
            anChannel6.Offset = 0D;
            anChannel6.Pids = null;
            anChannel6.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel6.Unit = null;
            anChannel6.UnitId = null;
            anChannel6.Value = 0D;
            anChannel6.WindowSize = 10;
            this.pv13.AnCh = anChannel6;
            this.pv13.AnChName = "CodeTesterAnalogRead:1";
            this.pv13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv13.Location = new System.Drawing.Point(260, 164);
            this.pv13.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pv13.Max = 1D;
            this.pv13.Min = 0D;
            this.pv13.Name = "pv13";
            this.pv13.Plot = this.combinedPlot1;
            this.pv13.PlotTraceName = "Sample WBT";
            this.pv13.Size = new System.Drawing.Size(200, 100);
            this.pv13.TabIndex = 0;
            this.pv13.Tag = "WBTemp(oC)";
            this.pv13.Load += new System.EventHandler(this.pv3_Load);
            // 
            // pv11
            // 
            anChannel7.Address = 0;
            anChannel7.CalibratedValue = 0D;
            anChannel7.Calibration = null;
            anChannel7.CalibrationId = null;
            anChannel7.DaqTask = null;
            anChannel7.DaqTaskId = null;
            anChannel7.Description = null;
            anChannel7.FilterType = EzData.Filter.FilterType.Average;
            anChannel7.HighPriority = false;
            anChannel7.Id = 0;
            anChannel7.Name = null;
            anChannel7.Offset = 0D;
            anChannel7.Pids = null;
            anChannel7.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel7.Unit = null;
            anChannel7.UnitId = null;
            anChannel7.Value = 0D;
            anChannel7.WindowSize = 10;
            this.pv11.AnCh = anChannel7;
            this.pv11.AnChName = "1PhPowerlogicPower:0";
            this.pv11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv11.Location = new System.Drawing.Point(27, 276);
            this.pv11.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pv11.Max = 1D;
            this.pv11.Min = 0D;
            this.pv11.Name = "pv11";
            this.pv11.Plot = this.combinedPlot1;
            this.pv11.PlotTraceName = "Power";
            this.pv11.Size = new System.Drawing.Size(200, 100);
            this.pv11.TabIndex = 0;
            this.pv11.Tag = "Power";
            this.pv11.Load += new System.EventHandler(this.pv3_Load);
            // 
            // pv12
            // 
            anChannel8.Address = 0;
            anChannel8.CalibratedValue = 0D;
            anChannel8.Calibration = null;
            anChannel8.CalibrationId = null;
            anChannel8.DaqTask = null;
            anChannel8.DaqTaskId = null;
            anChannel8.Description = null;
            anChannel8.FilterType = EzData.Filter.FilterType.Average;
            anChannel8.HighPriority = false;
            anChannel8.Id = 0;
            anChannel8.Name = null;
            anChannel8.Offset = 0D;
            anChannel8.Pids = null;
            anChannel8.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel8.Unit = null;
            anChannel8.UnitId = null;
            anChannel8.Value = 0D;
            anChannel8.WindowSize = 10;
            this.pv12.AnCh = anChannel8;
            this.pv12.AnChName = "1PhPowerlogicCurrent:0";
            this.pv12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv12.Location = new System.Drawing.Point(27, 164);
            this.pv12.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pv12.Max = 1D;
            this.pv12.Min = 0D;
            this.pv12.Name = "pv12";
            this.pv12.Plot = this.combinedPlot1;
            this.pv12.PlotTraceName = "Current";
            this.pv12.Size = new System.Drawing.Size(200, 100);
            this.pv12.TabIndex = 0;
            this.pv12.Tag = "Current";
            this.pv12.Load += new System.EventHandler(this.pv3_Load);
            // 
            // frmDisplayMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 766);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDisplayMain";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelInDoor.ResumeLayout(false);
            this.panelOutDoor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private EazyLab.Instrumentation.WF40.Combined.PV pv3;
        private EazyLab.Instrumentation.WF40.Combined.PV pv2;
        private EazyLab.Instrumentation.Professional.Panel panelInDoor;
        private EazyLab.Instrumentation.WF40.Combined.PV pv4;
        private EazyLab.Instrumentation.WF40.Combined.PV pv5;
        private EazyLab.Instrumentation.Professional.Panel panelOutDoor;
        private EazyLab.Instrumentation.WF40.Combined.PV pv1;
       // private EazyLab.Instrumentation.WF40.Combined.PV pv6;
        private EazyLab.Instrumentation.WF40.Combined.PV pv7;
        private EazyLab.Instrumentation.WF40.Combined.PV pv8;
        private EazyLab.Instrumentation.Professional.Panel panel2;
        private EazyLab.Instrumentation.WF40.Combined.PV pv15;
        private EazyLab.Instrumentation.WF40.Combined.PV pv9;
        private EazyLab.Instrumentation.WF40.Combined.PV pv14;
        private EazyLab.Instrumentation.WF40.Combined.PV pv13;
        private EazyLab.Instrumentation.WF40.Combined.PV pv11;
        private EazyLab.Instrumentation.WF40.Combined.PV pv12;
       // private EazyLab.Instrumentation.WF40.Combined.UpdateTimer Timer;
    }
}