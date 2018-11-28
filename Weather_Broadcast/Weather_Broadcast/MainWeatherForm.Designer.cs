namespace Weather_Broadcast
{
    partial class MainWeatherForm
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
            this.pbMainCurrentIcon = new System.Windows.Forms.PictureBox();
            this.labelMainCurrentTemp = new System.Windows.Forms.Label();
            this.labelMainCurrentDescription = new System.Windows.Forms.Label();
            this.labelMainCity = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.dailyWeatherControl1 = new Weather_Broadcast.DailyWeatherControl();
            this.dailyWeatherControl2 = new Weather_Broadcast.DailyWeatherControl();
            this.dailyWeatherControl3 = new Weather_Broadcast.DailyWeatherControl();
            this.weatherForecastPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dailyDetailsControl1 = new Weather_Broadcast.DailyDetailsControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainCurrentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMainCurrentIcon
            // 
            this.pbMainCurrentIcon.Location = new System.Drawing.Point(552, 202);
            this.pbMainCurrentIcon.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pbMainCurrentIcon.Name = "pbMainCurrentIcon";
            this.pbMainCurrentIcon.Size = new System.Drawing.Size(230, 194);
            this.pbMainCurrentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMainCurrentIcon.TabIndex = 0;
            this.pbMainCurrentIcon.TabStop = false;
            // 
            // labelMainCurrentTemp
            // 
            this.labelMainCurrentTemp.AutoSize = true;
            this.labelMainCurrentTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelMainCurrentTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainCurrentTemp.ForeColor = System.Drawing.Color.Black;
            this.labelMainCurrentTemp.Location = new System.Drawing.Point(840, 202);
            this.labelMainCurrentTemp.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelMainCurrentTemp.Name = "labelMainCurrentTemp";
            this.labelMainCurrentTemp.Size = new System.Drawing.Size(180, 67);
            this.labelMainCurrentTemp.TabIndex = 1;
            this.labelMainCurrentTemp.Text = "Temp";
            // 
            // labelMainCurrentDescription
            // 
            this.labelMainCurrentDescription.AutoSize = true;
            this.labelMainCurrentDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelMainCurrentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainCurrentDescription.ForeColor = System.Drawing.Color.Black;
            this.labelMainCurrentDescription.Location = new System.Drawing.Point(840, 331);
            this.labelMainCurrentDescription.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelMainCurrentDescription.Name = "labelMainCurrentDescription";
            this.labelMainCurrentDescription.Size = new System.Drawing.Size(329, 67);
            this.labelMainCurrentDescription.TabIndex = 2;
            this.labelMainCurrentDescription.Text = "Description";
            // 
            // labelMainCity
            // 
            this.labelMainCity.AutoSize = true;
            this.labelMainCity.BackColor = System.Drawing.Color.Transparent;
            this.labelMainCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainCity.ForeColor = System.Drawing.Color.Black;
            this.labelMainCity.Location = new System.Drawing.Point(544, 73);
            this.labelMainCity.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelMainCity.Name = "labelMainCity";
            this.labelMainCity.Size = new System.Drawing.Size(129, 67);
            this.labelMainCity.TabIndex = 3;
            this.labelMainCity.Text = "City";
            this.labelMainCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Refresh
            // 
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Refresh.Location = new System.Drawing.Point(1454, 41);
            this.Refresh.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(172, 100);
            this.Refresh.TabIndex = 6;
            this.Refresh.Text = "⟳";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(64, 73);
            this.labelDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(126, 55);
            this.labelDate.TabIndex = 21;
            this.labelDate.Text = "Date";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            // 
            // weatherForecastPanel
            // 
            this.weatherForecastPanel.Location = new System.Drawing.Point(46, 706);
            this.weatherForecastPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.weatherForecastPanel.Name = "weatherForecastPanel";
            this.weatherForecastPanel.Size = new System.Drawing.Size(2146, 506);
            this.weatherForecastPanel.TabIndex = 22;
            // 
            // dailyDetailsControl1
            // 
            this.dailyDetailsControl1.HumidityValue = "0%";
            this.dailyDetailsControl1.Location = new System.Drawing.Point(74, 1244);
            this.dailyDetailsControl1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.dailyDetailsControl1.MoonRiseTimeValue = "Time";
            this.dailyDetailsControl1.MoonSetTimeValue = "Time";
            this.dailyDetailsControl1.Name = "dailyDetailsControl1";
            this.dailyDetailsControl1.PrecipitationValue = "0%";
            this.dailyDetailsControl1.Size = new System.Drawing.Size(1938, 634);
            this.dailyDetailsControl1.SunRiseTimeValue = "Time";
            this.dailyDetailsControl1.SunSetTimeValue = "Time";
            this.dailyDetailsControl1.TabIndex = 23;
            this.dailyDetailsControl1.UVValue = "0";
            this.dailyDetailsControl1.WindValue = "0km/h KM/H KM/H KM/H KM/H KM/H KM/H";
            // 
            // MainWeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2236, 1648);
            this.Controls.Add(this.dailyDetailsControl1);
            this.Controls.Add(this.weatherForecastPanel);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.labelMainCity);
            this.Controls.Add(this.labelMainCurrentDescription);
            this.Controls.Add(this.labelMainCurrentTemp);
            this.Controls.Add(this.pbMainCurrentIcon);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "MainWeatherForm";
            this.Text = "Weather";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainCurrentIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainCurrentIcon;
        private System.Windows.Forms.Label labelMainCurrentTemp;
        private System.Windows.Forms.Label labelMainCurrentDescription;
        private System.Windows.Forms.Label labelMainCity;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label labelDate;
        private DailyWeatherControl dailyWeatherControl1;
        private DailyWeatherControl dailyWeatherControl2;
        private DailyWeatherControl dailyWeatherControl3;
        private System.Windows.Forms.FlowLayoutPanel weatherForecastPanel;
        private DailyDetailsControl dailyDetailsControl1;
    }
}