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
            this.DayNameLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.WeatherDescriptionLabel = new System.Windows.Forms.Label();
            this.WeatherIconPictureBox = new System.Windows.Forms.PictureBox();
            this.TempDailyBoxLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIconPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DayNameLabel
            // 
            this.DayNameLabel.AutoSize = true;
            this.DayNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayNameLabel.Location = new System.Drawing.Point(127, 28);
            this.DayNameLabel.Name = "DayNameLabel";
            this.DayNameLabel.Size = new System.Drawing.Size(180, 42);
            this.DayNameLabel.TabIndex = 0;
            this.DayNameLabel.Text = "SUNDAY";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(144, 134);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(130, 51);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "11/11";
            // 
            // WeatherDescriptionLabel
            // 
            this.WeatherDescriptionLabel.AutoSize = true;
            this.WeatherDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherDescriptionLabel.Location = new System.Drawing.Point(57, 213);
            this.WeatherDescriptionLabel.Name = "WeatherDescriptionLabel";
            this.WeatherDescriptionLabel.Size = new System.Drawing.Size(359, 37);
            this.WeatherDescriptionLabel.TabIndex = 2;
            this.WeatherDescriptionLabel.Text = "A mix of sun and clouds";
            // 
            // WeatherIconPictureBox
            // 
            this.WeatherIconPictureBox.Location = new System.Drawing.Point(137, 278);
            this.WeatherIconPictureBox.Name = "WeatherIconPictureBox";
            this.WeatherIconPictureBox.Size = new System.Drawing.Size(157, 122);
            this.WeatherIconPictureBox.TabIndex = 3;
            this.WeatherIconPictureBox.TabStop = false;
            // 
            // TempDailyBoxLabel
            // 
            this.TempDailyBoxLabel.AutoSize = true;
            this.TempDailyBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempDailyBoxLabel.Location = new System.Drawing.Point(127, 439);
            this.TempDailyBoxLabel.Name = "TempDailyBoxLabel";
            this.TempDailyBoxLabel.Size = new System.Drawing.Size(176, 61);
            this.TempDailyBoxLabel.TabIndex = 4;
            this.TempDailyBoxLabel.Text = "12 º C";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.DayNameLabel);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 99);
            this.panel1.TabIndex = 5;
            // 
            // DailyWeatherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TempDailyBoxLabel);
            this.Controls.Add(this.WeatherIconPictureBox);
            this.Controls.Add(this.WeatherDescriptionLabel);
            this.Controls.Add(this.DateLabel);
            this.Name = "DailyWeatherControl";
            this.Size = new System.Drawing.Size(460, 538);
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIconPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DayNameLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label WeatherDescriptionLabel;
        private System.Windows.Forms.PictureBox WeatherIconPictureBox;
        private System.Windows.Forms.Label TempDailyBoxLabel;
        private System.Windows.Forms.Panel panel1;
    }
}
