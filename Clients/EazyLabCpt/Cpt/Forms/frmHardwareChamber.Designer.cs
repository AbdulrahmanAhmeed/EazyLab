namespace Client.Forms
{
    partial class frmHardwareChamber
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
            EzData.Model.AnChannel anChannel1 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel2 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel3 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel4 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel5 = new EzData.Model.AnChannel();
            EzData.Model.PID pid3 = new EzData.Model.PID();
            EzData.Model.DigChannel digChannel1 = new EzData.Model.DigChannel();
            EzData.Model.DigChannel digChannel3 = new EzData.Model.DigChannel();
            EzData.Model.DigChannel digChannel2 = new EzData.Model.DigChannel();
            EzData.Model.DigChannel digChannel6 = new EzData.Model.DigChannel();
            EzData.Model.DigChannel digChannel4 = new EzData.Model.DigChannel();
            EzData.Model.DigChannel digChannel5 = new EzData.Model.DigChannel();
            EzData.Model.PID pid1 = new EzData.Model.PID();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection1 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            EzData.Model.PID pid2 = new EzData.Model.PID();
            EzData.Model.AnChannel anChannel6 = new EzData.Model.AnChannel();
            this.pv1 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv2 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv5 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv6 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv8 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.netResize1 = new Softgroup.NetResize.NetResize(this.components);
            this.DbtPid = new EazyLab.Instrumentation.Combined.PIDLoop();
            this.ledArrow3 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.DOPower = new EazyLab.Instrumentation.Combined.DigOut();
            this.DOWater = new EazyLab.Instrumentation.Combined.DigOut();
            this.DOAir = new EazyLab.Instrumentation.Combined.DigOut();
            this.DOComp1 = new EazyLab.Instrumentation.Combined.DigOut();
            this.DOHum = new EazyLab.Instrumentation.Combined.DigOut();
            this.DOComp2 = new EazyLab.Instrumentation.Combined.DigOut();
            this.cbUpperFanStart = new System.Windows.Forms.CheckBox();
            this.cbCoolFanStart = new System.Windows.Forms.CheckBox();
            this.ledArrow4 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.nudCompressor = new System.Windows.Forms.NumericUpDown();
            this.ledArrow5 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.ledArrow6 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.nudUpperFan = new System.Windows.Forms.NumericUpDown();
            this.nudCoolingFan = new System.Windows.Forms.NumericUpDown();
            this.ledArrow7 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.nudHeater = new System.Windows.Forms.NumericUpDown();
            this.label1 = new EazyLab.Instrumentation.Standard.Label();
            this.ledArrow9 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.sLedStart = new EazyLab.Instrumentation.Standard.SwitchLed();
            this.ledArrow8 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.ledArrow10 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.ledArrow12 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.cbCompressor = new System.Windows.Forms.CheckBox();
            this.WbtPid = new EazyLab.Instrumentation.Combined.PIDLoop();
            this.tBNoFF = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.EvapTempPid = new EazyLab.Instrumentation.Combined.PIDLoop();
            this.pv3 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.nudEvapPIDSteadyState = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.netResize1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompressor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperFan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoolingFan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBNoFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvapPIDSteadyState)).BeginInit();
            this.SuspendLayout();
            // 
            // timerUpdate
            // 
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // pv1
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
            this.pv1.AnCh = anChannel1;
            this.pv1.AnChName = "";
            this.pv1.BackColor = System.Drawing.Color.Transparent;
            this.pv1.DigCount = 4;
            this.pv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv1.Location = new System.Drawing.Point(321, 249);
            this.pv1.Margin = new System.Windows.Forms.Padding(2);
            this.pv1.Max = 1D;
            this.pv1.Min = 0D;
            this.pv1.Name = "pv1";
            this.pv1.PlotTraceName = "EvTemp";
            this.pv1.ShowSign = true;
            this.pv1.Size = new System.Drawing.Size(150, 80);
            this.pv1.TabIndex = 4;
            this.pv1.Tag = "Ev. Temp";
            this.pv1.Value = 0D;
            this.pv1.Load += new System.EventHandler(this.pv1_Load);
            // 
            // pv2
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
            this.pv2.AnCh = anChannel2;
            this.pv2.AnChName = "";
            this.pv2.BackColor = System.Drawing.Color.Transparent;
            this.pv2.DigCount = 4;
            this.pv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv2.Location = new System.Drawing.Point(12, 249);
            this.pv2.Margin = new System.Windows.Forms.Padding(2);
            this.pv2.Max = 1D;
            this.pv2.Min = 0D;
            this.pv2.Name = "pv2";
            this.pv2.PlotTraceName = "DBTemp";
            this.pv2.ShowSign = true;
            this.pv2.Size = new System.Drawing.Size(150, 80);
            this.pv2.TabIndex = 4;
            this.pv2.Tag = "DBTemp";
            this.pv2.Value = 0D;
            // 
            // pv5
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
            this.pv5.AnCh = anChannel3;
            this.pv5.AnChName = "";
            this.pv5.BackColor = System.Drawing.Color.Transparent;
            this.pv5.DigCount = 4;
            this.pv5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv5.Location = new System.Drawing.Point(475, 249);
            this.pv5.Margin = new System.Windows.Forms.Padding(2);
            this.pv5.Max = 1D;
            this.pv5.Min = 0D;
            this.pv5.Name = "pv5";
            this.pv5.PlotTraceName = "AirHum";
            this.pv5.ShowSign = true;
            this.pv5.Size = new System.Drawing.Size(150, 80);
            this.pv5.TabIndex = 4;
            this.pv5.Tag = "Air Hum";
            this.pv5.Value = 0D;
            // 
            // pv6
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
            this.pv6.AnCh = anChannel4;
            this.pv6.AnChName = "";
            this.pv6.BackColor = System.Drawing.Color.Transparent;
            this.pv6.DigCount = 4;
            this.pv6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv6.Location = new System.Drawing.Point(786, 249);
            this.pv6.Margin = new System.Windows.Forms.Padding(2);
            this.pv6.Max = 1D;
            this.pv6.Min = 0D;
            this.pv6.Name = "pv6";
            this.pv6.PlotTraceName = "DewPoint";
            this.pv6.ShowSign = true;
            this.pv6.Size = new System.Drawing.Size(150, 80);
            this.pv6.TabIndex = 4;
            this.pv6.Tag = "Dew Point";
            this.pv6.Value = 0D;
            this.pv6.Load += new System.EventHandler(this.pv6_Load);
            // 
            // pv8
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
            this.pv8.AnCh = anChannel5;
            this.pv8.AnChName = "";
            this.pv8.BackColor = System.Drawing.Color.Transparent;
            this.pv8.DigCount = 4;
            this.pv8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv8.Location = new System.Drawing.Point(166, 249);
            this.pv8.Margin = new System.Windows.Forms.Padding(2);
            this.pv8.Max = 1D;
            this.pv8.Min = 0D;
            this.pv8.Name = "pv8";
            this.pv8.PlotTraceName = "WBTemp";
            this.pv8.ShowSign = true;
            this.pv8.Size = new System.Drawing.Size(150, 80);
            this.pv8.TabIndex = 4;
            this.pv8.Tag = "WBTemp";
            this.pv8.Value = 0D;
            this.pv8.Load += new System.EventHandler(this.pv8_Load);
            // 
            // netResize1
            // 
            this.netResize1.ParentControl = this;
            // 
            // DbtPid
            // 
            this.DbtPid.AutoSize = true;
            this.DbtPid.DGain = 0D;
            this.DbtPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DbtPid.IGain = 0D;
            this.DbtPid.Lable = "DBT PID";
            this.DbtPid.Location = new System.Drawing.Point(513, 477);
            this.DbtPid.Margin = new System.Windows.Forms.Padding(2);
            this.DbtPid.Name = "DbtPid";
            this.DbtPid.PGain = 0D;
            pid3.AnChIn = null;
            pid3.AnChInId = null;
            pid3.AnCoolOut = null;
            pid3.AnCoolOutId = null;
            pid3.AnHeatOut = null;
            pid3.AnHeatOutId = null;
            pid3.ATuneBuffer = null;
            pid3.Description = null;
            pid3.DGain = 0D;
            pid3.DigCoolOut = null;
            pid3.DigCoolOutId = null;
            pid3.DigHeatOut = null;
            pid3.DigHeatOutId = null;
            pid3.Enable = false;
            pid3.ErrorThreshold = 0D;
            pid3.Id = 0;
            pid3.IGain = 0D;
            pid3.Mode = EzData.Model.PID.PidMode.Position;
            pid3.Name = null;
            pid3.NGain = 0D;
            pid3.OutMax = 0D;
            pid3.OutMin = 0D;
            pid3.OutMode = EzData.Model.PID.PidOutMode.Heating;
            pid3.PGain = 0D;
            pid3.PowerAction = null;
            pid3.PVMax = 0D;
            pid3.PVMin = 0D;
            pid3.RateClamp = 1D;
            pid3.ScanningTime = 0;
            pid3.SetPoint = 0D;
            pid3.StartTime = new System.DateTime(((long)(0)));
            pid3.SteadyState = 0D;
            pid3.SteadyStateDetector = null;
            pid3.TuneCurrentCycle = 0;
            this.DbtPid.PID = pid3;
            this.DbtPid.ScanningTime = 0;
            this.DbtPid.SetPoint = 0D;
            this.DbtPid.Size = new System.Drawing.Size(408, 100);
            this.DbtPid.TabIndex = 22;
            // 
            // ledArrow3
            // 
            this.ledArrow3.LoadingBegin();
            this.ledArrow3.Indicator.BodyLength = 14;
            this.ledArrow3.Indicator.HeadSize = 20;
            this.ledArrow3.Location = new System.Drawing.Point(141, 365);
            this.ledArrow3.Margin = new System.Windows.Forms.Padding(2);
            this.ledArrow3.Name = "ledArrow3";
            this.ledArrow3.Size = new System.Drawing.Size(34, 20);
            this.ledArrow3.LoadingEnd();
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
            this.DOPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOPower.Location = new System.Drawing.Point(14, 361);
            this.DOPower.Name = "DOPower";
            this.DOPower.Size = new System.Drawing.Size(77, 24);
            this.DOPower.TabIndex = 21;
            this.DOPower.Text = "Power";
            this.DOPower.UseVisualStyleBackColor = true;
            // 
            // DOWater
            // 
            digChannel3.Address = 0;
            digChannel3.DaqTask = null;
            digChannel3.DaqTaskId = null;
            digChannel3.Description = null;
            digChannel3.HighPriority = false;
            digChannel3.Id = 0;
            digChannel3.Name = null;
            digChannel3.Pids = null;
            digChannel3.Type = EzData.Model.DigChannel.DigChTypes.In;
            digChannel3.Value = false;
            this.DOWater.AnCh = digChannel3;
            this.DOWater.AutoSize = true;
            this.DOWater.DigChName = "";
            this.DOWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOWater.Location = new System.Drawing.Point(198, 344);
            this.DOWater.Name = "DOWater";
            this.DOWater.Size = new System.Drawing.Size(128, 24);
            this.DOWater.TabIndex = 21;
            this.DOWater.Text = "Water Cond.";
            this.DOWater.UseVisualStyleBackColor = true;
            // 
            // DOAir
            // 
            digChannel2.Address = 0;
            digChannel2.DaqTask = null;
            digChannel2.DaqTaskId = null;
            digChannel2.Description = null;
            digChannel2.HighPriority = false;
            digChannel2.Id = 0;
            digChannel2.Name = null;
            digChannel2.Pids = null;
            digChannel2.Type = EzData.Model.DigChannel.DigChTypes.In;
            digChannel2.Value = false;
            this.DOAir.AnCh = digChannel2;
            this.DOAir.AutoSize = true;
            this.DOAir.DigChName = "";
            this.DOAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOAir.Location = new System.Drawing.Point(198, 385);
            this.DOAir.Name = "DOAir";
            this.DOAir.Size = new System.Drawing.Size(102, 24);
            this.DOAir.TabIndex = 21;
            this.DOAir.Text = "Air Cond.";
            this.DOAir.UseVisualStyleBackColor = true;
            // 
            // DOComp1
            // 
            digChannel6.Address = 0;
            digChannel6.DaqTask = null;
            digChannel6.DaqTaskId = null;
            digChannel6.Description = null;
            digChannel6.HighPriority = false;
            digChannel6.Id = 0;
            digChannel6.Name = null;
            digChannel6.Pids = null;
            digChannel6.Type = EzData.Model.DigChannel.DigChTypes.In;
            digChannel6.Value = false;
            this.DOComp1.AnCh = digChannel6;
            this.DOComp1.AutoSize = true;
            this.DOComp1.DigChName = "";
            this.DOComp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOComp1.Location = new System.Drawing.Point(385, 344);
            this.DOComp1.Name = "DOComp1";
            this.DOComp1.Size = new System.Drawing.Size(152, 24);
            this.DOComp1.TabIndex = 21;
            this.DOComp1.Text = "Comp1.Contact";
            this.DOComp1.UseVisualStyleBackColor = true;
            // 
            // DOHum
            // 
            digChannel4.Address = 0;
            digChannel4.DaqTask = null;
            digChannel4.DaqTaskId = null;
            digChannel4.Description = null;
            digChannel4.HighPriority = false;
            digChannel4.Id = 0;
            digChannel4.Name = null;
            digChannel4.Pids = null;
            digChannel4.Type = EzData.Model.DigChannel.DigChTypes.In;
            digChannel4.Value = false;
            this.DOHum.AnCh = digChannel4;
            this.DOHum.AutoSize = true;
            this.DOHum.DigChName = "";
            this.DOHum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOHum.Location = new System.Drawing.Point(385, 444);
            this.DOHum.Name = "DOHum";
            this.DOHum.Size = new System.Drawing.Size(109, 24);
            this.DOHum.TabIndex = 21;
            this.DOHum.Text = "Humidifier";
            this.DOHum.UseVisualStyleBackColor = true;
            this.DOHum.CheckedChanged += new System.EventHandler(this.DOHum_CheckedChanged);
            // 
            // DOComp2
            // 
            digChannel5.Address = 0;
            digChannel5.DaqTask = null;
            digChannel5.DaqTaskId = null;
            digChannel5.Description = null;
            digChannel5.HighPriority = false;
            digChannel5.Id = 0;
            digChannel5.Name = null;
            digChannel5.Pids = null;
            digChannel5.Type = EzData.Model.DigChannel.DigChTypes.In;
            digChannel5.Value = false;
            this.DOComp2.AnCh = digChannel5;
            this.DOComp2.AutoSize = true;
            this.DOComp2.DigChName = "";
            this.DOComp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOComp2.Location = new System.Drawing.Point(385, 385);
            this.DOComp2.Name = "DOComp2";
            this.DOComp2.Size = new System.Drawing.Size(152, 24);
            this.DOComp2.TabIndex = 21;
            this.DOComp2.Text = "Comp2.Contact";
            this.DOComp2.UseVisualStyleBackColor = true;
            // 
            // cbUpperFanStart
            // 
            this.cbUpperFanStart.AutoSize = true;
            this.cbUpperFanStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cbUpperFanStart.Location = new System.Drawing.Point(14, 409);
            this.cbUpperFanStart.Name = "cbUpperFanStart";
            this.cbUpperFanStart.Size = new System.Drawing.Size(118, 24);
            this.cbUpperFanStart.TabIndex = 22;
            this.cbUpperFanStart.Text = "Upper Fan ";
            this.cbUpperFanStart.UseVisualStyleBackColor = true;
            this.cbUpperFanStart.CheckedChanged += new System.EventHandler(this.cbUpperFanStart_CheckedChanged);
            // 
            // cbCoolFanStart
            // 
            this.cbCoolFanStart.AutoSize = true;
            this.cbCoolFanStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cbCoolFanStart.Location = new System.Drawing.Point(798, 355);
            this.cbCoolFanStart.Name = "cbCoolFanStart";
            this.cbCoolFanStart.Size = new System.Drawing.Size(105, 24);
            this.cbCoolFanStart.TabIndex = 22;
            this.cbCoolFanStart.Text = "Cool. Fan";
            this.cbCoolFanStart.UseVisualStyleBackColor = true;
            this.cbCoolFanStart.CheckedChanged += new System.EventHandler(this.cbCoolFanStart_CheckedChanged);
            // 
            // ledArrow4
            // 
            this.ledArrow4.LoadingBegin();
            this.ledArrow4.Indicator.BodyLength = 137;
            this.ledArrow4.Indicator.HeadSize = 20;
            this.ledArrow4.Location = new System.Drawing.Point(197, 365);
            this.ledArrow4.Margin = new System.Windows.Forms.Padding(2);
            this.ledArrow4.Name = "ledArrow4";
            this.ledArrow4.Size = new System.Drawing.Size(157, 20);
            this.ledArrow4.LoadingEnd();
            // 
            // nudCompressor
            // 
            this.nudCompressor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCompressor.Location = new System.Drawing.Point(607, 390);
            this.nudCompressor.Margin = new System.Windows.Forms.Padding(2);
            this.nudCompressor.Name = "nudCompressor";
            this.nudCompressor.Size = new System.Drawing.Size(87, 26);
            this.nudCompressor.TabIndex = 25;
            this.nudCompressor.ValueChanged += new System.EventHandler(this.nudCompressor_ValueChanged);
            // 
            // ledArrow5
            // 
            this.ledArrow5.LoadingBegin();
            this.ledArrow5.Indicator.BodyLength = 155;
            this.ledArrow5.Indicator.HeadSize = 20;
            this.ledArrow5.Location = new System.Drawing.Point(385, 365);
            this.ledArrow5.Margin = new System.Windows.Forms.Padding(2);
            this.ledArrow5.Name = "ledArrow5";
            this.ledArrow5.Size = new System.Drawing.Size(175, 20);
            this.ledArrow5.LoadingEnd();
            // 
            // ledArrow6
            // 
            this.ledArrow6.LoadingBegin();
            this.ledArrow6.Indicator.BodyLength = 14;
            this.ledArrow6.Indicator.HeadSize = 20;
            this.ledArrow6.Location = new System.Drawing.Point(141, 444);
            this.ledArrow6.Margin = new System.Windows.Forms.Padding(2);
            this.ledArrow6.Name = "ledArrow6";
            this.ledArrow6.Size = new System.Drawing.Size(34, 20);
            this.ledArrow6.LoadingEnd();
            // 
            // nudUpperFan
            // 
            this.nudUpperFan.DecimalPlaces = 1;
            this.nudUpperFan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudUpperFan.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudUpperFan.Location = new System.Drawing.Point(14, 438);
            this.nudUpperFan.Margin = new System.Windows.Forms.Padding(2);
            this.nudUpperFan.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudUpperFan.Name = "nudUpperFan";
            this.nudUpperFan.Size = new System.Drawing.Size(105, 26);
            this.nudUpperFan.TabIndex = 30;
            this.nudUpperFan.ValueChanged += new System.EventHandler(this.nudUpperFan_ValueChanged);
            // 
            // nudCoolingFan
            // 
            this.nudCoolingFan.DecimalPlaces = 4;
            this.nudCoolingFan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCoolingFan.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCoolingFan.Location = new System.Drawing.Point(822, 384);
            this.nudCoolingFan.Margin = new System.Windows.Forms.Padding(2);
            this.nudCoolingFan.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCoolingFan.Name = "nudCoolingFan";
            this.nudCoolingFan.Size = new System.Drawing.Size(87, 26);
            this.nudCoolingFan.TabIndex = 30;
            this.nudCoolingFan.ValueChanged += new System.EventHandler(this.nudCoolingFan_ValueChanged);
            // 
            // ledArrow7
            // 
            this.ledArrow7.LoadingBegin();
            this.ledArrow7.Indicator.BodyLength = 94;
            this.ledArrow7.Indicator.HeadSize = 20;
            this.ledArrow7.Location = new System.Drawing.Point(601, 365);
            this.ledArrow7.Margin = new System.Windows.Forms.Padding(2);
            this.ledArrow7.Name = "ledArrow7";
            this.ledArrow7.Size = new System.Drawing.Size(114, 20);
            this.ledArrow7.LoadingEnd();
            // 
            // nudHeater
            // 
            this.nudHeater.DecimalPlaces = 4;
            this.nudHeater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHeater.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHeater.Location = new System.Drawing.Point(197, 438);
            this.nudHeater.Margin = new System.Windows.Forms.Padding(2);
            this.nudHeater.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHeater.Name = "nudHeater";
            this.nudHeater.Size = new System.Drawing.Size(105, 26);
            this.nudHeater.TabIndex = 30;
            this.nudHeater.ValueChanged += new System.EventHandler(this.nudHeater_ValueChanged);
            // 
            // label1
            // 
            this.label1.LoadingBegin();
            this.label1.AutoSize = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 410);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.Text = "Heater";
            this.label1.LoadingEnd();
            // 
            // ledArrow9
            // 
            this.ledArrow9.LoadingBegin();
            this.ledArrow9.Indicator.BodyLength = 14;
            this.ledArrow9.Indicator.HeadSize = 20;
            this.ledArrow9.Location = new System.Drawing.Point(321, 444);
            this.ledArrow9.Margin = new System.Windows.Forms.Padding(2);
            this.ledArrow9.Name = "ledArrow9";
            this.ledArrow9.Size = new System.Drawing.Size(34, 20);
            this.ledArrow9.LoadingEnd();
            // 
            // sLedStart
            // 
            this.sLedStart.LoadingBegin();
            this.sLedStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLedStart.Location = new System.Drawing.Point(820, 432);
            this.sLedStart.Margin = new System.Windows.Forms.Padding(2);
            this.sLedStart.Name = "sLedStart";
            this.sLedStart.Size = new System.Drawing.Size(87, 32);
            this.sLedStart.TabIndex = 38;
            this.sLedStart.Text = "Start";
            this.sLedStart.ValueChanged += new EazyLab.Delegates.ValueBooleanEventHandler(this.sLedStart_ValueChanged);
            this.sLedStart.LoadingEnd();
            // 
            // ledArrow8
            // 
            this.ledArrow8.LoadingBegin();
            this.ledArrow8.Indicator.BodyLength = 14;
            this.ledArrow8.Indicator.HeadSize = 20;
            this.ledArrow8.Location = new System.Drawing.Point(528, 444);
            this.ledArrow8.Margin = new System.Windows.Forms.Padding(2);
            this.ledArrow8.Name = "ledArrow8";
            this.ledArrow8.Size = new System.Drawing.Size(34, 20);
            this.ledArrow8.LoadingEnd();
            // 
            // ledArrow10
            // 
            this.ledArrow10.LoadingBegin();
            this.ledArrow10.Indicator.BodyLength = 14;
            this.ledArrow10.Indicator.HeadSize = 20;
            this.ledArrow10.Location = new System.Drawing.Point(460, 568);
            this.ledArrow10.Margin = new System.Windows.Forms.Padding(2);
            this.ledArrow10.Name = "ledArrow10";
            this.ledArrow10.Size = new System.Drawing.Size(34, 20);
            this.ledArrow10.LoadingEnd();
            // 
            // ledArrow12
            // 
            this.ledArrow12.LoadingBegin();
            this.ledArrow12.Indicator.BodyLength = 14;
            this.ledArrow12.Indicator.HeadSize = 20;
            this.ledArrow12.Location = new System.Drawing.Point(742, 444);
            this.ledArrow12.Margin = new System.Windows.Forms.Padding(2);
            this.ledArrow12.Name = "ledArrow12";
            this.ledArrow12.Size = new System.Drawing.Size(34, 20);
            this.ledArrow12.LoadingEnd();
            // 
            // cbCompressor
            // 
            this.cbCompressor.AutoSize = true;
            this.cbCompressor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cbCompressor.Location = new System.Drawing.Point(601, 344);
            this.cbCompressor.Name = "cbCompressor";
            this.cbCompressor.Size = new System.Drawing.Size(108, 24);
            this.cbCompressor.TabIndex = 22;
            this.cbCompressor.Text = "Compress";
            this.cbCompressor.UseVisualStyleBackColor = true;
            this.cbCompressor.CheckedChanged += new System.EventHandler(this.cbCompressor_CheckedChanged);
            // 
            // WbtPid
            // 
            this.WbtPid.AutoSize = true;
            this.WbtPid.DGain = 0D;
            this.WbtPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WbtPid.IGain = 0D;
            this.WbtPid.Lable = "WBT PID";
            this.WbtPid.Location = new System.Drawing.Point(513, 581);
            this.WbtPid.Margin = new System.Windows.Forms.Padding(2);
            this.WbtPid.Name = "WbtPid";
            this.WbtPid.PGain = 0D;
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
            this.WbtPid.PID = pid1;
            this.WbtPid.ScanningTime = 0;
            this.WbtPid.SetPoint = 0D;
            this.WbtPid.Size = new System.Drawing.Size(408, 100);
            this.WbtPid.TabIndex = 22;
            // 
            // tBNoFF
            // 
            this.tBNoFF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tBNoFF.ForeColor = System.Drawing.Color.Black;
            this.tBNoFF.Location = new System.Drawing.Point(601, 432);
            this.tBNoFF.MinimumSize = new System.Drawing.Size(61, 20);
            this.tBNoFF.Name = "tBNoFF";
            this.tBNoFF.Size = new System.Drawing.Size(105, 40);
            this.tBNoFF.Slider = sliderCollection1;
            this.tBNoFF.TabIndex = 49;
            this.tBNoFF.Text = "OnOff";
            this.tBNoFF.Click += new System.EventHandler(this.tBNoFF_Click);
            // 
            // EvapTempPid
            // 
            this.EvapTempPid.AutoSize = true;
            this.EvapTempPid.DGain = 0D;
            this.EvapTempPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvapTempPid.IGain = 0D;
            this.EvapTempPid.Lable = "Evap Temp PID";
            this.EvapTempPid.Location = new System.Drawing.Point(14, 517);
            this.EvapTempPid.Margin = new System.Windows.Forms.Padding(2);
            this.EvapTempPid.Name = "EvapTempPid";
            this.EvapTempPid.PGain = 0D;
            pid2.AnChIn = null;
            pid2.AnChInId = null;
            pid2.AnCoolOut = null;
            pid2.AnCoolOutId = null;
            pid2.AnHeatOut = null;
            pid2.AnHeatOutId = null;
            pid2.ATuneBuffer = null;
            pid2.Description = null;
            pid2.DGain = 0D;
            pid2.DigCoolOut = null;
            pid2.DigCoolOutId = null;
            pid2.DigHeatOut = null;
            pid2.DigHeatOutId = null;
            pid2.Enable = false;
            pid2.ErrorThreshold = 0D;
            pid2.Id = 0;
            pid2.IGain = 0D;
            pid2.Mode = EzData.Model.PID.PidMode.Position;
            pid2.Name = null;
            pid2.NGain = 0D;
            pid2.OutMax = 0D;
            pid2.OutMin = 0D;
            pid2.OutMode = EzData.Model.PID.PidOutMode.Heating;
            pid2.PGain = 0D;
            pid2.PowerAction = null;
            pid2.PVMax = 0D;
            pid2.PVMin = 0D;
            pid2.RateClamp = 1D;
            pid2.ScanningTime = 0;
            pid2.SetPoint = 0D;
            pid2.StartTime = new System.DateTime(((long)(0)));
            pid2.SteadyState = 0D;
            pid2.SteadyStateDetector = null;
            pid2.TuneCurrentCycle = 0;
            this.EvapTempPid.PID = pid2;
            this.EvapTempPid.ScanningTime = 0;
            this.EvapTempPid.SetPoint = 0D;
            this.EvapTempPid.Size = new System.Drawing.Size(408, 100);
            this.EvapTempPid.TabIndex = 22;
            this.EvapTempPid.Load += new System.EventHandler(this.EvapTempPid_Load);
            // 
            // pv3
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
            this.pv3.AnCh = anChannel6;
            this.pv3.AnChName = "";
            this.pv3.BackColor = System.Drawing.Color.Transparent;
            this.pv3.DigCount = 4;
            this.pv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv3.Location = new System.Drawing.Point(629, 249);
            this.pv3.Margin = new System.Windows.Forms.Padding(2);
            this.pv3.Max = 1D;
            this.pv3.Min = 0D;
            this.pv3.Name = "pv3";
            this.pv3.PlotTraceName = "InletAirTemp";
            this.pv3.ShowSign = true;
            this.pv3.Size = new System.Drawing.Size(150, 80);
            this.pv3.TabIndex = 4;
            this.pv3.Tag = "Inlet Air Temp";
            this.pv3.Value = 0D;
            // 
            // nudEvapPIDSteadyState
            // 
            this.nudEvapPIDSteadyState.DecimalPlaces = 4;
            this.nudEvapPIDSteadyState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEvapPIDSteadyState.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudEvapPIDSteadyState.Location = new System.Drawing.Point(111, 634);
            this.nudEvapPIDSteadyState.Margin = new System.Windows.Forms.Padding(2);
            this.nudEvapPIDSteadyState.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEvapPIDSteadyState.Name = "nudEvapPIDSteadyState";
            this.nudEvapPIDSteadyState.Size = new System.Drawing.Size(105, 26);
            this.nudEvapPIDSteadyState.TabIndex = 30;
            this.nudEvapPIDSteadyState.ValueChanged += new System.EventHandler(this.nudEvapPIDSteadyState_ValueChanged);
            // 
            // frmHardwareChamber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.tBNoFF);
            this.Controls.Add(this.pv6);
            this.Controls.Add(this.pv8);
            this.Controls.Add(this.pv3);
            this.Controls.Add(this.pv5);
            this.Controls.Add(this.pv1);
            this.Controls.Add(this.pv2);
            this.Controls.Add(this.sLedStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudCoolingFan);
            this.Controls.Add(this.nudEvapPIDSteadyState);
            this.Controls.Add(this.nudHeater);
            this.Controls.Add(this.nudUpperFan);
            this.Controls.Add(this.nudCompressor);
            this.Controls.Add(this.cbUpperFanStart);
            this.Controls.Add(this.cbCompressor);
            this.Controls.Add(this.cbCoolFanStart);
            this.Controls.Add(this.ledArrow7);
            this.Controls.Add(this.ledArrow5);
            this.Controls.Add(this.ledArrow4);
            this.Controls.Add(this.ledArrow12);
            this.Controls.Add(this.ledArrow8);
            this.Controls.Add(this.ledArrow9);
            this.Controls.Add(this.ledArrow10);
            this.Controls.Add(this.ledArrow6);
            this.Controls.Add(this.ledArrow3);
            this.Controls.Add(this.DOPower);
            this.Controls.Add(this.WbtPid);
            this.Controls.Add(this.EvapTempPid);
            this.Controls.Add(this.DbtPid);
            this.Controls.Add(this.DOAir);
            this.Controls.Add(this.DOWater);
            this.Controls.Add(this.DOHum);
            this.Controls.Add(this.DOComp2);
            this.Controls.Add(this.DOComp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHardwareChamber";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Auto;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHardwareChamber_Load);
            this.Controls.SetChildIndex(this.DOComp1, 0);
            this.Controls.SetChildIndex(this.DOComp2, 0);
            this.Controls.SetChildIndex(this.DOHum, 0);
            this.Controls.SetChildIndex(this.DOWater, 0);
            this.Controls.SetChildIndex(this.DOAir, 0);
            this.Controls.SetChildIndex(this.DbtPid, 0);
            this.Controls.SetChildIndex(this.EvapTempPid, 0);
            this.Controls.SetChildIndex(this.WbtPid, 0);
            this.Controls.SetChildIndex(this.DOPower, 0);
            this.Controls.SetChildIndex(this.ledArrow3, 0);
            this.Controls.SetChildIndex(this.ledArrow6, 0);
            this.Controls.SetChildIndex(this.ledArrow10, 0);
            this.Controls.SetChildIndex(this.ledArrow9, 0);
            this.Controls.SetChildIndex(this.ledArrow8, 0);
            this.Controls.SetChildIndex(this.ledArrow12, 0);
            this.Controls.SetChildIndex(this.ledArrow4, 0);
            this.Controls.SetChildIndex(this.ledArrow5, 0);
            this.Controls.SetChildIndex(this.ledArrow7, 0);
            this.Controls.SetChildIndex(this.cbCoolFanStart, 0);
            this.Controls.SetChildIndex(this.cbCompressor, 0);
            this.Controls.SetChildIndex(this.cbUpperFanStart, 0);
            this.Controls.SetChildIndex(this.nudCompressor, 0);
            this.Controls.SetChildIndex(this.nudUpperFan, 0);
            this.Controls.SetChildIndex(this.nudHeater, 0);
            this.Controls.SetChildIndex(this.nudEvapPIDSteadyState, 0);
            this.Controls.SetChildIndex(this.nudCoolingFan, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.sLedStart, 0);
            this.Controls.SetChildIndex(this.pv2, 0);
            this.Controls.SetChildIndex(this.pv1, 0);
            this.Controls.SetChildIndex(this.pv5, 0);
            this.Controls.SetChildIndex(this.pv3, 0);
            this.Controls.SetChildIndex(this.pv8, 0);
            this.Controls.SetChildIndex(this.pv6, 0);
            this.Controls.SetChildIndex(this.tBNoFF, 0);
            ((System.ComponentModel.ISupportInitialize)(this.netResize1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompressor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperFan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoolingFan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBNoFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvapPIDSteadyState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EazyLab.Instrumentation.WF40.Combined.PV pv1;
        private EazyLab.Instrumentation.WF40.Combined.PV pv2;
        private EazyLab.Instrumentation.WF40.Combined.PV pv5;
        private EazyLab.Instrumentation.WF40.Combined.PV pv6;
        private EazyLab.Instrumentation.WF40.Combined.PV pv8;
        private Softgroup.NetResize.NetResize netResize1;
        private EazyLab.Instrumentation.Combined.PIDLoop DbtPid;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow3;
        private System.Windows.Forms.NumericUpDown nudCompressor;
        private System.Windows.Forms.CheckBox cbUpperFanStart;
        private System.Windows.Forms.CheckBox cbCoolFanStart;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow5;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow4;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow6;
        private EazyLab.Instrumentation.Combined.DigOut DOPower;
        private EazyLab.Instrumentation.Combined.DigOut DOAir;
        private EazyLab.Instrumentation.Combined.DigOut DOWater;
        private EazyLab.Instrumentation.Combined.DigOut DOHum;
        private EazyLab.Instrumentation.Combined.DigOut DOComp2;
        private EazyLab.Instrumentation.Combined.DigOut DOComp1;
        private EazyLab.Instrumentation.Standard.Label label1;
        private System.Windows.Forms.NumericUpDown nudCoolingFan;
        private System.Windows.Forms.NumericUpDown nudHeater;
        private System.Windows.Forms.NumericUpDown nudUpperFan;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow7;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow9;
        private EazyLab.Instrumentation.Standard.SwitchLed sLedStart;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow8;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow10;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow12;
        private System.Windows.Forms.CheckBox cbCompressor;
        private EazyLab.Instrumentation.Combined.PIDLoop WbtPid;
        private Syncfusion.Windows.Forms.Tools.ToggleButton tBNoFF;
        private EazyLab.Instrumentation.Combined.PIDLoop EvapTempPid;
        private EazyLab.Instrumentation.WF40.Combined.PV pv3;
        private System.Windows.Forms.NumericUpDown nudEvapPIDSteadyState;
    }
}