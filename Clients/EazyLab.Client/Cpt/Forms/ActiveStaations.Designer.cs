namespace EazyLab.Client.Forms
{
    partial class ActiveStaations
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
            this.CB2 = new System.Windows.Forms.CheckBox();
            this.CB1 = new System.Windows.Forms.CheckBox();
            this.CB4 = new System.Windows.Forms.CheckBox();
            this.CB3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB2
            // 
            this.CB2.AutoSize = true;
            this.CB2.Enabled = false;
            this.CB2.Location = new System.Drawing.Point(323, 66);
            this.CB2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB2.Name = "CB2";
            this.CB2.Size = new System.Drawing.Size(144, 20);
            this.CB2.TabIndex = 0;
            this.CB2.Text = "Station in Position 2";
            this.CB2.UseVisualStyleBackColor = true;
            // 
            // CB1
            // 
            this.CB1.AutoSize = true;
            this.CB1.Enabled = false;
            this.CB1.Location = new System.Drawing.Point(113, 66);
            this.CB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(144, 20);
            this.CB1.TabIndex = 1;
            this.CB1.Text = "Station in Position 1";
            this.CB1.UseVisualStyleBackColor = true;
            // 
            // CB4
            // 
            this.CB4.AutoSize = true;
            this.CB4.Enabled = false;
            this.CB4.Location = new System.Drawing.Point(323, 95);
            this.CB4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB4.Name = "CB4";
            this.CB4.Size = new System.Drawing.Size(144, 20);
            this.CB4.TabIndex = 0;
            this.CB4.Text = "Station in Position 4";
            this.CB4.UseVisualStyleBackColor = true;
            // 
            // CB3
            // 
            this.CB3.AutoSize = true;
            this.CB3.Enabled = false;
            this.CB3.Location = new System.Drawing.Point(113, 95);
            this.CB3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB3.Name = "CB3";
            this.CB3.Size = new System.Drawing.Size(144, 20);
            this.CB3.TabIndex = 1;
            this.CB3.Text = "Station in Position 3";
            this.CB3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Stations To start Test :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 123);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ActiveStaations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 187);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB3);
            this.Controls.Add(this.CB4);
            this.Controls.Add(this.CB1);
            this.Controls.Add(this.CB2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ActiveStaations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActiveStaations";
            this.Load += new System.EventHandler(this.ActiveStaations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB2;
        private System.Windows.Forms.CheckBox CB1;
        private System.Windows.Forms.CheckBox CB4;
        private System.Windows.Forms.CheckBox CB3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}