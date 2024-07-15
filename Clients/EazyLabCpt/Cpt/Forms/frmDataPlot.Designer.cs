namespace Client.Forms
{
    partial class frmDataPlot
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxInDoorDbt = new System.Windows.Forms.CheckBox();
            this.checkBoxIndoorWbt = new System.Windows.Forms.CheckBox();
            this.checkBoxInDoorHum = new System.Windows.Forms.CheckBox();
            this.checkBoxVolt = new System.Windows.Forms.CheckBox();
            this.checkBoxCurrent = new System.Windows.Forms.CheckBox();
            this.checkBoxPower = new System.Windows.Forms.CheckBox();
            this.checkBoxPowerFactor = new System.Windows.Forms.CheckBox();
            this.checkBoxCtDbt = new System.Windows.Forms.CheckBox();
            this.checkBoxCtWbt = new System.Windows.Forms.CheckBox();
            this.checkBoxCtCoolingCap = new System.Windows.Forms.CheckBox();
            this.checkBoxCtStaticPress = new System.Windows.Forms.CheckBox();
            this.checkBoxCtNozzlePress = new System.Windows.Forms.CheckBox();
            this.checkBoxAirFlow = new System.Windows.Forms.CheckBox();
            this.checkBoxBarPress = new System.Windows.Forms.CheckBox();
            this.checkBoxOutDoorDbt = new System.Windows.Forms.CheckBox();
            this.checkBoxOutDoorWbt = new System.Windows.Forms.CheckBox();
            this.checkBoxOutDoorHum = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timerPlot = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66708F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66708F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66708F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66542F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Controls.Add(this.checkBoxInDoorDbt, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxIndoorWbt, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxInDoorHum, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxVolt, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxCurrent, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxPower, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxPowerFactor, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxCtDbt, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxCtWbt, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxCtCoolingCap, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxCtStaticPress, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxCtNozzlePress, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxAirFlow, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxBarPress, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxOutDoorDbt, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxOutDoorWbt, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxOutDoorHum, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.button2, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 5, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 500);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99001F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99001F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.02998F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1250, 150);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // checkBoxInDoorDbt
            // 
            this.checkBoxInDoorDbt.AutoSize = true;
            this.checkBoxInDoorDbt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxInDoorDbt.Location = new System.Drawing.Point(3, 3);
            this.checkBoxInDoorDbt.Name = "checkBoxInDoorDbt";
            this.checkBoxInDoorDbt.Size = new System.Drawing.Size(202, 23);
            this.checkBoxInDoorDbt.TabIndex = 0;
            this.checkBoxInDoorDbt.Text = "InDoor DBT";
            this.checkBoxInDoorDbt.UseVisualStyleBackColor = true;
            this.checkBoxInDoorDbt.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxIndoorWbt
            // 
            this.checkBoxIndoorWbt.AutoSize = true;
            this.checkBoxIndoorWbt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxIndoorWbt.Location = new System.Drawing.Point(3, 32);
            this.checkBoxIndoorWbt.Name = "checkBoxIndoorWbt";
            this.checkBoxIndoorWbt.Size = new System.Drawing.Size(202, 23);
            this.checkBoxIndoorWbt.TabIndex = 0;
            this.checkBoxIndoorWbt.Text = "InDoor WBT";
            this.checkBoxIndoorWbt.UseVisualStyleBackColor = true;
            this.checkBoxIndoorWbt.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxInDoorHum
            // 
            this.checkBoxInDoorHum.AutoSize = true;
            this.checkBoxInDoorHum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxInDoorHum.Location = new System.Drawing.Point(3, 61);
            this.checkBoxInDoorHum.Name = "checkBoxInDoorHum";
            this.checkBoxInDoorHum.Size = new System.Drawing.Size(202, 23);
            this.checkBoxInDoorHum.TabIndex = 0;
            this.checkBoxInDoorHum.Text = "InDoor Hum";
            this.checkBoxInDoorHum.UseVisualStyleBackColor = true;
            this.checkBoxInDoorHum.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxVolt
            // 
            this.checkBoxVolt.AutoSize = true;
            this.checkBoxVolt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxVolt.Location = new System.Drawing.Point(211, 3);
            this.checkBoxVolt.Name = "checkBoxVolt";
            this.checkBoxVolt.Size = new System.Drawing.Size(202, 23);
            this.checkBoxVolt.TabIndex = 0;
            this.checkBoxVolt.Text = "Volt";
            this.checkBoxVolt.UseVisualStyleBackColor = true;
            this.checkBoxVolt.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxCurrent
            // 
            this.checkBoxCurrent.AutoSize = true;
            this.checkBoxCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxCurrent.Location = new System.Drawing.Point(211, 32);
            this.checkBoxCurrent.Name = "checkBoxCurrent";
            this.checkBoxCurrent.Size = new System.Drawing.Size(202, 23);
            this.checkBoxCurrent.TabIndex = 0;
            this.checkBoxCurrent.Text = "Current";
            this.checkBoxCurrent.UseVisualStyleBackColor = true;
            this.checkBoxCurrent.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxPower
            // 
            this.checkBoxPower.AutoSize = true;
            this.checkBoxPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxPower.Location = new System.Drawing.Point(211, 61);
            this.checkBoxPower.Name = "checkBoxPower";
            this.checkBoxPower.Size = new System.Drawing.Size(202, 23);
            this.checkBoxPower.TabIndex = 0;
            this.checkBoxPower.Text = "Power";
            this.checkBoxPower.UseVisualStyleBackColor = true;
            this.checkBoxPower.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxPowerFactor
            // 
            this.checkBoxPowerFactor.AutoSize = true;
            this.checkBoxPowerFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxPowerFactor.Location = new System.Drawing.Point(211, 90);
            this.checkBoxPowerFactor.Name = "checkBoxPowerFactor";
            this.checkBoxPowerFactor.Size = new System.Drawing.Size(202, 24);
            this.checkBoxPowerFactor.TabIndex = 0;
            this.checkBoxPowerFactor.Text = "Power Factor";
            this.checkBoxPowerFactor.UseVisualStyleBackColor = true;
            this.checkBoxPowerFactor.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxCtDbt
            // 
            this.checkBoxCtDbt.AutoSize = true;
            this.checkBoxCtDbt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxCtDbt.Location = new System.Drawing.Point(419, 3);
            this.checkBoxCtDbt.Name = "checkBoxCtDbt";
            this.checkBoxCtDbt.Size = new System.Drawing.Size(202, 23);
            this.checkBoxCtDbt.TabIndex = 0;
            this.checkBoxCtDbt.Text = "Ct DBT";
            this.checkBoxCtDbt.UseVisualStyleBackColor = true;
            this.checkBoxCtDbt.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxCtWbt
            // 
            this.checkBoxCtWbt.AutoSize = true;
            this.checkBoxCtWbt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxCtWbt.Location = new System.Drawing.Point(419, 32);
            this.checkBoxCtWbt.Name = "checkBoxCtWbt";
            this.checkBoxCtWbt.Size = new System.Drawing.Size(202, 23);
            this.checkBoxCtWbt.TabIndex = 0;
            this.checkBoxCtWbt.Text = "Ct WBT";
            this.checkBoxCtWbt.UseVisualStyleBackColor = true;
            this.checkBoxCtWbt.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxCtCoolingCap
            // 
            this.checkBoxCtCoolingCap.AutoSize = true;
            this.checkBoxCtCoolingCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxCtCoolingCap.Location = new System.Drawing.Point(419, 61);
            this.checkBoxCtCoolingCap.Name = "checkBoxCtCoolingCap";
            this.checkBoxCtCoolingCap.Size = new System.Drawing.Size(202, 23);
            this.checkBoxCtCoolingCap.TabIndex = 0;
            this.checkBoxCtCoolingCap.Text = "Ct Cooling Cap.";
            this.checkBoxCtCoolingCap.UseVisualStyleBackColor = true;
            this.checkBoxCtCoolingCap.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxCtStaticPress
            // 
            this.checkBoxCtStaticPress.AutoSize = true;
            this.checkBoxCtStaticPress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxCtStaticPress.Location = new System.Drawing.Point(627, 3);
            this.checkBoxCtStaticPress.Name = "checkBoxCtStaticPress";
            this.checkBoxCtStaticPress.Size = new System.Drawing.Size(202, 23);
            this.checkBoxCtStaticPress.TabIndex = 0;
            this.checkBoxCtStaticPress.Text = "Ct Static Press";
            this.checkBoxCtStaticPress.UseVisualStyleBackColor = true;
            this.checkBoxCtStaticPress.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxCtNozzlePress
            // 
            this.checkBoxCtNozzlePress.AutoSize = true;
            this.checkBoxCtNozzlePress.Location = new System.Drawing.Point(627, 32);
            this.checkBoxCtNozzlePress.Name = "checkBoxCtNozzlePress";
            this.checkBoxCtNozzlePress.Size = new System.Drawing.Size(155, 23);
            this.checkBoxCtNozzlePress.TabIndex = 0;
            this.checkBoxCtNozzlePress.Text = "Ct Nozzle Press";
            this.checkBoxCtNozzlePress.UseVisualStyleBackColor = true;
            this.checkBoxCtNozzlePress.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxAirFlow
            // 
            this.checkBoxAirFlow.AutoSize = true;
            this.checkBoxAirFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxAirFlow.Location = new System.Drawing.Point(627, 61);
            this.checkBoxAirFlow.Name = "checkBoxAirFlow";
            this.checkBoxAirFlow.Size = new System.Drawing.Size(202, 23);
            this.checkBoxAirFlow.TabIndex = 0;
            this.checkBoxAirFlow.Text = "Air Flow";
            this.checkBoxAirFlow.UseVisualStyleBackColor = true;
            this.checkBoxAirFlow.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxBarPress
            // 
            this.checkBoxBarPress.AutoSize = true;
            this.checkBoxBarPress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBarPress.Location = new System.Drawing.Point(627, 90);
            this.checkBoxBarPress.Name = "checkBoxBarPress";
            this.checkBoxBarPress.Size = new System.Drawing.Size(202, 24);
            this.checkBoxBarPress.TabIndex = 0;
            this.checkBoxBarPress.Text = "Barometric Press";
            this.checkBoxBarPress.UseVisualStyleBackColor = true;
            this.checkBoxBarPress.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxOutDoorDbt
            // 
            this.checkBoxOutDoorDbt.AutoSize = true;
            this.checkBoxOutDoorDbt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxOutDoorDbt.Location = new System.Drawing.Point(835, 3);
            this.checkBoxOutDoorDbt.Name = "checkBoxOutDoorDbt";
            this.checkBoxOutDoorDbt.Size = new System.Drawing.Size(202, 23);
            this.checkBoxOutDoorDbt.TabIndex = 0;
            this.checkBoxOutDoorDbt.Text = "OutDoor DBT";
            this.checkBoxOutDoorDbt.UseVisualStyleBackColor = true;
            this.checkBoxOutDoorDbt.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxOutDoorWbt
            // 
            this.checkBoxOutDoorWbt.AutoSize = true;
            this.checkBoxOutDoorWbt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxOutDoorWbt.Location = new System.Drawing.Point(835, 32);
            this.checkBoxOutDoorWbt.Name = "checkBoxOutDoorWbt";
            this.checkBoxOutDoorWbt.Size = new System.Drawing.Size(202, 23);
            this.checkBoxOutDoorWbt.TabIndex = 0;
            this.checkBoxOutDoorWbt.Text = "OutDoor WBT";
            this.checkBoxOutDoorWbt.UseVisualStyleBackColor = true;
            this.checkBoxOutDoorWbt.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxOutDoorHum
            // 
            this.checkBoxOutDoorHum.AutoSize = true;
            this.checkBoxOutDoorHum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxOutDoorHum.Location = new System.Drawing.Point(835, 61);
            this.checkBoxOutDoorHum.Name = "checkBoxOutDoorHum";
            this.checkBoxOutDoorHum.Size = new System.Drawing.Size(202, 23);
            this.checkBoxOutDoorHum.TabIndex = 0;
            this.checkBoxOutDoorHum.Text = "OutDoor Hum";
            this.checkBoxOutDoorHum.UseVisualStyleBackColor = true;
            this.checkBoxOutDoorHum.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(1043, 3);
            this.button2.Name = "button2";
            this.tableLayoutPanel3.SetRowSpan(this.button2, 2);
            this.button2.Size = new System.Drawing.Size(204, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(1043, 61);
            this.button3.Name = "button3";
            this.tableLayoutPanel3.SetRowSpan(this.button3, 2);
            this.button3.Size = new System.Drawing.Size(204, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timerPlot
            // 
            this.timerPlot.Enabled = true;
            this.timerPlot.Interval = 60000;
            this.timerPlot.Tick += new System.EventHandler(this.timerPlot_Tick);
            // 
            // frmDataPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 687);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmDataPlot";
            this.Text = "DataPlot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DataPlot_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBoxInDoorDbt;
        private System.Windows.Forms.CheckBox checkBoxIndoorWbt;
        private System.Windows.Forms.CheckBox checkBoxInDoorHum;
        private System.Windows.Forms.CheckBox checkBoxVolt;
        private System.Windows.Forms.CheckBox checkBoxCurrent;
        private System.Windows.Forms.CheckBox checkBoxPower;
        private System.Windows.Forms.CheckBox checkBoxPowerFactor;
        private System.Windows.Forms.CheckBox checkBoxCtDbt;
        private System.Windows.Forms.CheckBox checkBoxCtWbt;
        private System.Windows.Forms.CheckBox checkBoxCtCoolingCap;
        private System.Windows.Forms.CheckBox checkBoxCtStaticPress;
        private System.Windows.Forms.CheckBox checkBoxCtNozzlePress;
        private System.Windows.Forms.CheckBox checkBoxAirFlow;
        private System.Windows.Forms.CheckBox checkBoxBarPress;
        private System.Windows.Forms.CheckBox checkBoxOutDoorDbt;
        private System.Windows.Forms.CheckBox checkBoxOutDoorWbt;
        private System.Windows.Forms.CheckBox checkBoxOutDoorHum;
        private System.Windows.Forms.Timer timerPlot;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}