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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dailyWeatherFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dailyWeatherControl7 = new Weather_Broadcast.DailyWeatherControl();
            this.dailyWeatherControl4 = new Weather_Broadcast.DailyWeatherControl();
            this.dailyWeatherControl5 = new Weather_Broadcast.DailyWeatherControl();
            this.dailyWeatherControl6 = new Weather_Broadcast.DailyWeatherControl();
            this.dailyWeatherControl1 = new Weather_Broadcast.DailyWeatherControl();
            this.dailyWeatherControl2 = new Weather_Broadcast.DailyWeatherControl();
            this.dailyWeatherControl3 = new Weather_Broadcast.DailyWeatherControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainCurrentIcon)).BeginInit();
            this.dailyWeatherFlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMainCurrentIcon
            // 
            this.pbMainCurrentIcon.Location = new System.Drawing.Point(243, 100);
            this.pbMainCurrentIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbMainCurrentIcon.Name = "pbMainCurrentIcon";
            this.pbMainCurrentIcon.Size = new System.Drawing.Size(151, 133);
            this.pbMainCurrentIcon.TabIndex = 0;
            this.pbMainCurrentIcon.TabStop = false;
            // 
            // labelMainCurrentTemp
            // 
            this.labelMainCurrentTemp.AutoSize = true;
            this.labelMainCurrentTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelMainCurrentTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainCurrentTemp.ForeColor = System.Drawing.Color.Black;
            this.labelMainCurrentTemp.Location = new System.Drawing.Point(420, 105);
            this.labelMainCurrentTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMainCurrentTemp.Name = "labelMainCurrentTemp";
            this.labelMainCurrentTemp.Size = new System.Drawing.Size(94, 33);
            this.labelMainCurrentTemp.TabIndex = 1;
            this.labelMainCurrentTemp.Text = "Temp";
            // 
            // labelMainCurrentDescription
            // 
            this.labelMainCurrentDescription.AutoSize = true;
            this.labelMainCurrentDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelMainCurrentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainCurrentDescription.ForeColor = System.Drawing.Color.Black;
            this.labelMainCurrentDescription.Location = new System.Drawing.Point(420, 173);
            this.labelMainCurrentDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMainCurrentDescription.Name = "labelMainCurrentDescription";
            this.labelMainCurrentDescription.Size = new System.Drawing.Size(173, 33);
            this.labelMainCurrentDescription.TabIndex = 2;
            this.labelMainCurrentDescription.Text = "Description";
            // 
            // labelMainCity
            // 
            this.labelMainCity.AutoSize = true;
            this.labelMainCity.BackColor = System.Drawing.Color.Transparent;
            this.labelMainCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainCity.ForeColor = System.Drawing.Color.Black;
            this.labelMainCity.Location = new System.Drawing.Point(287, 38);
            this.labelMainCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMainCity.Name = "labelMainCity";
            this.labelMainCity.Size = new System.Drawing.Size(66, 33);
            this.labelMainCity.TabIndex = 3;
            this.labelMainCity.Text = "City";
            this.labelMainCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Refresh
            // 
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Refresh.Location = new System.Drawing.Point(727, 21);
            this.Refresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(86, 52);
            this.Refresh.TabIndex = 6;
            this.Refresh.Text = "⟳";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Calgary"});
            this.comboBox1.Location = new System.Drawing.Point(650, 105);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(32, 38);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(63, 29);
            this.labelDate.TabIndex = 21;
            this.labelDate.Text = "Date";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dailyWeatherFlowPanel
            // 
            this.dailyWeatherFlowPanel.AutoScroll = true;
            this.dailyWeatherFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dailyWeatherFlowPanel.Controls.Add(this.dailyWeatherControl7);
            this.dailyWeatherFlowPanel.Controls.Add(this.dailyWeatherControl4);
            this.dailyWeatherFlowPanel.Controls.Add(this.dailyWeatherControl5);
            this.dailyWeatherFlowPanel.Controls.Add(this.dailyWeatherControl6);
            this.dailyWeatherFlowPanel.Location = new System.Drawing.Point(22, 362);
            this.dailyWeatherFlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dailyWeatherFlowPanel.Name = "dailyWeatherFlowPanel";
            this.dailyWeatherFlowPanel.Size = new System.Drawing.Size(791, 248);
            this.dailyWeatherFlowPanel.TabIndex = 22;
            // 
            // dailyWeatherControl7
            // 
            this.dailyWeatherControl7.BackColor = System.Drawing.SystemColors.Control;
            this.dailyWeatherControl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyWeatherControl7.Date = "11/11";
            this.dailyWeatherControl7.Location = new System.Drawing.Point(25, 25);
            this.dailyWeatherControl7.Margin = new System.Windows.Forms.Padding(25);
            this.dailyWeatherControl7.Name = "dailyWeatherControl7";
            this.dailyWeatherControl7.Size = new System.Drawing.Size(342, 418);
            this.dailyWeatherControl7.TabIndex = 3;
            this.dailyWeatherControl7.TempC = "12 º C";
            this.dailyWeatherControl7.WeatherDescription = "A mix of sun and clouds";
            this.dailyWeatherControl7.WeatherIcon = null;
            this.dailyWeatherControl7.WeekDayTitle = "SUNDAY";
            // 
            // dailyWeatherControl4
            // 
            this.dailyWeatherControl4.BackColor = System.Drawing.SystemColors.Control;
            this.dailyWeatherControl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyWeatherControl4.Date = "11/11";
            this.dailyWeatherControl4.Location = new System.Drawing.Point(417, 25);
            this.dailyWeatherControl4.Margin = new System.Windows.Forms.Padding(25);
            this.dailyWeatherControl4.Name = "dailyWeatherControl4";
            this.dailyWeatherControl4.Size = new System.Drawing.Size(342, 418);
            this.dailyWeatherControl4.TabIndex = 0;
            this.dailyWeatherControl4.TempC = "12 º C";
            this.dailyWeatherControl4.WeatherDescription = "A mix of sun and clouds";
            this.dailyWeatherControl4.WeatherIcon = null;
            this.dailyWeatherControl4.WeekDayTitle = "SUNDAY";
            // 
            // dailyWeatherControl5
            // 
            this.dailyWeatherControl5.BackColor = System.Drawing.SystemColors.Control;
            this.dailyWeatherControl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyWeatherControl5.Date = "11/11";
            this.dailyWeatherControl5.Location = new System.Drawing.Point(25, 493);
            this.dailyWeatherControl5.Margin = new System.Windows.Forms.Padding(25);
            this.dailyWeatherControl5.Name = "dailyWeatherControl5";
            this.dailyWeatherControl5.Size = new System.Drawing.Size(342, 418);
            this.dailyWeatherControl5.TabIndex = 1;
            this.dailyWeatherControl5.TempC = "12 º C";
            this.dailyWeatherControl5.WeatherDescription = "A mix of sun and clouds";
            this.dailyWeatherControl5.WeatherIcon = null;
            this.dailyWeatherControl5.WeekDayTitle = "SUNDAY";
            // 
            // dailyWeatherControl6
            // 
            this.dailyWeatherControl6.BackColor = System.Drawing.SystemColors.Control;
            this.dailyWeatherControl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyWeatherControl6.Date = "11/11";
            this.dailyWeatherControl6.Location = new System.Drawing.Point(417, 493);
            this.dailyWeatherControl6.Margin = new System.Windows.Forms.Padding(25);
            this.dailyWeatherControl6.Name = "dailyWeatherControl6";
            this.dailyWeatherControl6.Size = new System.Drawing.Size(342, 418);
            this.dailyWeatherControl6.TabIndex = 2;
            this.dailyWeatherControl6.TempC = "12 º C";
            this.dailyWeatherControl6.WeatherDescription = "A mix of sun and clouds";
            this.dailyWeatherControl6.WeatherIcon = null;
            this.dailyWeatherControl6.WeekDayTitle = "SUNDAY";
            // 
            // dailyWeatherControl1
            // 
            this.dailyWeatherControl1.BackColor = System.Drawing.SystemColors.Control;
            this.dailyWeatherControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyWeatherControl1.Date = "11/11";
            this.dailyWeatherControl1.Location = new System.Drawing.Point(30, 30);
            this.dailyWeatherControl1.Margin = new System.Windows.Forms.Padding(30);
            this.dailyWeatherControl1.Name = "dailyWeatherControl1";
            this.dailyWeatherControl1.Size = new System.Drawing.Size(342, 418);
            this.dailyWeatherControl1.TabIndex = 0;
            this.dailyWeatherControl1.TempC = "12 º C";
            this.dailyWeatherControl1.WeatherDescription = "A mix of sun and clouds";
            this.dailyWeatherControl1.WeatherIcon = null;
            this.dailyWeatherControl1.WeekDayTitle = "SUNDAY";
            // 
            // dailyWeatherControl2
            // 
            this.dailyWeatherControl2.BackColor = System.Drawing.SystemColors.Control;
            this.dailyWeatherControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyWeatherControl2.Date = "11/11";
            this.dailyWeatherControl2.Location = new System.Drawing.Point(432, 30);
            this.dailyWeatherControl2.Margin = new System.Windows.Forms.Padding(30);
            this.dailyWeatherControl2.Name = "dailyWeatherControl2";
            this.dailyWeatherControl2.Size = new System.Drawing.Size(342, 418);
            this.dailyWeatherControl2.TabIndex = 1;
            this.dailyWeatherControl2.TempC = "12 º C";
            this.dailyWeatherControl2.WeatherDescription = "A mix of sun and clouds";
            this.dailyWeatherControl2.WeatherIcon = null;
            this.dailyWeatherControl2.WeekDayTitle = "SUNDAY";
            // 
            // dailyWeatherControl3
            // 
            this.dailyWeatherControl3.BackColor = System.Drawing.SystemColors.Control;
            this.dailyWeatherControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyWeatherControl3.Date = "11/11";
            this.dailyWeatherControl3.Location = new System.Drawing.Point(834, 30);
            this.dailyWeatherControl3.Margin = new System.Windows.Forms.Padding(30);
            this.dailyWeatherControl3.Name = "dailyWeatherControl3";
            this.dailyWeatherControl3.Size = new System.Drawing.Size(342, 418);
            this.dailyWeatherControl3.TabIndex = 2;
            this.dailyWeatherControl3.TempC = "12 º C";
            this.dailyWeatherControl3.WeatherDescription = "A mix of sun and clouds";
            this.dailyWeatherControl3.WeatherIcon = null;
            this.dailyWeatherControl3.WeekDayTitle = "SUNDAY";
            // 
            // MainWeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 812);
            this.Controls.Add(this.dailyWeatherFlowPanel);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.labelMainCity);
            this.Controls.Add(this.labelMainCurrentDescription);
            this.Controls.Add(this.labelMainCurrentTemp);
            this.Controls.Add(this.pbMainCurrentIcon);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWeatherForm";
            this.Text = "Weather";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainCurrentIcon)).EndInit();
            this.dailyWeatherFlowPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainCurrentIcon;
        private System.Windows.Forms.Label labelMainCurrentTemp;
        private System.Windows.Forms.Label labelMainCurrentDescription;
        private System.Windows.Forms.Label labelMainCity;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.FlowLayoutPanel dailyWeatherFlowPanel;
        private DailyWeatherControl dailyWeatherControl1;
        private DailyWeatherControl dailyWeatherControl2;
        private DailyWeatherControl dailyWeatherControl3;
        private DailyWeatherControl dailyWeatherControl7;
        private DailyWeatherControl dailyWeatherControl4;
        private DailyWeatherControl dailyWeatherControl5;
        private DailyWeatherControl dailyWeatherControl6;
    }
}