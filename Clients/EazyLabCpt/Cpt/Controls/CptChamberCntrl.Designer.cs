using EazyLab.Classes;
namespace EazyLab.Cpt.Controls
{
    partial class CptChamberCntrl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CptChamberCntrl));
            EazyLab.Classes.PlotDataCursorXY plotDataCursorXY1 = new EazyLab.Classes.PlotDataCursorXY();
            EazyLab.Classes.PlotDataView plotDataView1 = new EazyLab.Classes.PlotDataView();
            EazyLab.Classes.PlotLabelBasic plotLabelBasic1 = new EazyLab.Classes.PlotLabelBasic();
            EazyLab.Classes.PlotLegendBasic plotLegendBasic1 = new EazyLab.Classes.PlotLegendBasic();
            EazyLab.Classes.PlotXAxis plotXAxis1 = new EazyLab.Classes.PlotXAxis();
            EazyLab.Classes.PlotYAxis plotYAxis1 = new EazyLab.Classes.PlotYAxis();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbtnStart = new EazyLab.Instrumentation.Standard.ToggleButton();
            this.btnConnect = new EazyLab.Instrumentation.Standard.ToggleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.editString1 = new EazyLab.Instrumentation.Standard.EditString();
            this.button3 = new System.Windows.Forms.Button();
            this.CbStation = new System.Windows.Forms.ComboBox();
            this.label2 = new EazyLab.Instrumentation.Standard.Label();
            this.pvCurrent = new EazyLab.Instrumentation.Standard.PV();
            this.pvEnergy = new EazyLab.Instrumentation.Standard.PV();
            this.pvVoltage = new EazyLab.Instrumentation.Standard.PV();
            this.pvPower = new EazyLab.Instrumentation.Standard.PV();
            this.pvTemp2 = new EazyLab.Instrumentation.Standard.PV();
            this.pvTemp4 = new EazyLab.Instrumentation.Standard.PV();
            this.pvTemp6 = new EazyLab.Instrumentation.Standard.PV();
            this.pvTemp1 = new EazyLab.Instrumentation.Standard.PV();
            this.Plot = new EazyLab.Instrumentation.Standard.CombinedPlot();
            this.pvTemp3 = new EazyLab.Instrumentation.Standard.PV();
            this.pvTemp5 = new EazyLab.Instrumentation.Standard.PV();
            this.labelStatus = new EazyLab.Instrumentation.Standard.Label();
            this.ledStatus = new EazyLab.Instrumentation.Standard.Led();
            this.plotToolBarStandard1 = new EazyLab.Instrumentation.Plotting.PlotToolBarStandard();
            this.plotToolBarButton1 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton2 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton3 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton4 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton5 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton6 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton7 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton8 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton9 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton10 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton11 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton12 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton13 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton14 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton15 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton16 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton17 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton18 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton19 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton20 = new EazyLab.Classes.PlotToolBarButton();
            this.plotToolBarButton21 = new EazyLab.Classes.PlotToolBarButton();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.cntrlPIDs1 = new EazyLab.Cntrls.CntrlPIDs();
            this.btnSet = new EazyLab.Instrumentation.Standard.ToggleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelStatus, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ledStatus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Plot, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.plotToolBarStandard1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1290, 834);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.31694F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93662F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93661F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93661F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93661F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93661F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pvCurrent, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.pvEnergy, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.pvVoltage, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.pvPower, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.pvTemp2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.pvTemp4, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.pvTemp6, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.pvTemp1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pvTemp3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.pvTemp5, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.LawnGreen;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 517);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1284, 294);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.tbtnStart);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.editString1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.CbStation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox1, 3);
            this.groupBox1.Size = new System.Drawing.Size(606, 300);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Station";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbtnStart
            // 
            this.tbtnStart.BackColor = System.Drawing.Color.Red;
            this.tbtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbtnStart.Location = new System.Drawing.Point(469, 15);
            this.tbtnStart.Name = "tbtnStart";
            this.tbtnStart.OffColor = System.Drawing.Color.Red;
            this.tbtnStart.OffText = "Start";
            this.tbtnStart.OnColor = System.Drawing.Color.GreenYellow;
            this.tbtnStart.OnText = "Stop";
            this.tbtnStart.Size = new System.Drawing.Size(131, 33);
            this.tbtnStart.State = false;
            this.tbtnStart.TabIndex = 93;
            this.tbtnStart.Text = "Start";
            this.tbtnStart.UseVisualStyleBackColor = false;
            this.tbtnStart.Click += new System.EventHandler(this.tbtnStart_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Red;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnConnect.Location = new System.Drawing.Point(330, 15);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.OffColor = System.Drawing.Color.Red;
            this.btnConnect.OffText = "Connect";
            this.btnConnect.OnColor = System.Drawing.Color.GreenYellow;
            this.btnConnect.OnText = "Disconnect";
            this.btnConnect.Size = new System.Drawing.Size(133, 33);
            this.btnConnect.State = false;
            this.btnConnect.TabIndex = 93;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(32, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 79;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // editString1
            // 
            this.editString1.LoadingBegin();
            this.editString1.Location = new System.Drawing.Point(355, 144);
            this.editString1.Name = "editString1";
            this.editString1.Size = new System.Drawing.Size(165, 20);
            this.editString1.TabIndex = 90;
            this.editString1.Value.AsString = "01234567";
            this.editString1.LoadingEnd();
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(245, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 91;
            this.button3.Text = "Serial No.";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // CbStation
            // 
            this.CbStation.BackColor = System.Drawing.Color.White;
            this.CbStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbStation.ForeColor = System.Drawing.Color.Aqua;
            this.CbStation.FormattingEnabled = true;
            this.CbStation.Location = new System.Drawing.Point(86, 19);
            this.CbStation.Name = "CbStation";
            this.CbStation.Size = new System.Drawing.Size(238, 28);
            this.CbStation.TabIndex = 87;
            this.CbStation.DropDown += new System.EventHandler(this.CbStation_DropDown);
            this.CbStation.SelectedIndexChanged += new System.EventHandler(this.CbStation_SelectedIndexChanged);
            this.CbStation.SelectedValueChanged += new System.EventHandler(this.CbStation_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.LoadingBegin();
            this.label2.AutoFont = false;
            this.label2.AutoSize = false;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.SnapShotTransparent = true;
            this.label2.Text = "SN :";
            this.label2.LoadingEnd();
            // 
            // pvCurrent
            // 
            this.pvCurrent.LoadingBegin();
            this.pvCurrent.AutoFont = true;
            this.pvCurrent.AutoSize = false;
            this.pvCurrent.Calibrated = false;
            this.pvCurrent.Channel = ((EazyLab.Model.AnalogInput)(resources.GetObject("pvCurrent.Channel")));
            this.pvCurrent.ChannelNo = 0;
            this.pvCurrent.EnableContextMenu = true;
            this.pvCurrent.EnableDoubleClick = true;
            this.pvCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.pvCurrent.IsHidden = false;
            this.pvCurrent.IsSelectedForPloting = false;
            this.pvCurrent.Location = new System.Drawing.Point(1119, 6);
            this.pvCurrent.Name = "pvCurrent";
            this.pvCurrent.Plot = null;
            this.pvCurrent.PlotChannelNamee = null;
            this.pvCurrent.PlotColor = System.Drawing.Color.White;
            this.pvCurrent.Precision = 1;
            this.pvCurrent.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvCurrent.Size = new System.Drawing.Size(155, 54);
            this.pvCurrent.TagFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pvCurrent.TagName = "Current";
            this.pvCurrent.TagNameGroup = "PV_TagName Group1";
            this.pvCurrent.TagToDigitRatio = ((uint)(30u));
            this.pvCurrent.TextFormatting.Precision = 1;
            this.pvCurrent.TextFormatting.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvCurrent.Unit = "";
            this.pvCurrent.ValueAsDouble = 0D;
            this.pvCurrent.LoadingEnd();
            // 
            // pvEnergy
            // 
            this.pvEnergy.LoadingBegin();
            this.pvEnergy.AutoFont = true;
            this.pvEnergy.AutoSize = false;
            this.pvEnergy.Calibrated = false;
            this.pvEnergy.Channel = ((EazyLab.Model.AnalogInput)(resources.GetObject("pvEnergy.Channel")));
            this.pvEnergy.ChannelNo = 0;
            this.pvEnergy.EnableContextMenu = true;
            this.pvEnergy.EnableDoubleClick = true;
            this.pvEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.pvEnergy.IsHidden = false;
            this.pvEnergy.IsSelectedForPloting = false;
            this.pvEnergy.Location = new System.Drawing.Point(1119, 109);
            this.pvEnergy.Name = "pvEnergy";
            this.pvEnergy.Plot = null;
            this.pvEnergy.PlotChannelNamee = null;
            this.pvEnergy.PlotColor = System.Drawing.Color.White;
            this.pvEnergy.Precision = 1;
            this.pvEnergy.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvEnergy.Size = new System.Drawing.Size(155, 54);
            this.pvEnergy.TagFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pvEnergy.TagName = "Energy";
            this.pvEnergy.TagNameGroup = "PV_TagName Group1";
            this.pvEnergy.TagToDigitRatio = ((uint)(30u));
            this.pvEnergy.TextFormatting.Precision = 1;
            this.pvEnergy.TextFormatting.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvEnergy.Unit = "";
            this.pvEnergy.ValueAsDouble = 0D;
            this.pvEnergy.LoadingEnd();
            // 
            // pvVoltage
            // 
            this.pvVoltage.LoadingBegin();
            this.pvVoltage.AutoFont = true;
            this.pvVoltage.AutoSize = false;
            this.pvVoltage.Calibrated = false;
            this.pvVoltage.Channel = ((EazyLab.Model.AnalogInput)(resources.GetObject("pvVoltage.Channel")));
            this.pvVoltage.ChannelNo = 0;
            this.pvVoltage.EnableContextMenu = true;
            this.pvVoltage.EnableDoubleClick = true;
            this.pvVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.pvVoltage.IsHidden = false;
            this.pvVoltage.IsSelectedForPloting = false;
            this.pvVoltage.Location = new System.Drawing.Point(953, 6);
            this.pvVoltage.Name = "pvVoltage";
            this.pvVoltage.Plot = null;
            this.pvVoltage.PlotChannelNamee = null;
            this.pvVoltage.PlotColor = System.Drawing.Color.White;
            this.pvVoltage.Precision = 1;
            this.pvVoltage.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvVoltage.Size = new System.Drawing.Size(155, 43);
            this.pvVoltage.TagFont = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.pvVoltage.TagName = "Voltage";
            this.pvVoltage.TagNameGroup = "PV_TagName Group1";
            this.pvVoltage.TagToDigitRatio = ((uint)(30u));
            this.pvVoltage.TextFormatting.Precision = 1;
            this.pvVoltage.TextFormatting.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvVoltage.Unit = "";
            this.pvVoltage.ValueAsDouble = 0D;
            this.pvVoltage.ValueChanged += new EazyLab.Delegates.ValueDoubleEventHandler(this.pvVoltage_ValueChanged);
            this.pvVoltage.LoadingEnd();
            // 
            // pvPower
            // 
            this.pvPower.LoadingBegin();
            this.pvPower.AutoFont = true;
            this.pvPower.AutoSize = false;
            this.pvPower.Calibrated = false;
            this.pvPower.Channel = ((EazyLab.Model.AnalogInput)(resources.GetObject("pvPower.Channel")));
            this.pvPower.ChannelNo = 0;
            this.pvPower.EnableContextMenu = true;
            this.pvPower.EnableDoubleClick = true;
            this.pvPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.pvPower.IsHidden = false;
            this.pvPower.IsSelectedForPloting = false;
            this.pvPower.Location = new System.Drawing.Point(953, 109);
            this.pvPower.Name = "pvPower";
            this.pvPower.Plot = null;
            this.pvPower.PlotChannelNamee = null;
            this.pvPower.PlotColor = System.Drawing.Color.White;
            this.pvPower.Precision = 1;
            this.pvPower.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvPower.Size = new System.Drawing.Size(155, 54);
            this.pvPower.TagFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pvPower.TagName = "Power";
            this.pvPower.TagNameGroup = "PV_TagName Group1";
            this.pvPower.TagToDigitRatio = ((uint)(30u));
            this.pvPower.TextFormatting.Precision = 1;
            this.pvPower.TextFormatting.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvPower.Unit = "";
            this.pvPower.ValueAsDouble = 0D;
            this.pvPower.LoadingEnd();
            // 
            // pvTemp2
            // 
            this.pvTemp2.LoadingBegin();
            this.pvTemp2.AutoFont = true;
            this.pvTemp2.AutoSize = false;
            this.pvTemp2.Calibrated = false;
            this.pvTemp2.Channel = ((EazyLab.Model.AnalogInput)(resources.GetObject("pvTemp2.Channel")));
            this.pvTemp2.ChannelNo = 0;
            this.pvTemp2.EnableContextMenu = true;
            this.pvTemp2.EnableDoubleClick = true;
            this.pvTemp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.pvTemp2.IsHidden = false;
            this.pvTemp2.IsSelectedForPloting = false;
            this.pvTemp2.Location = new System.Drawing.Point(787, 6);
            this.pvTemp2.Name = "pvTemp2";
            this.pvTemp2.Plot = null;
            this.pvTemp2.PlotChannelNamee = null;
            this.pvTemp2.PlotColor = System.Drawing.Color.White;
            this.pvTemp2.Precision = 1;
            this.pvTemp2.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvTemp2.Size = new System.Drawing.Size(155, 54);
            this.pvTemp2.TagFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pvTemp2.TagName = "Temp2";
            this.pvTemp2.TagNameGroup = "PV_TagName Group1";
            this.pvTemp2.TagToDigitRatio = ((uint)(30u));
            this.pvTemp2.TextFormatting.Precision = 1;
            this.pvTemp2.TextFormatting.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvTemp2.Unit = "";
            this.pvTemp2.ValueAsDouble = 0D;
            this.pvTemp2.LoadingEnd();
            // 
            // pvTemp4
            // 
            this.pvTemp4.LoadingBegin();
            this.pvTemp4.AutoFont = true;
            this.pvTemp4.AutoSize = false;
            this.pvTemp4.Calibrated = false;
            this.pvTemp4.Channel = ((EazyLab.Model.AnalogInput)(resources.GetObject("pvTemp4.Channel")));
            this.pvTemp4.ChannelNo = 0;
            this.pvTemp4.EnableContextMenu = true;
            this.pvTemp4.EnableDoubleClick = true;
            this.pvTemp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.pvTemp4.IsHidden = false;
            this.pvTemp4.IsSelectedForPloting = false;
            this.pvTemp4.Location = new System.Drawing.Point(787, 109);
            this.pvTemp4.Name = "pvTemp4";
            this.pvTemp4.Plot = null;
            this.pvTemp4.PlotChannelNamee = null;
            this.pvTemp4.PlotColor = System.Drawing.Color.White;
            this.pvTemp4.Precision = 1;
            this.pvTemp4.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvTemp4.Size = new System.Drawing.Size(155, 54);
            this.pvTemp4.TagFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pvTemp4.TagName = "Temp5";
            this.pvTemp4.TagNameGroup = "PV_TagName Group1";
            this.pvTemp4.TagToDigitRatio = ((uint)(30u));
            this.pvTemp4.TextFormatting.Precision = 1;
            this.pvTemp4.TextFormatting.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvTemp4.Unit = "";
            this.pvTemp4.ValueAsDouble = 0D;
            this.pvTemp4.LoadingEnd();
            // 
            // pvTemp6
            // 
            this.pvTemp6.LoadingBegin();
            this.pvTemp6.AutoFont = true;
            this.pvTemp6.AutoSize = false;
            this.pvTemp6.Calibrated = false;
            this.pvTemp6.Channel = ((EazyLab.Model.AnalogInput)(resources.GetObject("pvTemp6.Channel")));
            this.pvTemp6.ChannelNo = 0;
            this.pvTemp6.EnableContextMenu = true;
            this.pvTemp6.EnableDoubleClick = true;
            this.pvTemp6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.pvTemp6.IsHidden = false;
            this.pvTemp6.IsSelectedForPloting = false;
            this.pvTemp6.Location = new System.Drawing.Point(787, 212);
            this.pvTemp6.Name = "pvTemp6";
            this.pvTemp6.Plot = null;
            this.pvTemp6.PlotChannelNamee = null;
            this.pvTemp6.PlotColor = System.Drawing.Color.White;
            this.pvTemp6.Precision = 1;
            this.pvTemp6.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvTemp6.Size = new System.Drawing.Size(157, 54);
            this.pvTemp6.TagFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pvTemp6.TagName = "Temp6";
            this.pvTemp6.TagNameGroup = "PV_TagName Group1";
            this.pvTemp6.TagToDigitRatio = ((uint)(30u));
            this.pvTemp6.TextFormatting.Precision = 1;
            this.pvTemp6.TextFormatting.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvTemp6.Unit = "";
            this.pvTemp6.ValueAsDouble = 0D;
            this.pvTemp6.LoadingEnd();
            // 
            // pvTemp1
            // 
            this.pvTemp1.LoadingBegin();
            this.pvTemp1.AutoFont = true;
            this.pvTemp1.AutoSize = false;
            this.pvTemp1.Calibrated = false;
            this.pvTemp1.Channel = ((EazyLab.Model.AnalogInput)(resources.GetObject("pvTemp1.Channel")));
            this.pvTemp1.ChannelNo = 0;
            this.pvTemp1.EnableContextMenu = true;
            this.pvTemp1.EnableDoubleClick = true;
            this.pvTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.pvTemp1.IsHidden = false;
            this.pvTemp1.IsSelectedForPloting = false;
            this.pvTemp1.Location = new System.Drawing.Point(621, 6);
            this.pvTemp1.Name = "pvTemp1";
            this.pvTemp1.Plot = this.Plot;
            this.pvTemp1.PlotChannelNamee = null;
            this.pvTemp1.PlotColor = System.Drawing.Color.White;
            this.pvTemp1.Precision = 1;
            this.pvTemp1.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvTemp1.Size = new System.Drawing.Size(155, 54);
            this.pvTemp1.TagFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pvTemp1.TagName = "Temp1";
            this.pvTemp1.TagNameGroup = "PV_TagName Group1";
            this.pvTemp1.TagToDigitRatio = ((uint)(30u));
            this.pvTemp1.TextFormatting.Precision = 1;
            this.pvTemp1.TextFormatting.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvTemp1.Unit = "";
            this.pvTemp1.ValueAsDouble = 0D;
            this.pvTemp1.LoadingEnd();
            // 
            // Plot
            // 
            this.Plot.LoadingBegin();
            this.Plot.AutoFont = false;
            this.tableLayoutPanel1.SetColumnSpan(this.Plot, 4);
            plotDataCursorXY1.Hint.Fill.Pen.Color = System.Drawing.SystemColors.InfoText;
            plotDataCursorXY1.Name = "Data-Cursor 1";
            plotDataCursorXY1.TitleText = "Data-Cursor 1";
            this.Plot.DataCursors.Add(plotDataCursorXY1);
            plotDataView1.Name = "Data-View 1";
            plotDataView1.TitleText = "Data-View 1";
            this.Plot.DataViews.Add(plotDataView1);
            this.Plot.Dock = System.Windows.Forms.DockStyle.Fill;
            plotLabelBasic1.DockOrder = 0;
            plotLabelBasic1.Name = "Label 1";
            this.Plot.Labels.Add(plotLabelBasic1);
            plotLegendBasic1.DockOrder = 0;
            plotLegendBasic1.Name = "Legend 1";
            plotLegendBasic1.TitleText = "Legend 1";
            this.Plot.Legends.Add(plotLegendBasic1);
            this.Plot.Location = new System.Drawing.Point(3, 33);
            this.Plot.Name = "Plot";
            this.Plot.NoOFChannels = 10;
            this.Plot.Size = new System.Drawing.Size(1284, 478);
            this.Plot.TabIndex = 4;
            plotXAxis1.DockOrder = 0;
            plotXAxis1.Name = "X-Axis 1";
            plotXAxis1.Title.Text = "X-Axis 1";
            this.Plot.XAxes.Add(plotXAxis1);
            plotYAxis1.DockOrder = 0;
            plotYAxis1.Name = "Y-Axis 1";
            plotYAxis1.Title.Text = "Y-Axis 1";
            this.Plot.YAxes.Add(plotYAxis1);
            this.Plot.Click += new System.EventHandler(this.Plot_Click);
            this.Plot.LoadingEnd();
            // 
            // pvTemp3
            // 
            this.pvTemp3.LoadingBegin();
            this.pvTemp3.AutoFont = true;
            this.pvTemp3.AutoSize = false;
            this.pvTemp3.Calibrated = false;
            this.pvTemp3.Channel = ((EazyLab.Model.AnalogInput)(resources.GetObject("pvTemp3.Channel")));
            this.pvTemp3.ChannelNo = 0;
            this.pvTemp3.EnableContextMenu = true;
            this.pvTemp3.EnableDoubleClick = true;
            this.pvTemp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.pvTemp3.IsHidden = false;
            this.pvTemp3.IsSelectedForPloting = false;
            this.pvTemp3.Location = new System.Drawing.Point(621, 109);
            this.pvTemp3.Name = "pvTemp3";
            this.pvTemp3.Plot = null;
            this.pvTemp3.PlotChannelNamee = null;
            this.pvTemp3.PlotColor = System.Drawing.Color.White;
            this.pvTemp3.Precision = 1;
            this.pvTemp3.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvTemp3.Size = new System.Drawing.Size(155, 54);
            this.pvTemp3.TagFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pvTemp3.TagName = "Temp3";
            this.pvTemp3.TagNameGroup = "PV_TagName Group1";
            this.pvTemp3.TagToDigitRatio = ((uint)(30u));
            this.pvTemp3.TextFormatting.Precision = 1;
            this.pvTemp3.TextFormatting.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvTemp3.Unit = "";
            this.pvTemp3.ValueAsDouble = 0D;
            this.pvTemp3.LoadingEnd();
            // 
            // pvTemp5
            // 
            this.pvTemp5.LoadingBegin();
            this.pvTemp5.AutoFont = true;
            this.pvTemp5.AutoSize = false;
            this.pvTemp5.Calibrated = false;
            this.pvTemp5.Channel = ((EazyLab.Model.AnalogInput)(resources.GetObject("pvTemp5.Channel")));
            this.pvTemp5.ChannelNo = 0;
            this.pvTemp5.EnableContextMenu = true;
            this.pvTemp5.EnableDoubleClick = true;
            this.pvTemp5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.pvTemp5.IsHidden = false;
            this.pvTemp5.IsSelectedForPloting = false;
            this.pvTemp5.Location = new System.Drawing.Point(621, 212);
            this.pvTemp5.Name = "pvTemp5";
            this.pvTemp5.Plot = null;
            this.pvTemp5.PlotChannelNamee = null;
            this.pvTemp5.PlotColor = System.Drawing.Color.White;
            this.pvTemp5.Precision = 1;
            this.pvTemp5.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvTemp5.Size = new System.Drawing.Size(155, 54);
            this.pvTemp5.TagFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pvTemp5.TagName = "Temp5";
            this.pvTemp5.TagNameGroup = "PV_TagName Group1";
            this.pvTemp5.TagToDigitRatio = ((uint)(30u));
            this.pvTemp5.TextFormatting.Precision = 1;
            this.pvTemp5.TextFormatting.PrecisionStyle = EazyLab.Types.PrecisionStyle.FixedDecimalPoints;
            this.pvTemp5.Unit = "";
            this.pvTemp5.ValueAsDouble = 0D;
            this.pvTemp5.LoadingEnd();
            // 
            // labelStatus
            // 
            this.labelStatus.LoadingBegin();
            this.labelStatus.AutoFont = false;
            this.tableLayoutPanel1.SetColumnSpan(this.labelStatus, 2);
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.99688F);
            this.labelStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStatus.Location = new System.Drawing.Point(593, 3);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(494, 24);
            this.labelStatus.Text = "Status";
            this.labelStatus.LoadingEnd();
            // 
            // ledStatus
            // 
            this.ledStatus.LoadingBegin();
            this.ledStatus.AutoFont = false;
            this.ledStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.ledStatus.Location = new System.Drawing.Point(1245, 3);
            this.ledStatus.Name = "ledStatus";
            this.ledStatus.Size = new System.Drawing.Size(42, 24);
            this.ledStatus.LoadingEnd();
            // 
            // plotToolBarStandard1
            // 
            this.plotToolBarStandard1.LoadingBegin();
            this.plotToolBarStandard1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.plotToolBarStandard1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.plotToolBarButton1,
            this.plotToolBarButton2,
            this.plotToolBarButton3,
            this.plotToolBarButton4,
            this.plotToolBarButton5,
            this.plotToolBarButton6,
            this.plotToolBarButton7,
            this.plotToolBarButton8,
            this.plotToolBarButton9,
            this.plotToolBarButton10,
            this.plotToolBarButton11,
            this.plotToolBarButton12,
            this.plotToolBarButton13,
            this.plotToolBarButton14,
            this.plotToolBarButton15,
            this.plotToolBarButton16,
            this.plotToolBarButton17,
            this.plotToolBarButton18,
            this.plotToolBarButton19,
            this.plotToolBarButton20,
            this.plotToolBarButton21});
            this.plotToolBarStandard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotToolBarStandard1.DropDownArrows = true;
            this.plotToolBarStandard1.ImageList = this.imageList3;
            this.plotToolBarStandard1.Location = new System.Drawing.Point(3, 3);
            this.plotToolBarStandard1.Name = "plotToolBarStandard1";
            this.plotToolBarStandard1.Plot = this.Plot;
            this.plotToolBarStandard1.ShowToolTips = true;
            this.plotToolBarStandard1.Size = new System.Drawing.Size(584, 28);
            this.plotToolBarStandard1.TabIndex = 5;
            this.plotToolBarStandard1.LoadingEnd();
            // 
            // plotToolBarButton1
            // 
            this.plotToolBarButton1.LoadingBegin();
            this.plotToolBarButton1.Enabled = false;
            this.plotToolBarButton1.ImageIndex = 0;
            this.plotToolBarButton1.Name = "plotToolBarButton1";
            this.plotToolBarButton1.ToolTipText = "Tracking Resume";
            this.plotToolBarButton1.LoadingEnd();
            // 
            // plotToolBarButton2
            // 
            this.plotToolBarButton2.LoadingBegin();
            this.plotToolBarButton2.Command = EazyLab.Types.PlotToolBarCommandStyle.TrackingPause;
            this.plotToolBarButton2.ImageIndex = 1;
            this.plotToolBarButton2.Name = "plotToolBarButton2";
            this.plotToolBarButton2.ToolTipText = "Tracking Pause";
            this.plotToolBarButton2.LoadingEnd();
            // 
            // plotToolBarButton3
            // 
            this.plotToolBarButton3.LoadingBegin();
            this.plotToolBarButton3.Command = EazyLab.Types.PlotToolBarCommandStyle.Separator;
            this.plotToolBarButton3.Enabled = false;
            this.plotToolBarButton3.Name = "plotToolBarButton3";
            this.plotToolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.plotToolBarButton3.LoadingEnd();
            // 
            // plotToolBarButton4
            // 
            this.plotToolBarButton4.LoadingBegin();
            this.plotToolBarButton4.Command = EazyLab.Types.PlotToolBarCommandStyle.AxesScroll;
            this.plotToolBarButton4.ImageIndex = 2;
            this.plotToolBarButton4.Name = "plotToolBarButton4";
            this.plotToolBarButton4.Pushed = true;
            this.plotToolBarButton4.ToolTipText = "Axes Scroll";
            this.plotToolBarButton4.LoadingEnd();
            // 
            // plotToolBarButton5
            // 
            this.plotToolBarButton5.LoadingBegin();
            this.plotToolBarButton5.Command = EazyLab.Types.PlotToolBarCommandStyle.AxesZoom;
            this.plotToolBarButton5.ImageIndex = 3;
            this.plotToolBarButton5.Name = "plotToolBarButton5";
            this.plotToolBarButton5.ToolTipText = "Axes Zoom";
            this.plotToolBarButton5.LoadingEnd();
            // 
            // plotToolBarButton6
            // 
            this.plotToolBarButton6.LoadingBegin();
            this.plotToolBarButton6.Command = EazyLab.Types.PlotToolBarCommandStyle.Separator;
            this.plotToolBarButton6.Enabled = false;
            this.plotToolBarButton6.Name = "plotToolBarButton6";
            this.plotToolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.plotToolBarButton6.LoadingEnd();
            // 
            // plotToolBarButton7
            // 
            this.plotToolBarButton7.LoadingBegin();
            this.plotToolBarButton7.Command = EazyLab.Types.PlotToolBarCommandStyle.ZoomOut;
            this.plotToolBarButton7.ImageIndex = 4;
            this.plotToolBarButton7.Name = "plotToolBarButton7";
            this.plotToolBarButton7.ToolTipText = "Zoom-Out";
            this.plotToolBarButton7.LoadingEnd();
            // 
            // plotToolBarButton8
            // 
            this.plotToolBarButton8.LoadingBegin();
            this.plotToolBarButton8.Command = EazyLab.Types.PlotToolBarCommandStyle.ZoomIn;
            this.plotToolBarButton8.ImageIndex = 5;
            this.plotToolBarButton8.Name = "plotToolBarButton8";
            this.plotToolBarButton8.ToolTipText = "Zoom-In";
            this.plotToolBarButton8.LoadingEnd();
            // 
            // plotToolBarButton9
            // 
            this.plotToolBarButton9.LoadingBegin();
            this.plotToolBarButton9.Command = EazyLab.Types.PlotToolBarCommandStyle.Separator;
            this.plotToolBarButton9.Enabled = false;
            this.plotToolBarButton9.Name = "plotToolBarButton9";
            this.plotToolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.plotToolBarButton9.LoadingEnd();
            // 
            // plotToolBarButton10
            // 
            this.plotToolBarButton10.LoadingBegin();
            this.plotToolBarButton10.Command = EazyLab.Types.PlotToolBarCommandStyle.Select;
            this.plotToolBarButton10.ImageIndex = 6;
            this.plotToolBarButton10.Name = "plotToolBarButton10";
            this.plotToolBarButton10.Pushed = true;
            this.plotToolBarButton10.ToolTipText = "Select";
            this.plotToolBarButton10.LoadingEnd();
            // 
            // plotToolBarButton11
            // 
            this.plotToolBarButton11.LoadingBegin();
            this.plotToolBarButton11.Command = EazyLab.Types.PlotToolBarCommandStyle.ZoomBox;
            this.plotToolBarButton11.ImageIndex = 7;
            this.plotToolBarButton11.Name = "plotToolBarButton11";
            this.plotToolBarButton11.ToolTipText = "Zoom-Box";
            this.plotToolBarButton11.LoadingEnd();
            // 
            // plotToolBarButton12
            // 
            this.plotToolBarButton12.LoadingBegin();
            this.plotToolBarButton12.Command = EazyLab.Types.PlotToolBarCommandStyle.DataCursor;
            this.plotToolBarButton12.ImageIndex = 8;
            this.plotToolBarButton12.Name = "plotToolBarButton12";
            this.plotToolBarButton12.ToolTipText = "Data-Cursor";
            this.plotToolBarButton12.LoadingEnd();
            // 
            // plotToolBarButton13
            // 
            this.plotToolBarButton13.LoadingBegin();
            this.plotToolBarButton13.Command = EazyLab.Types.PlotToolBarCommandStyle.Separator;
            this.plotToolBarButton13.Enabled = false;
            this.plotToolBarButton13.Name = "plotToolBarButton13";
            this.plotToolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.plotToolBarButton13.LoadingEnd();
            // 
            // plotToolBarButton14
            // 
            this.plotToolBarButton14.LoadingBegin();
            this.plotToolBarButton14.Command = EazyLab.Types.PlotToolBarCommandStyle.Edit;
            this.plotToolBarButton14.ImageIndex = 9;
            this.plotToolBarButton14.Name = "plotToolBarButton14";
            this.plotToolBarButton14.ToolTipText = "Edit";
            this.plotToolBarButton14.LoadingEnd();
            // 
            // plotToolBarButton15
            // 
            this.plotToolBarButton15.LoadingBegin();
            this.plotToolBarButton15.Command = EazyLab.Types.PlotToolBarCommandStyle.Separator;
            this.plotToolBarButton15.Enabled = false;
            this.plotToolBarButton15.Name = "plotToolBarButton15";
            this.plotToolBarButton15.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.plotToolBarButton15.LoadingEnd();
            // 
            // plotToolBarButton16
            // 
            this.plotToolBarButton16.LoadingBegin();
            this.plotToolBarButton16.Command = EazyLab.Types.PlotToolBarCommandStyle.Copy;
            this.plotToolBarButton16.ImageIndex = 10;
            this.plotToolBarButton16.Name = "plotToolBarButton16";
            this.plotToolBarButton16.ToolTipText = "Copy to Clipboard";
            this.plotToolBarButton16.LoadingEnd();
            // 
            // plotToolBarButton17
            // 
            this.plotToolBarButton17.LoadingBegin();
            this.plotToolBarButton17.Command = EazyLab.Types.PlotToolBarCommandStyle.Save;
            this.plotToolBarButton17.ImageIndex = 11;
            this.plotToolBarButton17.Name = "plotToolBarButton17";
            this.plotToolBarButton17.ToolTipText = "Save";
            this.plotToolBarButton17.LoadingEnd();
            // 
            // plotToolBarButton18
            // 
            this.plotToolBarButton18.LoadingBegin();
            this.plotToolBarButton18.Command = EazyLab.Types.PlotToolBarCommandStyle.Separator;
            this.plotToolBarButton18.Enabled = false;
            this.plotToolBarButton18.Name = "plotToolBarButton18";
            this.plotToolBarButton18.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.plotToolBarButton18.LoadingEnd();
            // 
            // plotToolBarButton19
            // 
            this.plotToolBarButton19.LoadingBegin();
            this.plotToolBarButton19.Command = EazyLab.Types.PlotToolBarCommandStyle.Print;
            this.plotToolBarButton19.ImageIndex = 12;
            this.plotToolBarButton19.Name = "plotToolBarButton19";
            this.plotToolBarButton19.ToolTipText = "Print";
            this.plotToolBarButton19.LoadingEnd();
            // 
            // plotToolBarButton20
            // 
            this.plotToolBarButton20.LoadingBegin();
            this.plotToolBarButton20.Command = EazyLab.Types.PlotToolBarCommandStyle.Preview;
            this.plotToolBarButton20.ImageIndex = 13;
            this.plotToolBarButton20.Name = "plotToolBarButton20";
            this.plotToolBarButton20.ToolTipText = "Preview";
            this.plotToolBarButton20.LoadingEnd();
            // 
            // plotToolBarButton21
            // 
            this.plotToolBarButton21.LoadingBegin();
            this.plotToolBarButton21.Command = EazyLab.Types.PlotToolBarCommandStyle.PageSetup;
            this.plotToolBarButton21.ImageIndex = 14;
            this.plotToolBarButton21.Name = "plotToolBarButton21";
            this.plotToolBarButton21.ToolTipText = "Page Setup";
            this.plotToolBarButton21.LoadingEnd();
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "");
            this.imageList3.Images.SetKeyName(1, "");
            this.imageList3.Images.SetKeyName(2, "");
            this.imageList3.Images.SetKeyName(3, "");
            this.imageList3.Images.SetKeyName(4, "");
            this.imageList3.Images.SetKeyName(5, "");
            this.imageList3.Images.SetKeyName(6, "");
            this.imageList3.Images.SetKeyName(7, "");
            this.imageList3.Images.SetKeyName(8, "");
            this.imageList3.Images.SetKeyName(9, "");
            this.imageList3.Images.SetKeyName(10, "");
            this.imageList3.Images.SetKeyName(11, "");
            this.imageList3.Images.SetKeyName(12, "");
            this.imageList3.Images.SetKeyName(13, "");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            this.imageList2.Images.SetKeyName(4, "");
            this.imageList2.Images.SetKeyName(5, "");
            this.imageList2.Images.SetKeyName(6, "");
            this.imageList2.Images.SetKeyName(7, "");
            this.imageList2.Images.SetKeyName(8, "");
            this.imageList2.Images.SetKeyName(9, "");
            this.imageList2.Images.SetKeyName(10, "");
            this.imageList2.Images.SetKeyName(11, "");
            this.imageList2.Images.SetKeyName(12, "");
            this.imageList2.Images.SetKeyName(13, "");
            // 
            // cntrlPIDs1
            // 
            this.cntrlPIDs1.AddMode = false;
            this.cntrlPIDs1.ClsList = null;
            this.cntrlPIDs1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cntrlPIDs1.DeleteMode = false;
            this.cntrlPIDs1.EditMode = false;
            this.cntrlPIDs1.Location = new System.Drawing.Point(0, 0);
            this.cntrlPIDs1.Margin = new System.Windows.Forms.Padding(4);
            this.cntrlPIDs1.Name = "cntrlPIDs1";
            this.cntrlPIDs1.Row = 0;
            this.cntrlPIDs1.Size = new System.Drawing.Size(900, 509);
            this.cntrlPIDs1.TabIndex = 0;
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.White;
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSet.Location = new System.Drawing.Point(330, 70);
            this.btnSet.Name = "btnSet";
            this.btnSet.OffColor = System.Drawing.Color.White;
            this.btnSet.OffText = "Set On";
            this.btnSet.OnColor = System.Drawing.Color.DimGray;
            this.btnSet.OnText = "Set Off";
            this.btnSet.Size = new System.Drawing.Size(133, 33);
            this.btnSet.State = false;
            this.btnSet.TabIndex = 95;
            this.btnSet.Text = "Set On";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.toggleButton1_Click_1);
            // 
            // CptChamberCntrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "CptChamberCntrl";
            this.Size = new System.Drawing.Size(1290, 834);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Instrumentation.Standard.Label labelStatus;
        private Instrumentation.Standard.CombinedPlot Plot;
        private Cntrls.CntrlPIDs cntrlPIDs1;
        private Instrumentation.Plotting.PlotToolBarStandard plotToolBarStandard1;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton1;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton2;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton3;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton4;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton5;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton6;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton7;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton8;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton9;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton10;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton11;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton12;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton13;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton14;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton15;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton16;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton17;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton18;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton19;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton20;
        private EazyLab.Classes.PlotToolBarButton plotToolBarButton21;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Instrumentation.Standard.Label label2;
        private Instrumentation.Standard.PV pvVoltage;
        private Instrumentation.Standard.PV pvCurrent;
        private Instrumentation.Standard.PV pvTemp2;
        private Instrumentation.Standard.PV pvTemp3;
        private Instrumentation.Standard.PV pvTemp5;
        private Instrumentation.Standard.PV pvTemp6;
        private Instrumentation.Standard.PV pvPower;
        private Instrumentation.Standard.Led ledStatus;
        private Instrumentation.Standard.PV pvTemp1;
        private System.Windows.Forms.ComboBox CbStation;
        private System.Windows.Forms.Button button1;
        private Instrumentation.Standard.PV pvEnergy;
        private Instrumentation.Standard.PV pvTemp4;
        private System.Windows.Forms.ImageList imageList2;
        private Instrumentation.Standard.EditString editString1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Instrumentation.Standard.ToggleButton btnConnect;
        private Instrumentation.Standard.ToggleButton tbtnStart;
        private Instrumentation.Standard.ToggleButton btnSet;
    }
}
