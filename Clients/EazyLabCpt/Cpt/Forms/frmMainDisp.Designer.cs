namespace Client.Forms
{
    partial class frmMainDisp
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
            EzData.Model.AnChannel anChannel6 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel7 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel8 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel9 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel10 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel11 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel14 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel12 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel13 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel15 = new EzData.Model.AnChannel();
            EzData.Model.AnChannel anChannel16 = new EzData.Model.AnChannel();
            this.pvInDoorDBT = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv5 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pvInDoorWbt = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv12 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv11 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv13 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv14 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv9 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv15 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pvOutDoorWbt = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv7 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pvOutDoorDbt = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.glInDoor = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.ledInDoor = new EazyLab.Instrumentation.Standard.Led();
            this.glSample = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.pv4 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv6 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pvCoolingCapacity = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.ledSample = new EazyLab.Instrumentation.Standard.Led();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gloutDoor = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.led1 = new EazyLab.Instrumentation.Standard.Led();
            this.pvAirFlow = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.pv2 = new EazyLab.Instrumentation.WF40.Combined.PV();
            this.textBoxInDoor = new System.Windows.Forms.RichTextBox();
            this.textBoxOutDoor = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd5Min = new System.Windows.Forms.Button();
            this.buttonResetStbTime = new System.Windows.Forms.Button();
            this.buttonPowerCT = new System.Windows.Forms.Button();
            this.TextBoxSample = new System.Windows.Forms.RichTextBox();
            this.timerRun = new System.Windows.Forms.Timer(this.components);
            this.netResize1 = new Softgroup.NetResize.NetResize(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netResize1)).BeginInit();
            this.SuspendLayout();
            // 
            // pvInDoorDBT
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
            this.pvInDoorDBT.AnCh = anChannel1;
            this.pvInDoorDBT.AnChName = "InDoorAnalogRead:0";
            this.pvInDoorDBT.Axis = 0;
            this.pvInDoorDBT.BackColor = System.Drawing.Color.Transparent;
            this.pvInDoorDBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pvInDoorDBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.528F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvInDoorDBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pvInDoorDBT.Location = new System.Drawing.Point(15, 55);
            this.pvInDoorDBT.Margin = new System.Windows.Forms.Padding(5);
            this.pvInDoorDBT.Max = 1D;
            this.pvInDoorDBT.Min = 0D;
            this.pvInDoorDBT.Name = "pvInDoorDBT";
            this.pvInDoorDBT.PlotTraceName = "InDoor DBT";
            this.pvInDoorDBT.Size = new System.Drawing.Size(251, 99);
            this.pvInDoorDBT.TabIndex = 0;
            this.pvInDoorDBT.Tag = "DBTemp(oC)";
            this.pvInDoorDBT.Value = 32D;
            // 
            // pv5
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
            this.pv5.AnCh = anChannel2;
            this.pv5.AnChName = "InDoorHygroclip:0";
            this.pv5.Axis = 0;
            this.pv5.BackColor = System.Drawing.Color.Transparent;
            this.pv5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.528F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv5.Location = new System.Drawing.Point(15, 273);
            this.pv5.Margin = new System.Windows.Forms.Padding(5);
            this.pv5.Max = 1D;
            this.pv5.Min = 0D;
            this.pv5.Name = "pv5";
            this.pv5.PlotTraceName = "INDoor Hum";
            this.pv5.Size = new System.Drawing.Size(251, 99);
            this.pv5.TabIndex = 0;
            this.pv5.Tag = "Humidity(%)";
            this.pv5.Value = 32D;
            // 
            // pvInDoorWbt
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
            this.pvInDoorWbt.AnCh = anChannel3;
            this.pvInDoorWbt.AnChName = "InDoorAnalogRead:1";
            this.pvInDoorWbt.Axis = 0;
            this.pvInDoorWbt.BackColor = System.Drawing.Color.Transparent;
            this.pvInDoorWbt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pvInDoorWbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.528F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvInDoorWbt.Location = new System.Drawing.Point(15, 164);
            this.pvInDoorWbt.Margin = new System.Windows.Forms.Padding(5);
            this.pvInDoorWbt.Max = 1D;
            this.pvInDoorWbt.Min = 0D;
            this.pvInDoorWbt.Name = "pvInDoorWbt";
            this.pvInDoorWbt.PlotTraceName = "InDoor WBT";
            this.pvInDoorWbt.Size = new System.Drawing.Size(251, 99);
            this.pvInDoorWbt.TabIndex = 0;
            this.pvInDoorWbt.Tag = "WBTemp(oC)";
            this.pvInDoorWbt.Value = 32D;
            // 
            // pv12
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
            this.pv12.AnCh = anChannel4;
            this.pv12.AnChName = "";
            this.pv12.Axis = 0;
            this.pv12.BackColor = System.Drawing.Color.Transparent;
            this.pv12.DecimalPos = 2;
            this.pv12.DigCount = 4;
            this.pv12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.528F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv12.Location = new System.Drawing.Point(276, 164);
            this.pv12.Margin = new System.Windows.Forms.Padding(5);
            this.pv12.Max = 1D;
            this.pv12.Min = 0D;
            this.pv12.Name = "pv12";
            this.pv12.PlotTraceName = "Current";
            this.pv12.Size = new System.Drawing.Size(251, 99);
            this.pv12.TabIndex = 0;
            this.pv12.Tag = "Current";
            this.pv12.Value = 32D;
            // 
            // pv11
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
            this.pv11.AnCh = anChannel5;
            this.pv11.AnChName = "";
            this.pv11.Axis = 1;
            this.pv11.BackColor = System.Drawing.Color.Transparent;
            this.pv11.DecimalPos = 0;
            this.pv11.DigCount = 5;
            this.pv11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.528F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv11.Location = new System.Drawing.Point(276, 273);
            this.pv11.Margin = new System.Windows.Forms.Padding(5);
            this.pv11.Max = 1D;
            this.pv11.Min = 0D;
            this.pv11.Name = "pv11";
            this.pv11.PlotTraceName = "Power";
            this.pv11.Size = new System.Drawing.Size(251, 99);
            this.pv11.TabIndex = 0;
            this.pv11.Tag = "Power";
            this.pv11.Value = 32D;
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
            this.pv13.Axis = 0;
            this.pv13.BackColor = System.Drawing.Color.Transparent;
            this.pv13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.528F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv13.Location = new System.Drawing.Point(537, 164);
            this.pv13.Margin = new System.Windows.Forms.Padding(5);
            this.pv13.Max = 1D;
            this.pv13.Min = 0D;
            this.pv13.Name = "pv13";
            this.pv13.PlotTraceName = "Sample WBT";
            this.pv13.Size = new System.Drawing.Size(251, 99);
            this.pv13.TabIndex = 0;
            this.pv13.Tag = "WBTemp(oC)";
            this.pv13.Value = 32D;
            // 
            // pv14
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
            this.pv14.AnCh = anChannel7;
            this.pv14.AnChName = "CodeTesterAnalogRead:3";
            this.pv14.Axis = 0;
            this.pv14.BackColor = System.Drawing.Color.Transparent;
            this.pv14.DecimalPos = 0;
            this.pv14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.528F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv14.Location = new System.Drawing.Point(798, 55);
            this.pv14.Margin = new System.Windows.Forms.Padding(5);
            this.pv14.Max = 1D;
            this.pv14.Min = 0D;
            this.pv14.Name = "pv14";
            this.pv14.PlotTraceName = "Flow Rate";
            this.pv14.ShowSign = true;
            this.pv14.Size = new System.Drawing.Size(251, 99);
            this.pv14.TabIndex = 0;
            this.pv14.Tag = "Static Press(Pa)";
            this.pv14.Value = 32D;
            // 
            // pv9
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
            this.pv9.AnCh = anChannel8;
            this.pv9.AnChName = "";
            this.pv9.Axis = 0;
            this.pv9.BackColor = System.Drawing.Color.Transparent;
            this.pv9.DecimalPos = 0;
            this.pv9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.528F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv9.Location = new System.Drawing.Point(276, 55);
            this.pv9.Margin = new System.Windows.Forms.Padding(5);
            this.pv9.Max = 1D;
            this.pv9.Min = 0D;
            this.pv9.Name = "pv9";
            this.pv9.PlotTraceName = "Voltage";
            this.pv9.Size = new System.Drawing.Size(251, 99);
            this.pv9.TabIndex = 0;
            this.pv9.Tag = "Voltage";
            this.pv9.Value = 32D;
            // 
            // pv15
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
            this.pv15.AnCh = anChannel9;
            this.pv15.AnChName = "CodeTesterAnalogRead:0";
            this.pv15.Axis = 0;
            this.pv15.BackColor = System.Drawing.Color.Transparent;
            this.pv15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.528F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv15.Location = new System.Drawing.Point(537, 55);
            this.pv15.Margin = new System.Windows.Forms.Padding(5);
            this.pv15.Max = 1D;
            this.pv15.Min = 0D;
            this.pv15.Name = "pv15";
            this.pv15.PlotTraceName = "Sample DBT";
            this.pv15.Size = new System.Drawing.Size(251, 99);
            this.pv15.TabIndex = 0;
            this.pv15.Tag = "DBTemp(oC)";
            this.pv15.Value = 32D;
            // 
            // pvOutDoorWbt
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
            this.pvOutDoorWbt.AnCh = anChannel10;
            this.pvOutDoorWbt.AnChName = "OutDoorAnalogRead:1";
            this.pvOutDoorWbt.Axis = 0;
            this.pvOutDoorWbt.BackColor = System.Drawing.Color.Transparent;
            this.pvOutDoorWbt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pvOutDoorWbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.528F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvOutDoorWbt.Location = new System.Drawing.Point(1059, 164);
            this.pvOutDoorWbt.Margin = new System.Windows.Forms.Padding(5);
            this.pvOutDoorWbt.Max = 1D;
            this.pvOutDoorWbt.Min = 0D;
            this.pvOutDoorWbt.Name = "pvOutDoorWbt";
            this.pvOutDoorWbt.PlotTraceName = "OutDoor WBT";
            this.pvOutDoorWbt.Size = new System.Drawing.Size(251, 99);
            this.pvOutDoorWbt.TabIndex = 0;
            this.pvOutDoorWbt.Tag = "WBTemp(oC)";
            this.pvOutDoorWbt.Value = 32D;
            // 
            // pv7
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
            this.pv7.AnCh = anChannel11;
            this.pv7.AnChName = "OutDoorHygroclip:0";
            this.pv7.Axis = 0;
            this.pv7.BackColor = System.Drawing.Color.Transparent;
            this.pv7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.528F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv7.Location = new System.Drawing.Point(1059, 273);
            this.pv7.Margin = new System.Windows.Forms.Padding(5);
            this.pv7.Max = 1D;
            this.pv7.Min = 0D;
            this.pv7.Name = "pv7";
            this.pv7.PlotTraceName = "OutDoor Hum";
            this.pv7.Size = new System.Drawing.Size(251, 99);
            this.pv7.TabIndex = 0;
            this.pv7.Tag = "Humidity(%)";
            this.pv7.Value = 32D;
            // 
            // pvOutDoorDbt
            // 
            this.pvOutDoorDbt.AnCh = null;
            this.pvOutDoorDbt.AnChName = "OutDoorAnalogRead:0";
            this.pvOutDoorDbt.Axis = 0;
            this.pvOutDoorDbt.BackColor = System.Drawing.Color.Transparent;
            this.pvOutDoorDbt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pvOutDoorDbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.528F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvOutDoorDbt.Location = new System.Drawing.Point(1056, 52);
            this.pvOutDoorDbt.Margin = new System.Windows.Forms.Padding(2);
            this.pvOutDoorDbt.Max = 1D;
            this.pvOutDoorDbt.Min = 0D;
            this.pvOutDoorDbt.Name = "pvOutDoorDbt";
            this.pvOutDoorDbt.PlotTraceName = "OutDoor DBT";
            this.pvOutDoorDbt.Size = new System.Drawing.Size(257, 105);
            this.pvOutDoorDbt.TabIndex = 0;
            this.pvOutDoorDbt.Tag = "DBTemp(oC)";
            this.pvOutDoorDbt.Value = 32D;
            // 
            // glInDoor
            // 
            this.glInDoor.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.Transparent);
            this.glInDoor.BeforeTouchSize = new System.Drawing.Size(255, 42);
            this.glInDoor.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.glInDoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glInDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glInDoor.Location = new System.Drawing.Point(13, 486);
            this.glInDoor.Name = "glInDoor";
            this.glInDoor.Size = new System.Drawing.Size(255, 42);
            this.glInDoor.TabIndex = 1;
            this.glInDoor.Text = "gradientLabel1";
            this.glInDoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledInDoor
            // 
            this.ledInDoor.LoadingBegin();
            this.ledInDoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledInDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.ledInDoor.Indicator.ColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ledInDoor.Indicator.ColorInactive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ledInDoor.Indicator.Style = EazyLab.Types.ShapeBasic.Rectangle;
            this.ledInDoor.Indicator.Text = "InDoor";
            this.ledInDoor.Location = new System.Drawing.Point(13, 3);
            this.ledInDoor.Name = "ledInDoor";
            this.ledInDoor.Size = new System.Drawing.Size(255, 44);
            this.ledInDoor.LoadingEnd();
            // 
            // glSample
            // 
            this.glSample.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.Transparent);
            this.glSample.BeforeTouchSize = new System.Drawing.Size(516, 42);
            this.glSample.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.tableLayoutPanel4.SetColumnSpan(this.glSample, 2);
            this.glSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glSample.Location = new System.Drawing.Point(274, 486);
            this.glSample.Name = "glSample";
            this.glSample.Size = new System.Drawing.Size(516, 42);
            this.glSample.TabIndex = 1;
            this.glSample.Text = "gradientLabel3";
            this.glSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.glSample.Click += new System.EventHandler(this.glSample_Click);
            // 
            // pv4
            // 
            anChannel14.Address = 0;
            anChannel14.CalibratedValue = 0D;
            anChannel14.Calibration = null;
            anChannel14.CalibrationId = null;
            anChannel14.DaqTask = null;
            anChannel14.DaqTaskId = null;
            anChannel14.Description = null;
            anChannel14.FilterType = EzData.Filter.FilterType.Average;
            anChannel14.HighPriority = false;
            anChannel14.Id = 0;
            anChannel14.Name = null;
            anChannel14.Offset = 0D;
            anChannel14.Pids = null;
            anChannel14.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel14.Unit = null;
            anChannel14.UnitId = null;
            anChannel14.Value = 0D;
            anChannel14.WindowSize = 10;
            this.pv4.AnCh = anChannel14;
            this.pv4.AnChName = "";
            this.pv4.Axis = 0;
            this.pv4.BackColor = System.Drawing.Color.Transparent;
            this.pv4.DecimalPos = 4;
            this.pv4.DigCount = 5;
            this.pv4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.528F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv4.Location = new System.Drawing.Point(276, 382);
            this.pv4.Margin = new System.Windows.Forms.Padding(5);
            this.pv4.Max = 1D;
            this.pv4.Min = 0D;
            this.pv4.Name = "pv4";
            this.pv4.PlotTraceName = "Power";
            this.pv4.Size = new System.Drawing.Size(251, 99);
            this.pv4.TabIndex = 0;
            this.pv4.Tag = "PowerFactor";
            this.pv4.Value = 0.99D;
            // 
            // pv6
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
            this.pv6.AnCh = anChannel12;
            this.pv6.AnChName = "CodeTesterAnalogRead:4";
            this.pv6.Axis = 0;
            this.pv6.BackColor = System.Drawing.Color.Transparent;
            this.pv6.DecimalPos = 0;
            this.pv6.DigCount = 4;
            this.pv6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv6.Location = new System.Drawing.Point(798, 164);
            this.pv6.Margin = new System.Windows.Forms.Padding(5);
            this.pv6.Max = 1D;
            this.pv6.Min = 0D;
            this.pv6.Name = "pv6";
            this.pv6.PlotTraceName = "Nozzle Press";
            this.pv6.ShowSign = true;
            this.pv6.Size = new System.Drawing.Size(251, 99);
            this.pv6.TabIndex = 0;
            this.pv6.Tag = "Nozzle Press(Pa)";
            this.pv6.Value = 32D;
            this.pv6.Load += new System.EventHandler(this.pv6_Load);
            // 
            // pvCoolingCapacity
            // 
            anChannel13.Address = 0;
            anChannel13.CalibratedValue = 0D;
            anChannel13.Calibration = null;
            anChannel13.CalibrationId = null;
            anChannel13.DaqTask = null;
            anChannel13.DaqTaskId = null;
            anChannel13.Description = null;
            anChannel13.FilterType = EzData.Filter.FilterType.Average;
            anChannel13.HighPriority = false;
            anChannel13.Id = 0;
            anChannel13.Name = null;
            anChannel13.Offset = 0D;
            anChannel13.Pids = null;
            anChannel13.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel13.Unit = null;
            anChannel13.UnitId = null;
            anChannel13.Value = 0D;
            anChannel13.WindowSize = 10;
            this.pvCoolingCapacity.AnCh = anChannel13;
            this.pvCoolingCapacity.AnChName = " ";
            this.pvCoolingCapacity.Axis = 1;
            this.pvCoolingCapacity.BackColor = System.Drawing.Color.Transparent;
            this.pvCoolingCapacity.DecimalPos = 0;
            this.pvCoolingCapacity.DigCount = 6;
            this.pvCoolingCapacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pvCoolingCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvCoolingCapacity.Location = new System.Drawing.Point(537, 273);
            this.pvCoolingCapacity.Margin = new System.Windows.Forms.Padding(5);
            this.pvCoolingCapacity.Max = 1D;
            this.pvCoolingCapacity.Min = 0D;
            this.pvCoolingCapacity.Name = "pvCoolingCapacity";
            this.pvCoolingCapacity.PlotTraceName = "Cooling Capacity";
            this.pvCoolingCapacity.Size = new System.Drawing.Size(251, 99);
            this.pvCoolingCapacity.TabIndex = 0;
            this.pvCoolingCapacity.Tag = "Cooling Capacity";
            this.pvCoolingCapacity.Value = 32D;
            // 
            // ledSample
            // 
            this.ledSample.LoadingBegin();
            this.tableLayoutPanel4.SetColumnSpan(this.ledSample, 3);
            this.ledSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledSample.Indicator.ColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ledSample.Indicator.ColorInactive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ledSample.Indicator.Style = EazyLab.Types.ShapeBasic.Rectangle;
            this.ledSample.Indicator.Text = "Sample";
            this.ledSample.Location = new System.Drawing.Point(274, 3);
            this.ledSample.Name = "ledSample";
            this.ledSample.Size = new System.Drawing.Size(777, 44);
            this.ledSample.LoadingEnd();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.Controls.Add(this.ledSample, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.pv9, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.glSample, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.gloutDoor, 5, 5);
            this.tableLayoutPanel4.Controls.Add(this.pv7, 5, 3);
            this.tableLayoutPanel4.Controls.Add(this.glInDoor, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.pv5, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.pvOutDoorWbt, 5, 2);
            this.tableLayoutPanel4.Controls.Add(this.led1, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.pvOutDoorDbt, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.pvInDoorWbt, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.pvInDoorDBT, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.ledInDoor, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pv12, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.pv15, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.pv13, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.pv14, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.pv6, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.pvCoolingCapacity, 3, 3);
            this.tableLayoutPanel4.Controls.Add(this.pv11, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.pv4, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.pvAirFlow, 4, 3);
            this.tableLayoutPanel4.Controls.Add(this.pv2, 4, 4);
            this.tableLayoutPanel4.Controls.Add(this.textBoxInDoor, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.textBoxOutDoor, 5, 4);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 4, 5);
            this.tableLayoutPanel4.Controls.Add(this.TextBoxSample, 3, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 259);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1337, 528);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // gloutDoor
            // 
            this.gloutDoor.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.Transparent);
            this.gloutDoor.BeforeTouchSize = new System.Drawing.Size(255, 42);
            this.gloutDoor.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gloutDoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gloutDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gloutDoor.Location = new System.Drawing.Point(1057, 486);
            this.gloutDoor.Name = "gloutDoor";
            this.gloutDoor.Size = new System.Drawing.Size(255, 42);
            this.gloutDoor.TabIndex = 1;
            this.gloutDoor.Text = "gradientLabel2";
            this.gloutDoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // led1
            // 
            this.led1.LoadingBegin();
            this.led1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.led1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.led1.Indicator.ColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.led1.Indicator.ColorInactive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.led1.Indicator.Style = EazyLab.Types.ShapeBasic.Rectangle;
            this.led1.Indicator.Text = "OutDoor";
            this.led1.Location = new System.Drawing.Point(1057, 3);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(255, 44);
            this.led1.LoadingEnd();
            // 
            // pvAirFlow
            // 
            anChannel15.Address = 0;
            anChannel15.CalibratedValue = 0D;
            anChannel15.Calibration = null;
            anChannel15.CalibrationId = null;
            anChannel15.DaqTask = null;
            anChannel15.DaqTaskId = null;
            anChannel15.Description = null;
            anChannel15.FilterType = EzData.Filter.FilterType.Average;
            anChannel15.HighPriority = false;
            anChannel15.Id = 0;
            anChannel15.Name = null;
            anChannel15.Offset = 0D;
            anChannel15.Pids = null;
            anChannel15.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel15.Unit = null;
            anChannel15.UnitId = null;
            anChannel15.Value = 0D;
            anChannel15.WindowSize = 10;
            this.pvAirFlow.AnCh = anChannel15;
            this.pvAirFlow.AnChName = " ";
            this.pvAirFlow.Axis = 0;
            this.pvAirFlow.BackColor = System.Drawing.Color.Transparent;
            this.pvAirFlow.DigCount = 5;
            this.pvAirFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pvAirFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvAirFlow.Location = new System.Drawing.Point(798, 273);
            this.pvAirFlow.Margin = new System.Windows.Forms.Padding(5);
            this.pvAirFlow.Max = 1D;
            this.pvAirFlow.Min = 0D;
            this.pvAirFlow.Name = "pvAirFlow";
            this.pvAirFlow.PlotTraceName = "AirFlowRate";
            this.pvAirFlow.Size = new System.Drawing.Size(251, 99);
            this.pvAirFlow.TabIndex = 4;
            this.pvAirFlow.Tag = "AirFlowRate(m3/h)";
            this.pvAirFlow.Value = 32D;
            // 
            // pv2
            // 
            anChannel16.Address = 0;
            anChannel16.CalibratedValue = 0D;
            anChannel16.Calibration = null;
            anChannel16.CalibrationId = null;
            anChannel16.DaqTask = null;
            anChannel16.DaqTaskId = null;
            anChannel16.Description = null;
            anChannel16.FilterType = EzData.Filter.FilterType.Average;
            anChannel16.HighPriority = false;
            anChannel16.Id = 0;
            anChannel16.Name = null;
            anChannel16.Offset = 0D;
            anChannel16.Pids = null;
            anChannel16.Type = EzData.Model.AnChannel.AnChTypes.In;
            anChannel16.Unit = null;
            anChannel16.UnitId = null;
            anChannel16.Value = 0D;
            anChannel16.WindowSize = 10;
            this.pv2.AnCh = anChannel16;
            this.pv2.AnChName = "CodeTesterAnalogRead:2";
            this.pv2.Axis = 0;
            this.pv2.BackColor = System.Drawing.Color.Transparent;
            this.pv2.DecimalPos = 0;
            this.pv2.DigCount = 6;
            this.pv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv2.Location = new System.Drawing.Point(798, 382);
            this.pv2.Margin = new System.Windows.Forms.Padding(5);
            this.pv2.Max = 1D;
            this.pv2.Min = 0D;
            this.pv2.Name = "pv2";
            this.pv2.PlotTraceName = "AirFlowRate";
            this.pv2.Size = new System.Drawing.Size(251, 99);
            this.pv2.TabIndex = 4;
            this.pv2.Tag = "Barometeric Press (Pa)";
            this.pv2.Value = 32D;
            // 
            // textBoxInDoor
            // 
            this.textBoxInDoor.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxInDoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInDoor.Location = new System.Drawing.Point(13, 380);
            this.textBoxInDoor.Name = "textBoxInDoor";
            this.textBoxInDoor.Size = new System.Drawing.Size(255, 103);
            this.textBoxInDoor.TabIndex = 7;
            this.textBoxInDoor.Text = "";
            // 
            // textBoxOutDoor
            // 
            this.textBoxOutDoor.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxOutDoor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutDoor.Location = new System.Drawing.Point(1057, 380);
            this.textBoxOutDoor.Name = "textBoxOutDoor";
            this.textBoxOutDoor.Size = new System.Drawing.Size(255, 103);
            this.textBoxOutDoor.TabIndex = 7;
            this.textBoxOutDoor.Text = "  ";
            this.textBoxOutDoor.WordWrap = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.buttonAdd5Min, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonResetStbTime, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonPowerCT, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(796, 489);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(255, 36);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // buttonAdd5Min
            // 
            this.buttonAdd5Min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd5Min.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd5Min.Name = "buttonAdd5Min";
            this.buttonAdd5Min.Size = new System.Drawing.Size(79, 30);
            this.buttonAdd5Min.TabIndex = 1;
            this.buttonAdd5Min.Text = "Add 5 min";
            this.buttonAdd5Min.UseVisualStyleBackColor = true;
            this.buttonAdd5Min.Click += new System.EventHandler(this.ButtonAdd5Min_Click);
            // 
            // buttonResetStbTime
            // 
            this.buttonResetStbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonResetStbTime.Location = new System.Drawing.Point(88, 3);
            this.buttonResetStbTime.Name = "buttonResetStbTime";
            this.buttonResetStbTime.Size = new System.Drawing.Size(79, 30);
            this.buttonResetStbTime.TabIndex = 0;
            this.buttonResetStbTime.Text = "Reset Stability Period";
            this.buttonResetStbTime.UseVisualStyleBackColor = true;
            this.buttonResetStbTime.Click += new System.EventHandler(this.ButtonResetStbTime_Click);
            // 
            // buttonPowerCT
            // 
            this.buttonPowerCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPowerCT.Location = new System.Drawing.Point(173, 3);
            this.buttonPowerCT.Name = "buttonPowerCT";
            this.buttonPowerCT.Size = new System.Drawing.Size(79, 30);
            this.buttonPowerCT.TabIndex = 1;
            this.buttonPowerCT.Text = "Power CT";
            this.buttonPowerCT.UseVisualStyleBackColor = true;
            this.buttonPowerCT.Click += new System.EventHandler(this.buttonPowerCT_Click);
            // 
            // TextBoxSample
            // 
            this.TextBoxSample.BackColor = System.Drawing.Color.SteelBlue;
            this.TextBoxSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSample.Location = new System.Drawing.Point(535, 380);
            this.TextBoxSample.Name = "TextBoxSample";
            this.TextBoxSample.Size = new System.Drawing.Size(255, 103);
            this.TextBoxSample.TabIndex = 9;
            this.TextBoxSample.Text = "";
            // 
            // timerRun
            // 
            this.timerRun.Interval = 1000;
            this.timerRun.Tick += new System.EventHandler(this.timerRun_Tick);
            // 
            // netResize1
            // 
            this.netResize1.ParentControl = this;
            this.netResize1.BeforeControlResize += new Softgroup.NetResize.NetResize.BeforeControlResizeEventHandler(this.NetResize1_BeforeControlResize);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // frmMainDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1337, 824);
            this.Controls.Add(this.tableLayoutPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainDisp";
            this.Text = "Air Conditioning Test Unit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainDisp_Load);
            this.Resize += new System.EventHandler(this.frmMainDisp_Resize);
            this.Controls.SetChildIndex(this.tableLayoutPanel4, 0);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.netResize1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private EazyLab.Instrumentation.WF40.Combined.PV pvInDoorDBT;
        private EazyLab.Instrumentation.WF40.Combined.PV pv5;
        private EazyLab.Instrumentation.WF40.Combined.PV pvInDoorWbt;
        private EazyLab.Instrumentation.Standard.Led ledInDoor;
        private EazyLab.Instrumentation.WF40.Combined.PV pvOutDoorDbt;
        private EazyLab.Instrumentation.WF40.Combined.PV pv7;
        private EazyLab.Instrumentation.WF40.Combined.PV pvOutDoorWbt;
        private EazyLab.Instrumentation.WF40.Combined.PV pv15;
        private EazyLab.Instrumentation.WF40.Combined.PV pv9;
        private EazyLab.Instrumentation.WF40.Combined.PV pv14;
        private EazyLab.Instrumentation.WF40.Combined.PV pv13;
        private EazyLab.Instrumentation.WF40.Combined.PV pv11;
        private EazyLab.Instrumentation.WF40.Combined.PV pv12;
        private EazyLab.Instrumentation.Standard.Led ledSample;
        private EazyLab.Instrumentation.Standard.Led led1;
        private System.Windows.Forms.Timer timerRun;
        private Syncfusion.Windows.Forms.Tools.GradientLabel glInDoor;
        private Syncfusion.Windows.Forms.Tools.GradientLabel glSample;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gloutDoor;
        private EazyLab.Instrumentation.WF40.Combined.PV pv4;
        private EazyLab.Instrumentation.WF40.Combined.PV pv6;
        private EazyLab.Instrumentation.WF40.Combined.PV pvCoolingCapacity;
        private EazyLab.Instrumentation.WF40.Combined.PV pvAirFlow;
        private EazyLab.Instrumentation.WF40.Combined.PV pv2;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label2;
        private Softgroup.NetResize.NetResize netResize1;
        private System.Windows.Forms.Button buttonResetStbTime;
        private System.Windows.Forms.Button buttonAdd5Min;
        private System.Windows.Forms.RichTextBox textBoxInDoor;
        private System.Windows.Forms.RichTextBox textBoxOutDoor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RichTextBox TextBoxSample;
        private System.Windows.Forms.Button buttonPowerCT;
        private System.Windows.Forms.Timer timer1;
    }
}