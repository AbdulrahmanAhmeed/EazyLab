namespace Client.Forms
{
    partial class frmHardwareCodeTester
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
            this.components = new System.ComponentModel.Container();
            EzData.Model.PID pid1 = new EzData.Model.PID();
            EzData.Model.AnChannel anChannel6 = new EzData.Model.AnChannel();
            EzData.Model.DigChannel digChannel1 = new EzData.Model.DigChannel();
            EzData.Model.AnChannel anChannel1 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel2 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel3 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel4 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel5 = new EzData.Model.AnChannel();
            this.netResize1 = new Softgroup.NetResize.NetResize(this.components);
            this.pidLoop1 = new EazyLab.Instrumentation.Combined.PIDLoop();
            this.pv5 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.DOPower = new EazyLab.Instrumentation.Combined.DigOut();
            this.ledArrow11 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.nudBlower = new System.Windows.Forms.NumericUpDown();
            this.cbBlower = new System.Windows.Forms.CheckBox();
            this.ledArrow7 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.cbNozzle3 = new System.Windows.Forms.CheckBox();
            this.cbNozzle1 = new System.Windows.Forms.CheckBox();
            this.cbNozzle2 = new System.Windows.Forms.CheckBox();
            this.ledArrow4 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonCalibrateFlow = new System.Windows.Forms.Button();
            this.label4 = new EazyLab.Instrumentation.Standard.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pv2 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv8 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv3 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv1 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv6 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.ledArrow6 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.ledArrow8 = new EazyLab.Instrumentation.Professional.LedArrow();
            ((System.ComponentModel.ISupportInitialize)(this.netResize1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // netResize1
            // 
            this.netResize1.ParentControl = this;
            // 
            // pidLoop1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.pidLoop1, 5);
            this.pidLoop1.DGain = 0D;
            this.pidLoop1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pidLoop1.IGain = 0D;
            this.pidLoop1.Lable = "PIDLoop";
            this.pidLoop1.Location = new System.Drawing.Point(2, 212);
            this.pidLoop1.Margin = new System.Windows.Forms.Padding(2);
            this.pidLoop1.Name = "pidLoop1";
            this.pidLoop1.PGain = 0D;
            pid1.AnChIn = null;
            pid1.AnChInId = null;
            pid1.AnCoolOut = null;
            pid1.AnCoolOutId = null;
            pid1.AnHeatOut = null;
            pid1.AnHeatOutId = null;
            pid1.ATuneBuffer = null;
            pid1.Description = null;
            pid1.DGain = 0D;
            pid1.DigCoolOut = null;
            pid1.DigCoolOutId = null;
            pid1.DigHeatOut = null;
            pid1.DigHeatOutId = null;
            pid1.Enable = false;
            pid1.ErrorThreshold = 0D;
            pid1.Id = 0;
            pid1.IGain = 0D;
            pid1.Mode = EzData.Model.PID.PidMode.Position;
            pid1.Name = null;
            pid1.NGain = 0D;
            pid1.OutMax = 0D;
            pid1.OutMin = 0D;
            pid1.OutMode = EzData.Model.PID.PidOutMode.Heating;
            pid1.PGain = 0D;
            pid1.PowerAction = null;
            pid1.PVMax = 0D;
            pid1.PVMin = 0D;
            pid1.RateClamp = 1D;
            pid1.ScanningTime = 0;
            pid1.SetPoint = 0D;
            pid1.StartTime = new System.DateTime(((long)(0)));
            pid1.SteadyState = 0D;
            pid1.SteadyStateDetector = null;
            pid1.TuneCurrentCycle = 0;
            this.pidLoop1.PID = pid1;
            this.pidLoop1.ScanningTime = 0;
            this.pidLoop1.SetPoint = 0D;
            this.pidLoop1.Size = new System.Drawing.Size(532, 116);
            this.pidLoop1.TabIndex = 22;
            // 
            // pv5
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
            this.pv5.AnCh = anChannel6;
            this.pv5.AnChName = "";
            this.pv5.BackColor = System.Drawing.Color.Transparent;
            this.pv5.DecimalPos = 0;
            this.pv5.DigCount = 5;
            this.pv5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv5.Location = new System.Drawing.Point(578, 102);
            this.pv5.Margin = new System.Windows.Forms.Padding(2);
            this.pv5.Max = 1D;
            this.pv5.Min = 0D;
            this.pv5.Name = "pv5";
            this.pv5.PlotTraceName = "AirFlow";
            this.tableLayoutPanel3.SetRowSpan(this.pv5, 3);
            this.pv5.Size = new System.Drawing.Size(148, 86);
            this.pv5.TabIndex = 4;
            this.pv5.Tag = "Air Flow";
            this.pv5.Value = 0D;
            // 
            // DOPower
            // 
            digChannel1.Address = 0;
            digChannel1.DaqTask = null;
            digChannel1.DaqTaskId = null;
            digChannel1.Description = null;
            digChannel1.HighPriority = false;
            digChannel1.Id = 0;
            digChannel1.Name = null;
            digChannel1.Pids = null;
            digChannel1.Type = EzData.Model.DigChannel.DigChTypes.In;
            digChannel1.Value = false;
            this.DOPower.AnCh = digChannel1;
            this.DOPower.AutoSize = true;
            this.DOPower.DigChName = "";
            this.DOPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DOPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOPower.Location = new System.Drawing.Point(3, 133);
            this.DOPower.Name = "DOPower";
            this.DOPower.Size = new System.Drawing.Size(146, 24);
            this.DOPower.TabIndex = 23;
            this.DOPower.Text = "Power";
            this.DOPower.UseVisualStyleBackColor = true;
            this.DOPower.CheckedChanged += new System.EventHandler(this.DOPower_CheckedChanged);
            // 
            // ledArrow11
            // 
            this.ledArrow11.LoadingBegin();
            this.ledArrow11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledArrow11.Indicator.BodyLength = 10;
            this.ledArrow11.Indicator.HeadSize = 26;
            this.ledArrow11.Location = new System.Drawing.Point(154, 132);
            this.ledArrow11.Margin = new System.Windows.Forms.Padding(2);
            this.ledArrow11.Name = "ledArrow11";
            this.ledArrow11.Size = new System.Drawing.Size(36, 26);
            this.ledArrow11.LoadingEnd();
            // 
            // nudBlower
            // 
            this.nudBlower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBlower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBlower.Location = new System.Drawing.Point(194, 162);
            this.nudBlower.Margin = new System.Windows.Forms.Padding(2);
            this.nudBlower.Name = "nudBlower";
            this.nudBlower.Size = new System.Drawing.Size(148, 26);
            this.nudBlower.TabIndex = 27;
            this.nudBlower.ValueChanged += new System.EventHandler(this.nudBlower_ValueChanged);
            // 
            // cbBlower
            // 
            this.cbBlower.AutoSize = true;
            this.cbBlower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBlower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cbBlower.Location = new System.Drawing.Point(195, 103);
            this.cbBlower.Name = "cbBlower";
            this.cbBlower.Size = new System.Drawing.Size(146, 24);
            this.cbBlower.TabIndex = 26;
            this.cbBlower.Text = "Blower";
            this.cbBlower.UseVisualStyleBackColor = true;
            this.cbBlower.CheckedChanged += new System.EventHandler(this.cbBlower_CheckedChanged);
            // 
            // ledArrow7
            // 
            this.ledArrow7.LoadingBegin();
            this.ledArrow7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledArrow7.Indicator.BodyLength = 122;
            this.ledArrow7.Indicator.HeadSize = 26;
            this.ledArrow7.Location = new System.Drawing.Point(194, 132);
            this.ledArrow7.Margin = new System.Windows.Forms.Padding(2);
            this.ledArrow7.Name = "ledArrow7";
            this.ledArrow7.Size = new System.Drawing.Size(148, 26);
            this.ledArrow7.LoadingEnd();
            // 
            // cbNozzle3
            // 
            this.cbNozzle3.AutoSize = true;
            this.cbNozzle3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNozzle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNozzle3.Location = new System.Drawing.Point(387, 163);
            this.cbNozzle3.Name = "cbNozzle3";
            this.cbNozzle3.Size = new System.Drawing.Size(146, 24);
            this.cbNozzle3.TabIndex = 29;
            this.cbNozzle3.Text = "Nozzle3(3inch)";
            this.cbNozzle3.UseVisualStyleBackColor = true;
            this.cbNozzle3.CheckedChanged += new System.EventHandler(this.cbNozzle3_CheckedChanged);
            // 
            // cbNozzle1
            // 
            this.cbNozzle1.AutoSize = true;
            this.cbNozzle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNozzle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNozzle1.Location = new System.Drawing.Point(387, 103);
            this.cbNozzle1.Name = "cbNozzle1";
            this.cbNozzle1.Size = new System.Drawing.Size(146, 24);
            this.cbNozzle1.TabIndex = 29;
            this.cbNozzle1.Text = "Nozzle1(4inch)";
            this.cbNozzle1.UseVisualStyleBackColor = true;
            this.cbNozzle1.CheckedChanged += new System.EventHandler(this.cbNozzle1_CheckedChanged);
            // 
            // cbNozzle2
            // 
            this.cbNozzle2.AutoSize = true;
            this.cbNozzle2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNozzle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNozzle2.Location = new System.Drawing.Point(387, 133);
            this.cbNozzle2.Name = "cbNozzle2";
            this.cbNozzle2.Size = new System.Drawing.Size(146, 24);
            this.cbNozzle2.TabIndex = 29;
            this.cbNozzle2.Text = "Nozzle2(4inch)";
            this.cbNozzle2.UseVisualStyleBackColor = true;
            this.cbNozzle2.CheckedChanged += new System.EventHandler(this.cbNozzle2_CheckedChanged);
            // 
            // ledArrow4
            // 
            this.ledArrow4.LoadingBegin();
            this.ledArrow4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledArrow4.Indicator.BodyLength = 10;
            this.ledArrow4.Indicator.HeadSize = 26;
            this.ledArrow4.Location = new System.Drawing.Point(538, 132);
            this.ledArrow4.Margin = new System.Windows.Forms.Padding(2);
            this.ledArrow4.Name = "ledArrow4";
            this.ledArrow4.Size = new System.Drawing.Size(36, 26);
            this.ledArrow4.LoadingEnd();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(770, 132);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(148, 26);
            this.numericUpDown1.TabIndex = 27;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonCalibrateFlow
            // 
            this.buttonCalibrateFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCalibrateFlow.Location = new System.Drawing.Point(771, 163);
            this.buttonCalibrateFlow.Name = "buttonCalibrateFlow";
            this.buttonCalibrateFlow.Size = new System.Drawing.Size(146, 24);
            this.buttonCalibrateFlow.TabIndex = 33;
            this.buttonCalibrateFlow.Text = "Save";
            this.buttonCalibrateFlow.UseVisualStyleBackColor = true;
            this.buttonCalibrateFlow.Click += new System.EventHandler(this.buttonCalibrateFlow_Click);
            // 
            // label4
            // 
            this.label4.LoadingBegin();
            this.label4.AutoSize = false;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(771, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.Text = "Cfactor";
            this.label4.LoadingEnd();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 10;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33386F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33387F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33387F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33387F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.32987F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33467F));
            this.tableLayoutPanel3.Controls.Add(this.pv2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.pidLoop1, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.buttonCalibrateFlow, 8, 4);
            this.tableLayoutPanel3.Controls.Add(this.label4, 8, 2);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown1, 8, 3);
            this.tableLayoutPanel3.Controls.Add(this.pv8, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.pv3, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.ledArrow7, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.nudBlower, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.cbNozzle3, 4, 4);
            this.tableLayoutPanel3.Controls.Add(this.DOPower, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.ledArrow11, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbNozzle2, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.pv1, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbBlower, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbNozzle1, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.pv6, 8, 1);
            this.tableLayoutPanel3.Controls.Add(this.ledArrow6, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.ledArrow4, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this.pv5, 6, 2);
            this.tableLayoutPanel3.Controls.Add(this.ledArrow8, 7, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 225);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1305, 526);
            this.tableLayoutPanel3.TabIndex = 38;
            // 
            // pv2
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
            this.pv2.AnCh = anChannel1;
            this.pv2.AnChName = "";
            this.pv2.BackColor = System.Drawing.Color.Transparent;
            this.pv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv2.Location = new System.Drawing.Point(2, 22);
            this.pv2.Margin = new System.Windows.Forms.Padding(2);
            this.pv2.Max = 1D;
            this.pv2.Min = 0D;
            this.pv2.Name = "pv2";
            this.pv2.PlotTraceName = "DbTemp";
            this.pv2.Size = new System.Drawing.Size(148, 76);
            this.pv2.TabIndex = 4;
            this.pv2.Tag = "DBTemp";
            this.pv2.Value = 0D;
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
            this.pv8.AnChName = "";
            this.pv8.BackColor = System.Drawing.Color.Transparent;
            this.pv8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv8.Location = new System.Drawing.Point(194, 22);
            this.pv8.Margin = new System.Windows.Forms.Padding(2);
            this.pv8.Max = 1D;
            this.pv8.Min = 0D;
            this.pv8.Name = "pv8";
            this.pv8.PlotTraceName = "WBTemp";
            this.pv8.Size = new System.Drawing.Size(148, 76);
            this.pv8.TabIndex = 4;
            this.pv8.Tag = "WBTemp";
            this.pv8.Value = 0D;
            // 
            // pv3
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
            this.pv3.AnCh = anChannel3;
            this.pv3.AnChName = "";
            this.pv3.BackColor = System.Drawing.Color.Transparent;
            this.pv3.DecimalPos = 0;
            this.pv3.DigCount = 6;
            this.pv3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv3.Location = new System.Drawing.Point(386, 22);
            this.pv3.Margin = new System.Windows.Forms.Padding(2);
            this.pv3.Max = 1D;
            this.pv3.Min = 0D;
            this.pv3.Name = "pv3";
            this.pv3.PlotTraceName = "Barometeric Press(Pa)";
            this.pv3.Size = new System.Drawing.Size(148, 76);
            this.pv3.TabIndex = 5;
            this.pv3.Tag = "Atmos.Press";
            this.pv3.Value = 0D;
            // 
            // pv1
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
            this.pv1.AnCh = anChannel4;
            this.pv1.AnChName = "";
            this.pv1.BackColor = System.Drawing.Color.Transparent;
            this.pv1.DigCount = 4;
            this.pv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv1.Location = new System.Drawing.Point(578, 22);
            this.pv1.Margin = new System.Windows.Forms.Padding(2);
            this.pv1.Max = 1D;
            this.pv1.Min = 0D;
            this.pv1.Name = "pv1";
            this.pv1.PlotTraceName = "StaticPress";
            this.pv1.ShowSign = true;
            this.pv1.Size = new System.Drawing.Size(148, 76);
            this.pv1.TabIndex = 4;
            this.pv1.Tag = "Static.Press";
            this.pv1.Value = 0D;
            // 
            // pv6
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
            this.pv6.AnCh = anChannel5;
            this.pv6.AnChName = "";
            this.pv6.BackColor = System.Drawing.Color.Transparent;
            this.pv6.DigCount = 4;
            this.pv6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv6.Location = new System.Drawing.Point(770, 22);
            this.pv6.Margin = new System.Windows.Forms.Padding(2);
            this.pv6.Max = 1D;
            this.pv6.Min = 0D;
            this.pv6.Name = "pv6";
            this.pv6.PlotTraceName = "NozzleDeltaPres";
            this.pv6.ShowSign = true;
            this.pv6.Size = new System.Drawing.Size(148, 76);
            this.pv6.TabIndex = 4;
            this.pv6.Tag = "Nozzle.Delta.Press";
            this.pv6.Value = 0D;
            // 
            // ledArrow6
            // 
            this.ledArrow6.LoadingBegin();
            this.ledArrow6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledArrow6.Indicator.BodyLength = 10;
            this.ledArrow6.Indicator.HeadSize = 26;
            this.ledArrow6.Location = new System.Drawing.Point(346, 132);
            this.ledArrow6.Margin = new System.Windows.Forms.Padding(2);
            this.ledArrow6.Name = "ledArrow6";
            this.ledArrow6.Size = new System.Drawing.Size(36, 26);
            this.ledArrow6.LoadingEnd();
            // 
            // ledArrow8
            // 
            this.ledArrow8.LoadingBegin();
            this.ledArrow8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledArrow8.Indicator.BodyLength = 10;
            this.ledArrow8.Indicator.HeadSize = 26;
            this.ledArrow8.Location = new System.Drawing.Point(730, 132);
            this.ledArrow8.Margin = new System.Windows.Forms.Padding(2);
            this.ledArrow8.Name = "ledArrow8";
            this.ledArrow8.Size = new System.Drawing.Size(36, 26);
            this.ledArrow8.LoadingEnd();
            // 
            // frmHardwareCodeTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 788);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHardwareCodeTester";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHardwareChamber_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.netResize1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private EazyLab.Instrumentation.WF40.Combined.PV pv5;
        private Softgroup.NetResize.NetResize netResize1;
        private EazyLab.Instrumentation.Combined.PIDLoop pidLoop1;
        private EazyLab.Instrumentation.Combined.DigOut DOPower;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow11;
        private System.Windows.Forms.NumericUpDown nudBlower;
        private System.Windows.Forms.CheckBox cbBlower;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow7;
        private System.Windows.Forms.CheckBox cbNozzle2;
        private System.Windows.Forms.CheckBox cbNozzle1;
        private System.Windows.Forms.CheckBox cbNozzle3;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow4;
        private System.Windows.Forms.Button buttonCalibrateFlow;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private EazyLab.Instrumentation.Standard.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private EazyLab.Instrumentation.WF40.Combined.PV pv2;
        private EazyLab.Instrumentation.WF40.Combined.PV pv8;
        private EazyLab.Instrumentation.WF40.Combined.PV pv3;
        private EazyLab.Instrumentation.WF40.Combined.PV pv1;
        private EazyLab.Instrumentation.WF40.Combined.PV pv6;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow6;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow8;
    }
}