namespace Weather_Broadcast
{
    partial class DailyWeatherControl
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
            this.WeekDayLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.WeatherDescriptionLabel = new System.Windows.Forms.Label();
            this.WeatherIconPictureBox = new System.Windows.Forms.PictureBox();
            this.TempDailyBoxLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIconPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeekDayLabel
            // 
            this.WeekDayLabel.AutoSize = true;
            this.WeekDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekDayLabel.Location = new System.Drawing.Point(40, 19);
            this.WeekDayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeekDayLabel.Name = "WeekDayLabel";
            this.WeekDayLabel.Size = new System.Drawing.Size(83, 20);
            this.WeekDayLabel.TabIndex = 0;
            this.WeekDayLabel.Text = "SUNDAY";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(43, 60);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(0, 18);
            this.DateLabel.TabIndex = 1;
            // 
            // WeatherDescriptionLabel
            // 
            this.WeatherDescriptionLabel.AutoSize = true;
            this.WeatherDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherDescriptionLabel.Location = new System.Drawing.Point(2, 0);
            this.WeatherDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeatherDescriptionLabel.Name = "WeatherDescriptionLabel";
            this.WeatherDescriptionLabel.Size = new System.Drawing.Size(142, 40);
            this.WeatherDescriptionLabel.TabIndex = 2;
            this.WeatherDescriptionLabel.Text = "A mix of sun and clouds";
            // 
            // WeatherIconPictureBox
            // 
            this.WeatherIconPictureBox.Location = new System.Drawing.Point(50, 136);
            this.WeatherIconPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeatherIconPictureBox.Name = "WeatherIconPictureBox";
            this.WeatherIconPictureBox.Size = new System.Drawing.Size(64, 51);
            this.WeatherIconPictureBox.TabIndex = 3;
            this.WeatherIconPictureBox.TabStop = false;
            // 
            // TempDailyBoxLabel
            // 
            this.TempDailyBoxLabel.AutoSize = true;
            this.TempDailyBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempDailyBoxLabel.Location = new System.Drawing.Point(39, 199);
            this.TempDailyBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TempDailyBoxLabel.Name = "TempDailyBoxLabel";
            this.TempDailyBoxLabel.Size = new System.Drawing.Size(94, 31);
            this.TempDailyBoxLabel.TabIndex = 4;
            this.TempDailyBoxLabel.Text = "12 º C";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.WeekDayLabel);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 57);
            this.panel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.WeatherDescriptionLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(149, 42);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // DailyWeatherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TempDailyBoxLabel);
            this.Controls.Add(this.WeatherIconPictureBox);
            this.Controls.Add(this.DateLabel);
            this.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Name = "DailyWeatherControl";
            this.Size = new System.Drawing.Size(171, 245);
            this.Load += new System.EventHandler(this.DailyWeatherControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIconPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeekDayLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label WeatherDescriptionLabel;
        private System.Windows.Forms.PictureBox WeatherIconPictureBox;
        private System.Windows.Forms.Label TempDailyBoxLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
