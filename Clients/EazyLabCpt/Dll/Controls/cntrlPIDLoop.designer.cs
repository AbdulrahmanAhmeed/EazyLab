namespace EazyLab.Equipments.Controls
{
    partial class cntrlPIDLoop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPGain = new System.Windows.Forms.Label();
            this.lblIGain = new System.Windows.Forms.Label();
            this.lblDGain = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbOnOff = new EazyLab.Instrumentation.Standard.ToggleButton();
            this.btSave = new System.Windows.Forms.Button();
            this.bAutoTune = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.nudScanningTime = new EazyLab.Instrumentation.Standard.DoubleUpDown();
            this.nudD = new EazyLab.Instrumentation.Standard.DoubleUpDown();
            this.nudI = new EazyLab.Instrumentation.Standard.DoubleUpDown();
            this.nudP = new EazyLab.Instrumentation.Standard.DoubleUpDown();
            this.ledChangeIndicator = new EazyLab.Instrumentation.Standard.Led();
            this.labelStatus = new EazyLab.Instrumentation.Standard.Label();
            this.nudSetPoint = new System.Windows.Forms.NumericUpDown();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanningTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetPoint)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.54545F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPGain, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIGain, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDGain, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nudScanningTime, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudD, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudI, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudP, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ledChangeIndicator, 9, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelStatus, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nudSetPoint, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 17);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 119);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Period (mSec)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "SP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPGain
            // 
            this.lblPGain.AutoSize = true;
            this.lblPGain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPGain.Location = new System.Drawing.Point(145, 0);
            this.lblPGain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPGain.Name = "lblPGain";
            this.lblPGain.Size = new System.Drawing.Size(134, 18);
            this.lblPGain.TabIndex = 1;
            this.lblPGain.Text = "PG";
            this.lblPGain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIGain
            // 
            this.lblIGain.AutoSize = true;
            this.lblIGain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGain.Location = new System.Drawing.Point(288, 0);
            this.lblIGain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIGain.Name = "lblIGain";
            this.lblIGain.Size = new System.Drawing.Size(151, 18);
            this.lblIGain.TabIndex = 1;
            this.lblIGain.Text = "IG";
            this.lblIGain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDGain
            // 
            this.lblDGain.AutoSize = true;
            this.lblDGain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDGain.Location = new System.Drawing.Point(448, 0);
            this.lblDGain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDGain.Name = "lblDGain";
            this.lblDGain.Size = new System.Drawing.Size(121, 18);
            this.lblDGain.TabIndex = 1;
            this.lblDGain.Text = "DG";
            this.lblDGain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 9);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.19847F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.87023F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.74046F));
            this.tableLayoutPanel2.Controls.Add(this.tbOnOff, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btSave, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bAutoTune, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSetting, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(703, 35);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // tbOnOff
            // 
            this.tbOnOff.BackColor = System.Drawing.Color.SlateGray;
            this.tbOnOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbOnOff.Location = new System.Drawing.Point(447, 3);
            this.tbOnOff.Name = "tbOnOff";
            this.tbOnOff.OffColor = System.Drawing.Color.SlateGray;
            this.tbOnOff.OffText = "Off";
            this.tbOnOff.OnColor = System.Drawing.Color.LightBlue;
            this.tbOnOff.OnText = "On";
            this.tbOnOff.Size = new System.Drawing.Size(253, 29);
            this.tbOnOff.State = false;
            this.tbOnOff.TabIndex = 8;
            this.tbOnOff.Text = "Off";
            this.tbOnOff.UseVisualStyleBackColor = false;
            this.tbOnOff.Click += new System.EventHandler(this.tbOnOff_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(236, 3);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(205, 29);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // bAutoTune
            // 
            this.bAutoTune.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bAutoTune.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAutoTune.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAutoTune.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAutoTune.Location = new System.Drawing.Point(42, 2);
            this.bAutoTune.Margin = new System.Windows.Forms.Padding(2);
            this.bAutoTune.Name = "bAutoTune";
            this.bAutoTune.Size = new System.Drawing.Size(189, 31);
            this.bAutoTune.TabIndex = 2;
            this.bAutoTune.Text = "AutoTune";
            this.bAutoTune.UseVisualStyleBackColor = false;
            this.bAutoTune.Click += new System.EventHandler(this.bAutoTune_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetting.Image = global::EazyLab.Equipments.Properties.Resources.Settings___10;
            this.buttonSetting.Location = new System.Drawing.Point(3, 3);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(34, 29);
            this.buttonSetting.TabIndex = 9;
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // nudScanningTime
            // 
            this.nudScanningTime.AutoSize = true;
            this.nudScanningTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudScanningTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudScanningTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F);
            this.nudScanningTime.Location = new System.Drawing.Point(578, 20);
            this.nudScanningTime.Margin = new System.Windows.Forms.Padding(2);
            this.nudScanningTime.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudScanningTime.Name = "nudScanningTime";
            this.nudScanningTime.Size = new System.Drawing.Size(129, 23);
            this.nudScanningTime.TabIndex = 5;
            this.nudScanningTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudScanningTime.Value = 0D;
            this.nudScanningTime.ValueChanged += new System.EventHandler(this.nudScanningTime_ValueChanged);
            // 
            // nudD
            // 
            this.nudD.AutoSize = true;
            this.nudD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudD.DecimalPlaces = 5;
            this.nudD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F);
            this.nudD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.nudD.Location = new System.Drawing.Point(448, 20);
            this.nudD.Margin = new System.Windows.Forms.Padding(2);
            this.nudD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudD.Name = "nudD";
            this.nudD.Size = new System.Drawing.Size(121, 23);
            this.nudD.TabIndex = 0;
            this.nudD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudD.Value = 0D;
            this.nudD.ValueChanged += new System.EventHandler(this.nudD_ValueChanged);
            // 
            // nudI
            // 
            this.nudI.AutoSize = true;
            this.nudI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudI.DecimalPlaces = 7;
            this.nudI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F);
            this.nudI.Increment = new decimal(new int[] {
            1,
            0,
            0,
            458752});
            this.nudI.Location = new System.Drawing.Point(288, 20);
            this.nudI.Margin = new System.Windows.Forms.Padding(2);
            this.nudI.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudI.Name = "nudI";
            this.nudI.Size = new System.Drawing.Size(151, 23);
            this.nudI.TabIndex = 0;
            this.nudI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudI.Value = 0D;
            this.nudI.ValueChanged += new System.EventHandler(this.nudI_ValueChanged);
            // 
            // nudP
            // 
            this.nudP.AutoSize = true;
            this.nudP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudP.DecimalPlaces = 5;
            this.nudP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F);
            this.nudP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nudP.Location = new System.Drawing.Point(145, 20);
            this.nudP.Margin = new System.Windows.Forms.Padding(2);
            this.nudP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudP.Name = "nudP";
            this.nudP.Size = new System.Drawing.Size(134, 23);
            this.nudP.TabIndex = 0;
            this.nudP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudP.Value = 0D;
            this.nudP.ValueChanged += new System.EventHandler(this.nudP_ValueChanged);
            // 
            // ledChangeIndicator
            // 
            this.ledChangeIndicator.LoadingBegin();
            this.ledChangeIndicator.AutoFont = false;
            this.ledChangeIndicator.BlinkerRate = 10;
            this.ledChangeIndicator.Location = new System.Drawing.Point(712, 47);
            this.ledChangeIndicator.Name = "ledChangeIndicator";
            this.ledChangeIndicator.Size = new System.Drawing.Size(37, 35);
            this.ledChangeIndicator.SnapShotTransparent = true;
            this.ledChangeIndicator.Value.EventsEnabled = false;
            this.ledChangeIndicator.LoadingEnd();
            // 
            // labelStatus
            // 
            this.labelStatus.LoadingBegin();
            this.labelStatus.AutoFont = false;
            this.tableLayoutPanel1.SetColumnSpan(this.labelStatus, 10);
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.10154F);
            this.labelStatus.Location = new System.Drawing.Point(3, 88);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(751, 28);
            this.labelStatus.Text = "Current Status";
            this.labelStatus.LoadingEnd();
            // 
            // nudSetPoint
            // 
            this.nudSetPoint.DecimalPlaces = 1;
            this.nudSetPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSetPoint.Location = new System.Drawing.Point(3, 21);
            this.nudSetPoint.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSetPoint.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudSetPoint.Name = "nudSetPoint";
            this.nudSetPoint.Size = new System.Drawing.Size(132, 22);
            this.nudSetPoint.TabIndex = 11;
            this.nudSetPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSetPoint.ValueChanged += new System.EventHandler(this.nudSetPoint_ValueChanged);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox.Controls.Add(this.tableLayoutPanel1);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox.Size = new System.Drawing.Size(761, 138);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "PIDLoop";
            // 
            // cntrlPIDLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cntrlPIDLoop";
            this.Size = new System.Drawing.Size(761, 138);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudScanningTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetPoint)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Instrumentation.Standard.DoubleUpDown nudI;
        private Instrumentation.Standard.DoubleUpDown nudP;
        private Instrumentation.Standard.DoubleUpDown nudD;
        private System.Windows.Forms.Label lblIGain;
        private System.Windows.Forms.Label lblDGain;
        private System.Windows.Forms.Label lblPGain;
        private System.Windows.Forms.Button bAutoTune;

        public string Lable { set => groupBox.Text = value; get => groupBox.Text; }
        public double PGain { set => nudP.Value = value; get => nudP.Value; }
        public double IGain { set => nudI.Value = value; get => nudI.Value; }
        public double DGain { set => nudD.Value = value; get => nudD.Value; }
        public double SetPoint { set => nudSetPoint.Value = (decimal)value; get => (double)nudSetPoint.Value; }
        public int ScanningTime { set => nudScanningTime.Value = value; get => (int)nudScanningTime.Value; }
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Instrumentation.Standard.DoubleUpDown nudScanningTime;
        private System.Windows.Forms.Button btSave;
        private EazyLab.Instrumentation.Standard.ToggleButton tbOnOff;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonSetting;
        private Instrumentation.Standard.Led ledChangeIndicator;
        private System.Windows.Forms.NumericUpDown nudSetPoint;
        private Instrumentation.Standard.Label labelStatus;
    }
}
