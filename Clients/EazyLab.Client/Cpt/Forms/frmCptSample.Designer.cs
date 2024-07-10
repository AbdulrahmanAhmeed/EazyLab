namespace EazyLab.Cpt.Forms
{
    partial class frmCptSample
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
            EazyLab.Classes.PlotChannelTrace plotChannelTrace1 = new EazyLab.Classes.PlotChannelTrace();
            EazyLab.Classes.PlotChannelTrace plotChannelTrace2 = new EazyLab.Classes.PlotChannelTrace();
            EazyLab.Classes.PlotChannelTrace plotChannelTrace3 = new EazyLab.Classes.PlotChannelTrace();
            EazyLab.Classes.PlotDataCursorXY plotDataCursorXY1 = new EazyLab.Classes.PlotDataCursorXY();
            EazyLab.Classes.PlotDataView plotDataView1 = new EazyLab.Classes.PlotDataView();
            EazyLab.Classes.PlotLabelBasic plotLabelBasic1 = new EazyLab.Classes.PlotLabelBasic();
            EazyLab.Classes.PlotLegendBasic plotLegendBasic1 = new EazyLab.Classes.PlotLegendBasic();
            EazyLab.Classes.PlotTableGrid plotTableGrid1 = new EazyLab.Classes.PlotTableGrid();
            EazyLab.Classes.PlotXAxis plotXAxis1 = new EazyLab.Classes.PlotXAxis();
            EazyLab.Classes.PlotYAxis plotYAxis1 = new EazyLab.Classes.PlotYAxis();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveGeneratedSamples = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new EazyLab.Instrumentation.Standard.Label();
            this.dudDelayTime = new EazyLab.Instrumentation.Standard.DoubleUpDown();
            this.label7 = new EazyLab.Instrumentation.Standard.Label();
            this.dudOverCurrent = new EazyLab.Instrumentation.Standard.DoubleUpDown();
            this.label1 = new EazyLab.Instrumentation.Standard.Label();
            this.dudInrushCurrent = new EazyLab.Instrumentation.Standard.DoubleUpDown();
            this.cbModelName = new System.Windows.Forms.ComboBox();
            this.btModelDelete = new System.Windows.Forms.Button();
            this.btModelSave = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nudStartCount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new EazyLab.Instrumentation.Standard.Label();
            this.cbPrefix = new System.Windows.Forms.ComboBox();
            this.label11 = new EazyLab.Instrumentation.Standard.Label();
            this.label10 = new EazyLab.Instrumentation.Standard.Label();
            this.label9 = new EazyLab.Instrumentation.Standard.Label();
            this.cbSuffix = new System.Windows.Forms.ComboBox();
            this.groupBoxPoint = new System.Windows.Forms.GroupBox();
            this.btnDeleteTempZone = new System.Windows.Forms.Button();
            this.btnAddTempZone = new System.Windows.Forms.Button();
            this.label4 = new EazyLab.Instrumentation.Standard.Label();
            this.label3 = new EazyLab.Instrumentation.Standard.Label();
            this.label2 = new EazyLab.Instrumentation.Standard.Label();
            this.dudTime = new EazyLab.Instrumentation.Standard.DoubleUpDown();
            this.dudTemp = new EazyLab.Instrumentation.Standard.DoubleUpDown();
            this.dudDeviation = new EazyLab.Instrumentation.Standard.DoubleUpDown();
            this.plot = new EazyLab.Instrumentation.Plotting.Plot();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnNewProfile = new System.Windows.Forms.Button();
            this.btnProfileDelete = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.nudProfileId = new System.Windows.Forms.NumericUpDown();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.label13 = new EazyLab.Instrumentation.Standard.Label();
            this.label5 = new EazyLab.Instrumentation.Standard.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dudDelayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dudOverCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dudInrushCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartCount)).BeginInit();
            this.groupBoxPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dudTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dudTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dudDeviation)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProfileId)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveGeneratedSamples);
            this.groupBox3.Controls.Add(this.nudQuantity);
            this.groupBox3.Controls.Add(this.btnGenerate);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.nudStartCount);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cbPrefix);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbSuffix);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 401);
            this.groupBox3.Name = "groupBox3";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox3, 2);
            this.groupBox3.Size = new System.Drawing.Size(565, 464);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sample Serial No.s";
            // 
            // btnSaveGeneratedSamples
            // 
            this.btnSaveGeneratedSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGeneratedSamples.Location = new System.Drawing.Point(275, 423);
            this.btnSaveGeneratedSamples.Name = "btnSaveGeneratedSamples";
            this.btnSaveGeneratedSamples.Size = new System.Drawing.Size(108, 32);
            this.btnSaveGeneratedSamples.TabIndex = 8;
            this.btnSaveGeneratedSamples.Text = "Save";
            this.btnSaveGeneratedSamples.UseVisualStyleBackColor = true;
            this.btnSaveGeneratedSamples.Click += new System.EventHandler(this.btnSaveGeneratedSamples_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(359, 357);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(65, 26);
            this.nudQuantity.TabIndex = 15;
            this.nudQuantity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(440, 426);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(96, 32);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dudDelayTime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dudOverCurrent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dudInrushCurrent);
            this.groupBox1.Controls.Add(this.cbModelName);
            this.groupBox1.Controls.Add(this.btModelDelete);
            this.groupBox1.Controls.Add(this.btModelSave);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(574, 401);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(294, 464);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // label8
            // 
            this.label8.LoadingBegin();
            this.label8.AutoFont = false;
            this.label8.AutoSize = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 28);
            this.label8.Text = "Delay Time(min):";
            this.label8.LoadingEnd();
            // 
            // dudDelayTime
            // 
            this.dudDelayTime.DecimalPlaces = 1;
            this.dudDelayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudDelayTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.dudDelayTime.Location = new System.Drawing.Point(203, 373);
            this.dudDelayTime.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.dudDelayTime.Name = "dudDelayTime";
            this.dudDelayTime.Size = new System.Drawing.Size(74, 26);
            this.dudDelayTime.TabIndex = 13;
            this.dudDelayTime.Value = 3D;
            // 
            // label7
            // 
            this.label7.LoadingBegin();
            this.label7.AutoFont = false;
            this.label7.AutoSize = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 24);
            this.label7.Text = "Over Current(A):";
            this.label7.LoadingEnd();
            // 
            // dudOverCurrent
            // 
            this.dudOverCurrent.DecimalPlaces = 1;
            this.dudOverCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudOverCurrent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.dudOverCurrent.Location = new System.Drawing.Point(203, 341);
            this.dudOverCurrent.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.dudOverCurrent.Name = "dudOverCurrent";
            this.dudOverCurrent.Size = new System.Drawing.Size(74, 26);
            this.dudOverCurrent.TabIndex = 13;
            this.dudOverCurrent.Value = 10D;
            // 
            // label1
            // 
            this.label1.LoadingBegin();
            this.label1.AutoFont = false;
            this.label1.AutoSize = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.Text = "Inrush Current(A):";
            this.label1.LoadingEnd();
            // 
            // dudInrushCurrent
            // 
            this.dudInrushCurrent.DecimalPlaces = 1;
            this.dudInrushCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudInrushCurrent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.dudInrushCurrent.Location = new System.Drawing.Point(203, 309);
            this.dudInrushCurrent.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.dudInrushCurrent.Name = "dudInrushCurrent";
            this.dudInrushCurrent.Size = new System.Drawing.Size(74, 26);
            this.dudInrushCurrent.TabIndex = 13;
            this.dudInrushCurrent.Value = 1D;
            // 
            // cbModelName
            // 
            this.cbModelName.FormattingEnabled = true;
            this.cbModelName.Location = new System.Drawing.Point(16, 30);
            this.cbModelName.Name = "cbModelName";
            this.cbModelName.Size = new System.Drawing.Size(261, 21);
            this.cbModelName.TabIndex = 11;
            this.cbModelName.SelectedIndexChanged += new System.EventHandler(this.cbModelName_SelectedIndexChanged);
            // 
            // btModelDelete
            // 
            this.btModelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModelDelete.Location = new System.Drawing.Point(164, 405);
            this.btModelDelete.Name = "btModelDelete";
            this.btModelDelete.Size = new System.Drawing.Size(113, 31);
            this.btModelDelete.TabIndex = 8;
            this.btModelDelete.Text = "Del";
            this.btModelDelete.UseVisualStyleBackColor = true;
            this.btModelDelete.Click += new System.EventHandler(this.btModelDelete_Click);
            // 
            // btModelSave
            // 
            this.btModelSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModelSave.Location = new System.Drawing.Point(16, 405);
            this.btModelSave.Name = "btModelSave";
            this.btModelSave.Size = new System.Drawing.Size(122, 31);
            this.btModelSave.TabIndex = 8;
            this.btModelSave.Text = "Save";
            this.btModelSave.UseVisualStyleBackColor = true;
            this.btModelSave.Click += new System.EventHandler(this.btModelSave_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Blue;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(3, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 434);
            this.listBox1.TabIndex = 0;
            // 
            // nudStartCount
            // 
            this.nudStartCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStartCount.Location = new System.Drawing.Point(359, 325);
            this.nudStartCount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStartCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStartCount.Name = "nudStartCount";
            this.nudStartCount.Size = new System.Drawing.Size(132, 26);
            this.nudStartCount.TabIndex = 15;
            this.nudStartCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.LoadingBegin();
            this.label12.AutoFont = false;
            this.label12.AutoSize = false;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(300, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 26);
            this.label12.Text = "Qty :";
            this.label12.LoadingEnd();
            // 
            // cbPrefix
            // 
            this.cbPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrefix.FormattingEnabled = true;
            this.cbPrefix.Location = new System.Drawing.Point(359, 257);
            this.cbPrefix.Name = "cbPrefix";
            this.cbPrefix.Size = new System.Drawing.Size(132, 28);
            this.cbPrefix.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.LoadingBegin();
            this.label11.AutoFont = false;
            this.label11.AutoSize = false;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(296, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 26);
            this.label11.Text = "Start:";
            this.label11.LoadingEnd();
            // 
            // label10
            // 
            this.label10.LoadingBegin();
            this.label10.AutoFont = false;
            this.label10.AutoSize = false;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(281, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 27);
            this.label10.Text = "Suffix:";
            this.label10.TextChanged += new System.EventHandler(this.label10_TextChanged);
            this.label10.LoadingEnd();
            // 
            // label9
            // 
            this.label9.LoadingBegin();
            this.label9.AutoFont = false;
            this.label9.AutoSize = false;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(275, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 28);
            this.label9.Text = "Prefix:";
            this.label9.LoadingEnd();
            // 
            // cbSuffix
            // 
            this.cbSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuffix.FormattingEnabled = true;
            this.cbSuffix.Location = new System.Drawing.Point(359, 291);
            this.cbSuffix.Name = "cbSuffix";
            this.cbSuffix.Size = new System.Drawing.Size(132, 28);
            this.cbSuffix.TabIndex = 11;
            // 
            // groupBoxPoint
            // 
            this.groupBoxPoint.Controls.Add(this.btnDeleteTempZone);
            this.groupBoxPoint.Controls.Add(this.btnAddTempZone);
            this.groupBoxPoint.Controls.Add(this.label4);
            this.groupBoxPoint.Controls.Add(this.label3);
            this.groupBoxPoint.Controls.Add(this.label2);
            this.groupBoxPoint.Controls.Add(this.dudTime);
            this.groupBoxPoint.Controls.Add(this.dudTemp);
            this.groupBoxPoint.Controls.Add(this.dudDeviation);
            this.groupBoxPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPoint.Location = new System.Drawing.Point(874, 401);
            this.groupBoxPoint.Name = "groupBoxPoint";
            this.groupBoxPoint.Size = new System.Drawing.Size(357, 214);
            this.groupBoxPoint.TabIndex = 3;
            this.groupBoxPoint.TabStop = false;
            this.groupBoxPoint.Text = "Point";
            // 
            // btnDeleteTempZone
            // 
            this.btnDeleteTempZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTempZone.Location = new System.Drawing.Point(192, 167);
            this.btnDeleteTempZone.Name = "btnDeleteTempZone";
            this.btnDeleteTempZone.Size = new System.Drawing.Size(124, 38);
            this.btnDeleteTempZone.TabIndex = 8;
            this.btnDeleteTempZone.Text = "Delete";
            this.btnDeleteTempZone.UseVisualStyleBackColor = true;
            this.btnDeleteTempZone.Click += new System.EventHandler(this.btnDeleteTempZone_Click);
            // 
            // btnAddTempZone
            // 
            this.btnAddTempZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTempZone.Location = new System.Drawing.Point(33, 167);
            this.btnAddTempZone.Name = "btnAddTempZone";
            this.btnAddTempZone.Size = new System.Drawing.Size(122, 38);
            this.btnAddTempZone.TabIndex = 8;
            this.btnAddTempZone.Text = "Add";
            this.btnAddTempZone.UseVisualStyleBackColor = true;
            this.btnAddTempZone.Click += new System.EventHandler(this.btnAddTempZone_Click);
            // 
            // label4
            // 
            this.label4.LoadingBegin();
            this.label4.AutoFont = false;
            this.label4.AutoSize = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 39);
            this.label4.Text = "Deviation(C°):";
            this.label4.LoadingEnd();
            // 
            // label3
            // 
            this.label3.LoadingBegin();
            this.label3.AutoFont = false;
            this.label3.AutoSize = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 39);
            this.label3.Text = "Temp(C°):";
            this.label3.LoadingEnd();
            // 
            // label2
            // 
            this.label2.LoadingBegin();
            this.label2.AutoFont = false;
            this.label2.AutoSize = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 39);
            this.label2.Text = "Time(Min):";
            this.label2.LoadingEnd();
            // 
            // dudTime
            // 
            this.dudTime.DecimalPlaces = 2;
            this.dudTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudTime.Location = new System.Drawing.Point(219, 30);
            this.dudTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.dudTime.Name = "dudTime";
            this.dudTime.Size = new System.Drawing.Size(97, 31);
            this.dudTime.TabIndex = 1;
            this.dudTime.Value = 0D;
            // 
            // dudTemp
            // 
            this.dudTemp.DecimalPlaces = 2;
            this.dudTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudTemp.Location = new System.Drawing.Point(219, 82);
            this.dudTemp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.dudTemp.Name = "dudTemp";
            this.dudTemp.Size = new System.Drawing.Size(97, 31);
            this.dudTemp.TabIndex = 1;
            this.dudTemp.Value = 0D;
            // 
            // dudDeviation
            // 
            this.dudDeviation.DecimalPlaces = 2;
            this.dudDeviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudDeviation.Location = new System.Drawing.Point(219, 127);
            this.dudDeviation.Name = "dudDeviation";
            this.dudDeviation.Size = new System.Drawing.Size(97, 31);
            this.dudDeviation.TabIndex = 1;
            this.dudDeviation.Value = 0D;
            // 
            // plot
            // 
            this.plot.LoadingBegin();
            this.plot.AutoFont = false;
            this.plot.Background.GradientStartColor = System.Drawing.Color.DeepSkyBlue;
            this.plot.Background.GradientStopColor = System.Drawing.Color.Blue;
            this.plot.Background.Visible = true;
            plotChannelTrace1.Color = System.Drawing.Color.Red;
            plotChannelTrace1.DrawCustomDataPointAttributes = true;
            plotChannelTrace1.Markers.Size = 6;
            plotChannelTrace1.Markers.Visible = true;
            plotChannelTrace1.MarkersTurnOffLimit = 0;
            plotChannelTrace1.Name = "TempPlus";
            plotChannelTrace1.TitleText = "+Temp";
            plotChannelTrace1.Trace.Thickness = 3D;
            plotChannelTrace2.Color = System.Drawing.Color.Blue;
            plotChannelTrace2.Markers.Size = 6;
            plotChannelTrace2.Markers.Style = EazyLab.Types.PlotMarkerStyle.Square;
            plotChannelTrace2.Markers.Visible = true;
            plotChannelTrace2.MarkersTurnOffLimit = 0;
            plotChannelTrace2.Name = "Temp";
            plotChannelTrace2.TitleText = "Temp";
            plotChannelTrace2.Trace.Thickness = 3D;
            plotChannelTrace3.Color = System.Drawing.Color.Lime;
            plotChannelTrace3.Markers.Size = 6;
            plotChannelTrace3.Markers.Style = EazyLab.Types.PlotMarkerStyle.TriangleUp;
            plotChannelTrace3.Markers.Visible = true;
            plotChannelTrace3.MarkersTurnOffLimit = 0;
            plotChannelTrace3.Name = "TempMinus";
            plotChannelTrace3.TitleText = "-Temp";
            plotChannelTrace3.Trace.Thickness = 3D;
            this.plot.Channels.Add(plotChannelTrace1);
            this.plot.Channels.Add(plotChannelTrace2);
            this.plot.Channels.Add(plotChannelTrace3);
            this.tableLayoutPanel2.SetColumnSpan(this.plot, 3);
            plotDataCursorXY1.ClippingStyle = EazyLab.Types.PlotClippingStyle.Axes;
            plotDataCursorXY1.Hint.Fill.Pen.Color = System.Drawing.SystemColors.InfoText;
            plotDataCursorXY1.Name = "Data-Cursor 1";
            plotDataCursorXY1.Style = EazyLab.Types.PlotDataCursorMultipleStyle.ValueX;
            plotDataCursorXY1.TitleText = "Data-Cursor 1";
            plotDataCursorXY1.UserCanEdit = false;
            plotDataCursorXY1.Visible = true;
            this.plot.DataCursors.Add(plotDataCursorXY1);
            plotDataView1.Name = "Data-View 1";
            plotDataView1.TitleText = "Data-View 1";
            this.plot.DataViews.Add(plotDataView1);
            this.plot.Dock = System.Windows.Forms.DockStyle.Fill;
            plotLabelBasic1.DockOrder = 0;
            plotLabelBasic1.Name = "Label 1";
            plotLabelBasic1.Text = "Profile";
            plotLabelBasic1.Visible = false;
            this.plot.Labels.Add(plotLabelBasic1);
            plotLegendBasic1.DockOrder = 0;
            plotLegendBasic1.Name = "Legend 1";
            plotLegendBasic1.TitleText = "Legend 1";
            this.plot.Legends.Add(plotLegendBasic1);
            this.plot.Location = new System.Drawing.Point(3, 3);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(1228, 392);
            this.plot.TabIndex = 0;
            plotTableGrid1.ColTitlesVisible = true;
            plotTableGrid1.DataRowCount = 7;
            plotTableGrid1.DockOrder = 1;
            plotTableGrid1.Name = "Table 1";
            plotTableGrid1.TitleText = "Table 1";
            plotTableGrid1.Visible = false;
            this.plot.Tables.Add(plotTableGrid1);
            plotXAxis1.DockOrder = 0;
            plotXAxis1.Name = "X-Axis 1";
            plotXAxis1.Title.Text = "X-Axis 1";
            this.plot.XAxes.Add(plotXAxis1);
            plotYAxis1.DockOrder = 0;
            plotYAxis1.Name = "Y-Axis 1";
            plotYAxis1.Title.Text = "Y-Axis 1";
            this.plot.YAxes.Add(plotYAxis1);
            this.plot.CursorChanged += new System.EventHandler(this.plot_CursorChanged);
            this.plot.Click += new System.EventHandler(this.plot_Click);
            this.plot.DoubleClick += new System.EventHandler(this.plot_DoubleClick);
            this.plot.LoadingEnd();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxPoint, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.plot, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1254, 868);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnCopy);
            this.groupBox2.Controls.Add(this.btnNewProfile);
            this.groupBox2.Controls.Add(this.btnProfileDelete);
            this.groupBox2.Controls.Add(this.btnSaveProfile);
            this.groupBox2.Controls.Add(this.nudProfileId);
            this.groupBox2.Controls.Add(this.cbSource);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(874, 621);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 244);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temp. Profile";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(216, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 38);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(216, 121);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(122, 32);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnNewProfile_Click);
            // 
            // btnNewProfile
            // 
            this.btnNewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProfile.Location = new System.Drawing.Point(219, 33);
            this.btnNewProfile.Name = "btnNewProfile";
            this.btnNewProfile.Size = new System.Drawing.Size(122, 38);
            this.btnNewProfile.TabIndex = 8;
            this.btnNewProfile.Text = "New ";
            this.btnNewProfile.UseVisualStyleBackColor = true;
            this.btnNewProfile.Click += new System.EventHandler(this.btnNewProfile_Click);
            // 
            // btnProfileDelete
            // 
            this.btnProfileDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnProfileDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileDelete.Location = new System.Drawing.Point(16, 173);
            this.btnProfileDelete.Name = "btnProfileDelete";
            this.btnProfileDelete.Size = new System.Drawing.Size(151, 38);
            this.btnProfileDelete.TabIndex = 8;
            this.btnProfileDelete.Text = "Del";
            this.btnProfileDelete.UseVisualStyleBackColor = false;
            this.btnProfileDelete.Click += new System.EventHandler(this.btnProfileDelete_Click);
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProfile.Location = new System.Drawing.Point(16, 121);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(151, 32);
            this.btnSaveProfile.TabIndex = 8;
            this.btnSaveProfile.Text = "Save ";
            this.btnSaveProfile.UseVisualStyleBackColor = false;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // nudProfileId
            // 
            this.nudProfileId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProfileId.Location = new System.Drawing.Point(82, 33);
            this.nudProfileId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudProfileId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProfileId.Name = "nudProfileId";
            this.nudProfileId.Size = new System.Drawing.Size(103, 31);
            this.nudProfileId.TabIndex = 2;
            this.nudProfileId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProfileId.ValueChanged += new System.EventHandler(this.nudProfileId_ValueChanged);
            // 
            // cbSource
            // 
            this.cbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(125, 87);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(215, 28);
            this.cbSource.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.LoadingBegin();
            this.label13.AutoFont = false;
            this.label13.AutoSize = false;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 28);
            this.label13.Text = "Source:";
            this.label13.LoadingEnd();
            // 
            // label5
            // 
            this.label5.LoadingBegin();
            this.label5.AutoFont = false;
            this.label5.AutoSize = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 31);
            this.label5.Text = "Id:";
            this.label5.LoadingEnd();
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Blue;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(16, 73);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(261, 199);
            this.listBox2.TabIndex = 16;
            // 
            // frmCptProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1254, 868);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmCptProfile";
            this.Text = " CptT emp Profile";
            this.Load += new System.EventHandler(this.frmCptTempProfile_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dudDelayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dudOverCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dudInrushCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartCount)).EndInit();
            this.groupBoxPoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dudTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dudTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dudDeviation)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudProfileId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbModelName;
        private System.Windows.Forms.Button btModelDelete;
        private System.Windows.Forms.Button btModelSave;
        private System.Windows.Forms.GroupBox groupBoxPoint;
        private System.Windows.Forms.Button btnDeleteTempZone;
        private System.Windows.Forms.Button btnAddTempZone;
        private Instrumentation.Standard.Label label4;
        private Instrumentation.Standard.Label label3;
        private Instrumentation.Standard.Label label2;
        private Instrumentation.Standard.DoubleUpDown dudTime;
        private Instrumentation.Standard.DoubleUpDown dudTemp;
        private Instrumentation.Standard.DoubleUpDown dudDeviation;
        private Instrumentation.Plotting.Plot plot;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private Instrumentation.Standard.Label label1;
        private Instrumentation.Standard.DoubleUpDown dudInrushCurrent;
        private Instrumentation.Standard.Label label7;
        private Instrumentation.Standard.DoubleUpDown dudOverCurrent;
        private Instrumentation.Standard.Label label8;
        private Instrumentation.Standard.DoubleUpDown dudDelayTime;
        private Instrumentation.Standard.Label label9;
        private Instrumentation.Standard.Label label10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Instrumentation.Standard.Label label11;
        private System.Windows.Forms.Button btnSaveGeneratedSamples;
        private Instrumentation.Standard.Label label12;
        private System.Windows.Forms.ComboBox cbSuffix;
        private System.Windows.Forms.ComboBox cbPrefix;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.Button btnProfileDelete;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.NumericUpDown nudProfileId;
        private Instrumentation.Standard.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.NumericUpDown nudStartCount;
        private System.Windows.Forms.ComboBox cbSource;
        private Instrumentation.Standard.Label label13;
        private System.Windows.Forms.ListBox listBox2;
    }
}