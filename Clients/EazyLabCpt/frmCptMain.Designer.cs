
using System;
using EazyLab;
using EazyLab.Instrumentation.Standard;
using EazyLab.Instrumentation.Professional;
using EazyLabClient;
using EazyLab.Cpt.Controls; 
namespace EazyLabClient
{

    partial class frmCptMain
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
            this.contextMenuStripSetup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemServerConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemconfigStation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSaveChamber = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoadChamber = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBarCodeScanner = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConnectAllStations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsServerSetup = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem1 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.tsSaveChamber = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.tsLoadChamber = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cntrl = new EazyLab.Cpt.Controls.CptChamberCntrl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btSettings = new System.Windows.Forms.Button();
            this.buttonSetup = new System.Windows.Forms.Button();
            this.btClsoe = new System.Windows.Forms.Button();
            this.tableLayoutPanelHeader = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.led1 = new EazyLab.Instrumentation.Standard.Led();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.timerUpdateDisplay = new System.Windows.Forms.Timer(this.components);
            this.serverComp1 = new EazyLab.Equipments.Components.ServerComp(this.components);
            this.rtuChamberComp = new EazyLab.Equipments.Components.RtuChamberComp(this.components);
            this.ahuDbtWbtComp = new EazyLab.Equipments.Components.AhuDbtWbtComp(this.components);
            this.comPort1 = new EazyLab.Common.ComPort(this.components);
            this.contextMenuStripSetup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comPort1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripSetup
            // 
            this.contextMenuStripSetup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripSetup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSetup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemServerConfig,
            this.toolStripSeparator1,
            this.toolStripMenuItemconfigStation,
            this.toolStripSeparator2,
            this.toolStripMenuItemSaveChamber,
            this.toolStripMenuItemLoadChamber,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.toolStripMenuItem5,
            this.toolStripMenuItemBarCodeScanner,
            this.toolStripMenuItem1,
            this.toolStripMenuItemConnectAllStations});
            this.contextMenuStripSetup.Name = "contextMenuStrip1";
            this.contextMenuStripSetup.Size = new System.Drawing.Size(259, 236);
            this.contextMenuStripSetup.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripSetup_Opening);
            this.contextMenuStripSetup.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripSetup_ItemClicked);
            // 
            // toolStripMenuItemServerConfig
            // 
            this.toolStripMenuItemServerConfig.Name = "toolStripMenuItemServerConfig";
            this.toolStripMenuItemServerConfig.Size = new System.Drawing.Size(258, 26);
            this.toolStripMenuItemServerConfig.Text = "Server Config";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(255, 6);
            // 
            // toolStripMenuItemconfigStation
            // 
            this.toolStripMenuItemconfigStation.Name = "toolStripMenuItemconfigStation";
            this.toolStripMenuItemconfigStation.Size = new System.Drawing.Size(258, 26);
            this.toolStripMenuItemconfigStation.Text = "Configure Station";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(255, 6);
            // 
            // toolStripMenuItemSaveChamber
            // 
            this.toolStripMenuItemSaveChamber.Name = "toolStripMenuItemSaveChamber";
            this.toolStripMenuItemSaveChamber.Size = new System.Drawing.Size(258, 26);
            this.toolStripMenuItemSaveChamber.Text = "Save Chamber";
            // 
            // toolStripMenuItemLoadChamber
            // 
            this.toolStripMenuItemLoadChamber.Name = "toolStripMenuItemLoadChamber";
            this.toolStripMenuItemLoadChamber.Size = new System.Drawing.Size(258, 26);
            this.toolStripMenuItemLoadChamber.Text = "Load Chamber";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(255, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(255, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(258, 26);
            this.toolStripMenuItem5.Text = "Correct Temp";
            // 
            // toolStripMenuItemBarCodeScanner
            // 
            this.toolStripMenuItemBarCodeScanner.Name = "toolStripMenuItemBarCodeScanner";
            this.toolStripMenuItemBarCodeScanner.Size = new System.Drawing.Size(258, 26);
            this.toolStripMenuItemBarCodeScanner.Text = "Regist Barcode Scanner";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(258, 26);
            this.toolStripMenuItem1.Text = "Temperature Profile";
            // 
            // toolStripMenuItemConnectAllStations
            // 
            this.toolStripMenuItemConnectAllStations.Name = "toolStripMenuItemConnectAllStations";
            this.toolStripMenuItemConnectAllStations.Size = new System.Drawing.Size(258, 26);
            this.toolStripMenuItemConnectAllStations.Text = "Connect All Stations";
            // 
            // tsServerSetup
            // 
            this.tsServerSetup.Name = "tsServerSetup";
            this.tsServerSetup.Size = new System.Drawing.Size(23, 23);
            this.tsServerSetup.Text = "ServerSetup";
            // 
            // toolstripitem1
            // 
            this.toolstripitem1.Name = "toolstripitem1";
            this.toolstripitem1.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem1.Text = "StationConfig";
            // 
            // tsSaveChamber
            // 
            this.tsSaveChamber.Name = "tsSaveChamber";
            this.tsSaveChamber.Size = new System.Drawing.Size(23, 23);
            this.tsSaveChamber.Text = "Save Chamber";
            // 
            // tsLoadChamber
            // 
            this.tsLoadChamber.Name = "tsLoadChamber";
            this.tsLoadChamber.Size = new System.Drawing.Size(23, 23);
            this.tsLoadChamber.Text = "Load Chamber";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Cntrl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelHeader, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1620, 745);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Cntrl
            // 
            this.Cntrl.Chamber = null;
            this.Cntrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cntrl.Location = new System.Drawing.Point(3, 48);
            this.Cntrl.Name = "Cntrl";
            this.Cntrl.Size = new System.Drawing.Size(1614, 649);
            this.Cntrl.TabIndex = 0;
            this.Cntrl.Load += new System.EventHandler(this.cptChamberCntrl1_Load);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 12;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Controls.Add(this.btSettings, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSetup, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.btClsoe, 9, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 703);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1614, 39);
            this.tableLayoutPanel2.TabIndex = 10;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // btSettings
            // 
            this.btSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSettings.Location = new System.Drawing.Point(148, 3);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(194, 33);
            this.btSettings.TabIndex = 14;
            this.btSettings.Text = "Settings";
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // buttonSetup
            // 
            this.buttonSetup.ContextMenuStrip = this.contextMenuStripSetup;
            this.buttonSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetup.Location = new System.Drawing.Point(948, 3);
            this.buttonSetup.Name = "buttonSetup";
            this.buttonSetup.Size = new System.Drawing.Size(194, 33);
            this.buttonSetup.TabIndex = 16;
            this.buttonSetup.Text = "Setup";
            this.buttonSetup.UseVisualStyleBackColor = true;
            this.buttonSetup.Click += new System.EventHandler(this.buttonSetup_Click_1);
            // 
            // btClsoe
            // 
            this.btClsoe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btClsoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClsoe.Location = new System.Drawing.Point(1248, 3);
            this.btClsoe.Name = "btClsoe";
            this.btClsoe.Size = new System.Drawing.Size(194, 33);
            this.btClsoe.TabIndex = 19;
            this.btClsoe.Text = "Close";
            this.btClsoe.UseVisualStyleBackColor = true;
            this.btClsoe.Click += new System.EventHandler(this.btClsoe_Click);
            // 
            // tableLayoutPanelHeader
            // 
            this.tableLayoutPanelHeader.ColumnCount = 4;
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelHeader.Controls.Add(this.labelTitle, 1, 0);
            this.tableLayoutPanelHeader.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanelHeader.Controls.Add(this.led1, 2, 0);
            this.tableLayoutPanelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelHeader.Name = "tableLayoutPanelHeader";
            this.tableLayoutPanelHeader.RowCount = 1;
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeader.Size = new System.Drawing.Size(1620, 45);
            this.tableLayoutPanelHeader.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(353, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(914, 45);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Data acquisition Test ";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::EazyLab.Properties.Resources.LogoNew_eazylab;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // led1
            // 
            this.led1.LoadingBegin();
            this.led1.AutoFont = false;
            this.led1.BlinkerRate = 10;
            this.led1.Dock = System.Windows.Forms.DockStyle.Right;
            this.led1.Location = new System.Drawing.Point(1523, 3);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(44, 39);
            this.led1.Value.EventsEnabled = false;
            this.led1.LoadingEnd();
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuItem1
            // 
            this.menuItem1.Index = -1;
            this.menuItem1.Text = "menuItem1";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = -1;
            this.menuItem2.Text = "menuItem2";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = -1;
            this.menuItem3.Text = "menuItem3";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = -1;
            this.menuItem4.Text = "menuItem4";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = -1;
            this.menuItem5.Text = "menuItem5";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = -1;
            this.menuItem6.Text = "menuItem6";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = -1;
            this.menuItem7.Text = "menuItem7";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = -1;
            this.menuItem8.Text = "menuItem8";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = -1;
            this.menuItem9.Text = "menuItem9";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = -1;
            this.menuItem10.Text = "menuItem10";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = -1;
            this.menuItem11.Text = "menuItem11";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = -1;
            this.menuItem12.Text = "menuItem12";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = -1;
            this.menuItem13.Text = "menuItem13";
            // 
            // menuItem14
            // 
            this.menuItem14.Index = -1;
            this.menuItem14.Text = "menuItem14";
            // 
            // menuItem15
            // 
            this.menuItem15.Index = -1;
            this.menuItem15.Text = "menuItem15";
            // 
            // menuItem16
            // 
            this.menuItem16.Index = -1;
            this.menuItem16.Text = "menuItem16";
            // 
            // menuItem17
            // 
            this.menuItem17.Index = -1;
            this.menuItem17.Text = "menuItem17";
            // 
            // menuItem18
            // 
            this.menuItem18.Index = -1;
            this.menuItem18.Text = "menuItem18";
            // 
            // menuItem19
            // 
            this.menuItem19.Index = -1;
            this.menuItem19.Text = "menuItem19";
            // 
            // menuItem20
            // 
            this.menuItem20.Index = -1;
            this.menuItem20.Text = "menuItem20";
            // 
            // timerUpdateDisplay
            // 
            this.timerUpdateDisplay.Tick += new System.EventHandler(this.timerUpdateDisplay_Tick);
            // 
            // serverComp1
            // 
            this.serverComp1.Filename = "D:\\Rtu\\Db\\RTU.srv";
            this.serverComp1.Interval = 1000;
            this.serverComp1.Led = this.led1;
            this.serverComp1.RandomValues = false;
            this.serverComp1.UpdatingTime = 0;
            // 
            // rtuChamberComp
            // 
            this.rtuChamberComp.Ahu = this.ahuDbtWbtComp;
            // 
            // ahuDbtWbtComp
            // 
            this.ahuDbtWbtComp.DbtSetPoint = 0D;
            // 
            // comPort1
            // 
            this.comPort1.LogFile = null;
            // 
            // frmCptMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1620, 745);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "frmCptMain";
            this.Text = "Data acquisition Test Unit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextMenuStripSetup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanelHeader.ResumeLayout(false);
            this.tableLayoutPanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comPort1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private EazyLab.Instrumentation.Standard.Led led1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelTitle;
        private Syncfusion.Windows.Forms.Tools.toolstripitem tsServerSetup;
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem1;
        private Syncfusion.Windows.Forms.Tools.toolstripitem tsSaveChamber;
        private Syncfusion.Windows.Forms.Tools.toolstripitem tsLoadChamber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSetup;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveChamber;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemServerConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem menuItem16;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem menuItem18;
        private System.Windows.Forms.MenuItem menuItem19;
        private System.Windows.Forms.MenuItem menuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoadChamber;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemconfigStation;
        private System.Windows.Forms.Timer timerUpdateDisplay;
        private EazyLab.Equipments.Components.ServerComp serverComp1;
        private EazyLab.Equipments.Components.RtuChamberComp rtuChamberComp;
        private EazyLab.Equipments.Components.AhuDbtWbtComp ahuDbtWbtComp;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private EazyLab.Common.ComPort  comPort1;
        private CptChamberCntrl Cntrl;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBarCodeScanner;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Button buttonSetup;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConnectAllStations;
        private System.Windows.Forms.Button btClsoe;
    }
}

