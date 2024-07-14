namespace EazyLab.Cpt.Forms
{
    partial class frmCptStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCptStation));
            this.btnSave = new System.Windows.Forms.Button();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxIp = new System.Windows.Forms.MaskedTextBox();
            this.led1 = new EazyLab.Instrumentation.Standard.Led();
            this.nudScanningInterval = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSerialNo = new System.Windows.Forms.ComboBox();
            this.btnConnect = new EazyLab.Instrumentation.Standard.ToggleButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbCalibration = new System.Windows.Forms.GroupBox();
            this.pv1 = new EazyLab.Instrumentation.Standard.PV();
            this.edCalibValue = new EazyLab.Instrumentation.Standard.EditDouble();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnSpan = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.gbChamber = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label8 = new EazyLab.Instrumentation.Standard.Label();
            this.btnSaveChamber = new System.Windows.Forms.Button();
            this.cbWifis = new System.Windows.Forms.ComboBox();
            this.cbDevices = new System.Windows.Forms.ComboBox();
            this.label7 = new EazyLab.Instrumentation.Standard.Label();
            this.label2 = new EazyLab.Instrumentation.Standard.Label();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new EazyLab.Instrumentation.Standard.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.edName = new EazyLab.Instrumentation.Standard.EditDouble();
            this.NudTimeout = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanningInterval)).BeginInit();
            this.gbCalibration.SuspendLayout();
            this.gbChamber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(795, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudId
            // 
            this.nudId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudId.Location = new System.Drawing.Point(382, 294);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(69, 26);
            this.nudId.TabIndex = 1;
            this.nudId.ValueChanged += new System.EventHandler(this.nudId_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Station Id :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "SN. :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btRemove
            // 
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Location = new System.Drawing.Point(529, 387);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(146, 32);
            this.btRemove.TabIndex = 0;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(795, 456);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "IP Address. :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // maskedTextBoxIp
            // 
            this.maskedTextBoxIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxIp.Location = new System.Drawing.Point(487, 29);
            this.maskedTextBoxIp.Mask = "###.###.###.###";
            this.maskedTextBoxIp.Name = "maskedTextBoxIp";
            this.maskedTextBoxIp.Size = new System.Drawing.Size(217, 35);
            this.maskedTextBoxIp.TabIndex = 12;
            this.maskedTextBoxIp.Text = "192168001002";
            // 
            // led1
            // 
            this.led1.LoadingBegin();
            this.led1.AutoFont = false;
            this.led1.Location = new System.Drawing.Point(913, 22);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(54, 49);
            this.led1.LoadingEnd();
            // 
            // nudScanningInterval
            // 
            this.nudScanningInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudScanningInterval.Location = new System.Drawing.Point(618, 294);
            this.nudScanningInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudScanningInterval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudScanningInterval.Name = "nudScanningInterval";
            this.nudScanningInterval.Size = new System.Drawing.Size(85, 26);
            this.nudScanningInterval.TabIndex = 1;
            this.nudScanningInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudScanningInterval.ValueChanged += new System.EventHandler(this.nudScanningInterval_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(480, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Period (mSec) :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbSerialNo
            // 
            this.cbSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSerialNo.FormattingEnabled = true;
            this.cbSerialNo.Location = new System.Drawing.Point(371, 240);
            this.cbSerialNo.Name = "cbSerialNo";
            this.cbSerialNo.Size = new System.Drawing.Size(334, 37);
            this.cbSerialNo.TabIndex = 14;
            this.cbSerialNo.DropDown += new System.EventHandler(this.cbSerialNo_DropDown);
            this.cbSerialNo.SelectionChangeCommitted += new System.EventHandler(this.cbSerialNo_SelectionChangeCommitted);
            this.cbSerialNo.TextChanged += new System.EventHandler(this.cbSerialNo_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Red;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(734, 29);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.OffColor = System.Drawing.Color.Red;
            this.btnConnect.OffText = "Connect";
            this.btnConnect.OnColor = System.Drawing.Color.GreenYellow;
            this.btnConnect.OnText = "Disconnect";
            this.btnConnect.Size = new System.Drawing.Size(160, 36);
            this.btnConnect.State = false;
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(282, 387);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(175, 32);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print BarCode";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(278, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 118);
            this.panel1.TabIndex = 16;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(269, 680);
            this.listBox1.TabIndex = 18;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // gbCalibration
            // 
            this.gbCalibration.Controls.Add(this.pv1);
            this.gbCalibration.Controls.Add(this.edCalibValue);
            this.gbCalibration.Controls.Add(this.btnZero);
            this.gbCalibration.Controls.Add(this.btnSpan);
            this.gbCalibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCalibration.Location = new System.Drawing.Point(734, 77);
            this.gbCalibration.Name = "gbCalibration";
            this.gbCalibration.Size = new System.Drawing.Size(233, 239);
            this.gbCalibration.TabIndex = 21;
            this.gbCalibration.TabStop = false;
            this.gbCalibration.Text = "Calibration";
            // 
            // pv1
            // 
            this.pv1.LoadingBegin();
            this.pv1.AutoFont = true;
            this.pv1.AutoSize = false;
            this.pv1.Calibrated = false;
            this.pv1.Channel = ((EazyLab.Model.AnalogInput)(resources.GetObject("pv1.Channel")));
            this.pv1.ChannelNo = 0;
            this.pv1.EnableContextMenu = true;
            this.pv1.EnableDoubleClick = true;
            this.pv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.pv1.IsHidden = false;
            this.pv1.IsSelectedForPloting = false;
            this.pv1.Location = new System.Drawing.Point(28, 25);
            this.pv1.Name = "pv1";
            this.pv1.Plot = null;
            this.pv1.PlotChannelNamee = null;
            this.pv1.Precision = 2;
            this.pv1.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pv1.Size = new System.Drawing.Size(179, 78);
            this.pv1.TagFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.pv1.TagName = "PV_TagName";
            this.pv1.TagNameGroup = "PV_TagName Group1";
            this.pv1.TagToDigitRatio = ((uint)(30u));
            this.pv1.TextFormatting.Precision = 2;
            this.pv1.TextFormatting.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pv1.Unit = "";
            this.pv1.ValueAsDouble = 0D;
            this.pv1.Visible = false;
            this.pv1.LoadingEnd();
            // 
            // edCalibValue
            // 
            this.edCalibValue.LoadingBegin();
            this.edCalibValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edCalibValue.Location = new System.Drawing.Point(28, 109);
            this.edCalibValue.Name = "edCalibValue";
            this.edCalibValue.Size = new System.Drawing.Size(179, 35);
            this.edCalibValue.TabIndex = 1;
            this.edCalibValue.LoadingEnd();
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(28, 195);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(179, 39);
            this.btnZero.TabIndex = 0;
            this.btnZero.Text = "Zero";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnSpan
            // 
            this.btnSpan.Location = new System.Drawing.Point(28, 150);
            this.btnSpan.Name = "btnSpan";
            this.btnSpan.Size = new System.Drawing.Size(179, 39);
            this.btnSpan.TabIndex = 0;
            this.btnSpan.Text = "Span";
            this.btnSpan.UseVisualStyleBackColor = true;
            this.btnSpan.Click += new System.EventHandler(this.btnSpan_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbStatus.Location = new System.Drawing.Point(269, 660);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(728, 20);
            this.tbStatus.TabIndex = 23;
            // 
            // gbChamber
            // 
            this.gbChamber.Controls.Add(this.tbPassword);
            this.gbChamber.Controls.Add(this.label8);
            this.gbChamber.Controls.Add(this.btnSaveChamber);
            this.gbChamber.Controls.Add(this.cbWifis);
            this.gbChamber.Controls.Add(this.cbDevices);
            this.gbChamber.Controls.Add(this.label7);
            this.gbChamber.Controls.Add(this.label2);
            this.gbChamber.Controls.Add(this.cbComPort);
            this.gbChamber.Controls.Add(this.label1);
            this.gbChamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChamber.Location = new System.Drawing.Point(282, 494);
            this.gbChamber.Name = "gbChamber";
            this.gbChamber.Size = new System.Drawing.Size(668, 160);
            this.gbChamber.TabIndex = 26;
            this.gbChamber.TabStop = false;
            this.gbChamber.Text = "Chamber";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(441, 62);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(221, 26);
            this.tbPassword.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.LoadingBegin();
            this.label8.AutoFont = false;
            this.label8.AutoSize = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(344, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.Text = "Password :";
            this.label8.LoadingEnd();
            // 
            // btnSaveChamber
            // 
            this.btnSaveChamber.Location = new System.Drawing.Point(303, 116);
            this.btnSaveChamber.Name = "btnSaveChamber";
            this.btnSaveChamber.Size = new System.Drawing.Size(163, 34);
            this.btnSaveChamber.TabIndex = 3;
            this.btnSaveChamber.Text = "Save Chamber";
            this.btnSaveChamber.UseVisualStyleBackColor = true;
            this.btnSaveChamber.Click += new System.EventHandler(this.btnSaveChamber_Click);
            // 
            // cbWifis
            // 
            this.cbWifis.FormattingEnabled = true;
            this.cbWifis.Location = new System.Drawing.Point(121, 60);
            this.cbWifis.Name = "cbWifis";
            this.cbWifis.Size = new System.Drawing.Size(217, 28);
            this.cbWifis.TabIndex = 1;
            // 
            // cbDevices
            // 
            this.cbDevices.FormattingEnabled = true;
            this.cbDevices.Location = new System.Drawing.Point(121, 25);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(541, 28);
            this.cbDevices.TabIndex = 1;
            this.cbDevices.DropDown += new System.EventHandler(this.cbDevices_DropDown);
            // 
            // label7
            // 
            this.label7.LoadingBegin();
            this.label7.AutoFont = false;
            this.label7.AutoSize = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.Text = "SSID:";
            this.label7.LoadingEnd();
            // 
            // label2
            // 
            this.label2.LoadingBegin();
            this.label2.AutoFont = false;
            this.label2.AutoSize = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.Text = "Wifi Devices:";
            this.label2.LoadingEnd();
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(206, 120);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(82, 28);
            this.cbComPort.TabIndex = 1;
            this.cbComPort.DropDown += new System.EventHandler(this.cbComPort_DropDown);
            this.cbComPort.SelectedIndexChanged += new System.EventHandler(this.cbComPort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.LoadingBegin();
            this.label1.AutoFont = false;
            this.label1.AutoSize = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.Text = "Scanner Serial Port :";
            this.label1.LoadingEnd();
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(282, 436);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(175, 32);
            this.btReset.TabIndex = 28;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(289, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "IP Address. :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // edName
            // 
            this.edName.LoadingBegin();
            this.edName.Enabled = false;
            this.edName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edName.Location = new System.Drawing.Point(487, 77);
            this.edName.Name = "edName";
            this.edName.Size = new System.Drawing.Size(216, 31);
            this.edName.TabIndex = 30;
            this.edName.LoadingEnd();
            // 
            // NudTimeout
            // 
            this.NudTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudTimeout.Location = new System.Drawing.Point(618, 339);
            this.NudTimeout.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudTimeout.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudTimeout.Name = "NudTimeout";
            this.NudTimeout.Size = new System.Drawing.Size(85, 26);
            this.NudTimeout.TabIndex = 1;
            this.NudTimeout.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NudTimeout.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(486, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "TiimeOut,Sec :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmCptStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 680);
            this.Controls.Add(this.edName);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.gbChamber);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.gbCalibration);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbSerialNo);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.maskedTextBoxIp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NudTimeout);
            this.Controls.Add(this.nudScanningInterval);
            this.Controls.Add(this.nudId);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCptStation";
            this.Text = "Station Configuration  ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCptStation_FormClosed);
            this.Load += new System.EventHandler(this.frmCptStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanningInterval)).EndInit();
            this.gbCalibration.ResumeLayout(false);
            this.gbCalibration.PerformLayout();
            this.gbChamber.ResumeLayout(false);
            this.gbChamber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIp;
        private Instrumentation.Standard.Led led1;
        private System.Windows.Forms.NumericUpDown nudScanningInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSerialNo;
        private Instrumentation.Standard.ToggleButton btnConnect;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox gbCalibration;
        private Instrumentation.Standard.EditDouble edCalibValue;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnSpan;
        private Instrumentation.Standard.PV pv1;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.GroupBox gbChamber;
        private System.Windows.Forms.ComboBox cbComPort;
        private Instrumentation.Standard.Label label1;
        private System.Windows.Forms.Button btnSaveChamber;
        private System.Windows.Forms.ComboBox cbDevices;
        private Instrumentation.Standard.Label label2;
        private System.Windows.Forms.ComboBox cbWifis;
        private Instrumentation.Standard.Label label7;
        private System.Windows.Forms.TextBox tbPassword;
        private Instrumentation.Standard.Label label8;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label label9;
        private Instrumentation.Standard.EditDouble edName;
        private System.Windows.Forms.NumericUpDown NudTimeout;
        private System.Windows.Forms.Label label10;
    }
}