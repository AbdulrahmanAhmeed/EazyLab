namespace EazyLabClient.SimpleDaq.Forms
{
    partial class frmStationConfig
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbCommChannel = new System.Windows.Forms.ComboBox();
            this.ledArrow2 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.ledArrow1 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.ledArrow3 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.ledArrow4 = new EazyLab.Instrumentation.Professional.LedArrow();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.cbAnalogInput = new System.Windows.Forms.ComboBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.cbDaqTask = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new EazyLab.Instrumentation.Standard.Label();
            this.label2 = new EazyLab.Instrumentation.Standard.Label();
            this.label3 = new EazyLab.Instrumentation.Standard.Label();
            this.label4 = new EazyLab.Instrumentation.Standard.Label();
            this.label5 = new EazyLab.Instrumentation.Standard.Label();
            this.label6 = new EazyLab.Instrumentation.Standard.Label();
            this.nudScanningTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanningTime)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 15);
            this.dataGridView1.Size = new System.Drawing.Size(688, 596);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbCommChannel, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.ledArrow2, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.ledArrow1, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.ledArrow3, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.ledArrow4, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbDevice, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbAnalogInput, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonApply, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.cbDaqTask, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonClose, 4, 13);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.nudScanningTime, 4, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1031, 602);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // cbCommChannel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbCommChannel, 3);
            this.cbCommChannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCommChannel.FormattingEnabled = true;
            this.cbCommChannel.Location = new System.Drawing.Point(852, 23);
            this.cbCommChannel.Name = "cbCommChannel";
            this.cbCommChannel.Size = new System.Drawing.Size(176, 21);
            this.cbCommChannel.TabIndex = 2;
            this.cbCommChannel.DropDown += new System.EventHandler(this.cbCommChannel_DropDown);
            this.cbCommChannel.SelectedIndexChanged += new System.EventHandler(this.cbCommChannel_SelectedIndexChanged);
            // 
            // ledArrow2
            // 
            this.ledArrow2.LoadingBegin();
            this.ledArrow2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledArrow2.Indicator.BodyLength = 10;
            this.ledArrow2.Location = new System.Drawing.Point(927, 53);
            this.ledArrow2.Name = "ledArrow2";
            this.ledArrow2.Rotation = EazyLab.Types.RotationQuad.X090;
            this.ledArrow2.Size = new System.Drawing.Size(24, 34);
            this.ledArrow2.LoadingEnd();
            // 
            // ledArrow1
            // 
            this.ledArrow1.LoadingBegin();
            this.ledArrow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledArrow1.Indicator.BodyLength = 10;
            this.ledArrow1.Location = new System.Drawing.Point(927, 123);
            this.ledArrow1.Name = "ledArrow1";
            this.ledArrow1.Rotation = EazyLab.Types.RotationQuad.X090;
            this.ledArrow1.Size = new System.Drawing.Size(24, 34);
            this.ledArrow1.LoadingEnd();
            // 
            // ledArrow3
            // 
            this.ledArrow3.LoadingBegin();
            this.ledArrow3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledArrow3.Indicator.BodyLength = 10;
            this.ledArrow3.Location = new System.Drawing.Point(927, 263);
            this.ledArrow3.Name = "ledArrow3";
            this.ledArrow3.Rotation = EazyLab.Types.RotationQuad.X090;
            this.ledArrow3.Size = new System.Drawing.Size(24, 34);
            this.ledArrow3.LoadingEnd();
            // 
            // ledArrow4
            // 
            this.ledArrow4.LoadingBegin();
            this.ledArrow4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledArrow4.Indicator.BodyLength = 10;
            this.ledArrow4.Location = new System.Drawing.Point(927, 193);
            this.ledArrow4.Name = "ledArrow4";
            this.ledArrow4.Rotation = EazyLab.Types.RotationQuad.X090;
            this.ledArrow4.Size = new System.Drawing.Size(24, 34);
            this.ledArrow4.LoadingEnd();
            // 
            // cbDevice
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbDevice, 3);
            this.cbDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(852, 93);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(176, 21);
            this.cbDevice.TabIndex = 2;
            this.cbDevice.DropDown += new System.EventHandler(this.cbDevice_DropDown);
            this.cbDevice.SelectedIndexChanged += new System.EventHandler(this.cbDevice_SelectedIndexChanged);
            // 
            // cbAnalogInput
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbAnalogInput, 3);
            this.cbAnalogInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAnalogInput.FormattingEnabled = true;
            this.cbAnalogInput.Location = new System.Drawing.Point(852, 233);
            this.cbAnalogInput.Name = "cbAnalogInput";
            this.cbAnalogInput.Size = new System.Drawing.Size(176, 21);
            this.cbAnalogInput.TabIndex = 2;
            this.cbAnalogInput.DropDown += new System.EventHandler(this.cbAnalogInput_DropDown);
            this.cbAnalogInput.SelectedIndexChanged += new System.EventHandler(this.cbAnalogInput_SelectedIndexChanged);
            this.cbAnalogInput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cbAnalogInput_MouseDoubleClick);
            // 
            // buttonApply
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonApply, 3);
            this.buttonApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonApply.Location = new System.Drawing.Point(852, 303);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(176, 24);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // cbDaqTask
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbDaqTask, 3);
            this.cbDaqTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDaqTask.FormattingEnabled = true;
            this.cbDaqTask.Location = new System.Drawing.Point(852, 163);
            this.cbDaqTask.Name = "cbDaqTask";
            this.cbDaqTask.Size = new System.Drawing.Size(176, 21);
            this.cbDaqTask.TabIndex = 2;
            this.cbDaqTask.DropDown += new System.EventHandler(this.cbDaqTask_DropDown);
            this.cbDaqTask.SelectedIndexChanged += new System.EventHandler(this.cbDaqTask_SelectedIndexChanged);
            // 
            // buttonClose
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonClose, 3);
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClose.Location = new System.Drawing.Point(852, 423);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(176, 44);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.LoadingBegin();
            this.label1.AutoSize = false;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(697, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.Text = "Scanning Time";
            this.label1.TextLayout.AlignmentHorizontal.Style = System.Drawing.StringAlignment.Far;
            this.label1.LoadingEnd();
            // 
            // label2
            // 
            this.label2.LoadingBegin();
            this.label2.AutoSize = false;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(697, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.Text = "Comm Channel";
            this.label2.TextLayout.AlignmentHorizontal.Style = System.Drawing.StringAlignment.Far;
            this.label2.LoadingEnd();
            // 
            // label3
            // 
            this.label3.LoadingBegin();
            this.label3.AutoSize = false;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(697, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.Text = "Device";
            this.label3.TextLayout.AlignmentHorizontal.Style = System.Drawing.StringAlignment.Far;
            this.label3.LoadingEnd();
            // 
            // label4
            // 
            this.label4.LoadingBegin();
            this.label4.AutoSize = false;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(697, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.Text = "Daq Task";
            this.label4.TextLayout.AlignmentHorizontal.Style = System.Drawing.StringAlignment.Far;
            this.label4.LoadingEnd();
            // 
            // label5
            // 
            this.label5.LoadingBegin();
            this.label5.AutoSize = false;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(697, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.Text = "Analog Input";
            this.label5.TextLayout.AlignmentHorizontal.Style = System.Drawing.StringAlignment.Far;
            this.label5.LoadingEnd();
            // 
            // label6
            // 
            this.label6.LoadingBegin();
            this.label6.AutoSize = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(697, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.Text = "Scanning Time";
            this.label6.LoadingEnd();
            // 
            // nudScanningTime
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.nudScanningTime, 3);
            this.nudScanningTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudScanningTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudScanningTime.Location = new System.Drawing.Point(852, 363);
            this.nudScanningTime.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.nudScanningTime.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudScanningTime.Name = "nudScanningTime";
            this.nudScanningTime.Size = new System.Drawing.Size(176, 26);
            this.nudScanningTime.TabIndex = 15;
            this.nudScanningTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudScanningTime.ValueChanged += new System.EventHandler(this.nudScanningTime_ValueChanged);
            // 
            // frmStationConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 602);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmStationConfig";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanningTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbCommChannel;
        private System.Windows.Forms.ComboBox cbDevice;
        private System.Windows.Forms.ComboBox cbDaqTask;
        private System.Windows.Forms.ComboBox cbAnalogInput;
        private System.Windows.Forms.Button buttonApply;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow1;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow2;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow3;
        private EazyLab.Instrumentation.Professional.LedArrow ledArrow4;
        private System.Windows.Forms.Button buttonClose;
        private EazyLab.Instrumentation.Standard.Label label1;
        private EazyLab.Instrumentation.Standard.Label label2;
        private EazyLab.Instrumentation.Standard.Label label3;
        private EazyLab.Instrumentation.Standard.Label label4;
        private EazyLab.Instrumentation.Standard.Label label5;
        private EazyLab.Instrumentation.Standard.Label label6;
        private System.Windows.Forms.NumericUpDown nudScanningTime;
    }
}