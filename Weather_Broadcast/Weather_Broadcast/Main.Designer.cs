namespace Weather_Broadcast
{
    partial class Main
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
            this.labelDaily = new System.Windows.Forms.Label();
            this.panelDailyInfo = new System.Windows.Forms.Panel();
            this.labelDailyDate = new System.Windows.Forms.Label();
            this.DailyDesription = new System.Windows.Forms.Label();
            this.labelDailyTemp = new System.Windows.Forms.Label();
            this.pbDailyIcon = new System.Windows.Forms.PictureBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.DayDetail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SunRise = new System.Windows.Forms.Label();
            this.SunSet = new System.Windows.Forms.Label();
            this.Precipitation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.Wind = new System.Windows.Forms.Label();
            this.UV = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainCurrentIcon)).BeginInit();
            this.panelDailyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDailyIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMainCurrentIcon
            // 
            this.pbMainCurrentIcon.Location = new System.Drawing.Point(491, 123);
            this.pbMainCurrentIcon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbMainCurrentIcon.Name = "pbMainCurrentIcon";
            this.pbMainCurrentIcon.Size = new System.Drawing.Size(201, 164);
            this.pbMainCurrentIcon.TabIndex = 0;
            this.pbMainCurrentIcon.TabStop = false;
            // 
            // labelMainCurrentTemp
            // 
            this.labelMainCurrentTemp.AutoSize = true;
            this.labelMainCurrentTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelMainCurrentTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainCurrentTemp.ForeColor = System.Drawing.Color.White;
            this.labelMainCurrentTemp.Location = new System.Drawing.Point(701, 159);
            this.labelMainCurrentTemp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMainCurrentTemp.Name = "labelMainCurrentTemp";
            this.labelMainCurrentTemp.Size = new System.Drawing.Size(117, 42);
            this.labelMainCurrentTemp.TabIndex = 1;
            this.labelMainCurrentTemp.Text = "Temp";
            // 
            // labelMainCurrentDescription
            // 
            this.labelMainCurrentDescription.AutoSize = true;
            this.labelMainCurrentDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelMainCurrentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainCurrentDescription.ForeColor = System.Drawing.Color.White;
            this.labelMainCurrentDescription.Location = new System.Drawing.Point(701, 219);
            this.labelMainCurrentDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMainCurrentDescription.Name = "labelMainCurrentDescription";
            this.labelMainCurrentDescription.Size = new System.Drawing.Size(216, 42);
            this.labelMainCurrentDescription.TabIndex = 2;
            this.labelMainCurrentDescription.Text = "Description";
            // 
            // labelMainCity
            // 
            this.labelMainCity.AutoSize = true;
            this.labelMainCity.BackColor = System.Drawing.Color.Transparent;
            this.labelMainCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainCity.ForeColor = System.Drawing.Color.White;
            this.labelMainCity.Location = new System.Drawing.Point(550, 47);
            this.labelMainCity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMainCity.Name = "labelMainCity";
            this.labelMainCity.Size = new System.Drawing.Size(82, 42);
            this.labelMainCity.TabIndex = 3;
            this.labelMainCity.Text = "City";
            this.labelMainCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDaily
            // 
            this.labelDaily.AutoSize = true;
            this.labelDaily.BackColor = System.Drawing.Color.Transparent;
            this.labelDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaily.ForeColor = System.Drawing.Color.White;
            this.labelDaily.Location = new System.Drawing.Point(535, 397);
            this.labelDaily.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDaily.Name = "labelDaily";
            this.labelDaily.Size = new System.Drawing.Size(101, 42);
            this.labelDaily.TabIndex = 4;
            this.labelDaily.Text = "Daily";
            this.labelDaily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDailyInfo
            // 
            this.panelDailyInfo.BackColor = System.Drawing.Color.Moccasin;
            this.panelDailyInfo.Controls.Add(this.labelDailyDate);
            this.panelDailyInfo.Controls.Add(this.DailyDesription);
            this.panelDailyInfo.Controls.Add(this.labelDailyTemp);
            this.panelDailyInfo.Controls.Add(this.pbDailyIcon);
            this.panelDailyInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDailyInfo.Location = new System.Drawing.Point(0, 442);
            this.panelDailyInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelDailyInfo.Name = "panelDailyInfo";
            this.panelDailyInfo.Size = new System.Drawing.Size(1283, 233);
            this.panelDailyInfo.TabIndex = 5;
            // 
            // labelDailyDate
            // 
            this.labelDailyDate.AutoSize = true;
            this.labelDailyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDailyDate.ForeColor = System.Drawing.Color.Black;
            this.labelDailyDate.Location = new System.Drawing.Point(71, 3);
            this.labelDailyDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDailyDate.Name = "labelDailyDate";
            this.labelDailyDate.Size = new System.Drawing.Size(72, 31);
            this.labelDailyDate.TabIndex = 7;
            this.labelDailyDate.Text = "Date";
            this.labelDailyDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DailyDesription
            // 
            this.DailyDesription.AutoSize = true;
            this.DailyDesription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyDesription.ForeColor = System.Drawing.Color.Black;
            this.DailyDesription.Location = new System.Drawing.Point(42, 198);
            this.DailyDesription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DailyDesription.Name = "DailyDesription";
            this.DailyDesription.Size = new System.Drawing.Size(135, 29);
            this.DailyDesription.TabIndex = 6;
            this.DailyDesription.Text = "Description";
            // 
            // labelDailyTemp
            // 
            this.labelDailyTemp.AutoSize = true;
            this.labelDailyTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDailyTemp.ForeColor = System.Drawing.Color.Black;
            this.labelDailyTemp.Location = new System.Drawing.Point(71, 158);
            this.labelDailyTemp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDailyTemp.Name = "labelDailyTemp";
            this.labelDailyTemp.Size = new System.Drawing.Size(83, 31);
            this.labelDailyTemp.TabIndex = 5;
            this.labelDailyTemp.Text = "Temp";
            // 
            // pbDailyIcon
            // 
            this.pbDailyIcon.Location = new System.Drawing.Point(47, 39);
            this.pbDailyIcon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbDailyIcon.Name = "pbDailyIcon";
            this.pbDailyIcon.Size = new System.Drawing.Size(138, 110);
            this.pbDailyIcon.TabIndex = 4;
            this.pbDailyIcon.TabStop = false;
            // 
            // Refresh
            // 
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Refresh.Location = new System.Drawing.Point(1168, 0);
            this.Refresh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(115, 64);
            this.Refresh.TabIndex = 6;
            this.Refresh.Text = "⟳";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // DayDetail
            // 
            this.DayDetail.AutoSize = true;
            this.DayDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayDetail.Location = new System.Drawing.Point(507, 918);
            this.DayDetail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DayDetail.Name = "DayDetail";
            this.DayDetail.Size = new System.Drawing.Size(209, 42);
            this.DayDetail.TabIndex = 7;
            this.DayDetail.Text = "Day Details";
            this.DayDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 989);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sun Rise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 1100);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sun Set";
            // 
            // SunRise
            // 
            this.SunRise.AutoSize = true;
            this.SunRise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunRise.Location = new System.Drawing.Point(113, 1036);
            this.SunRise.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SunRise.Name = "SunRise";
            this.SunRise.Size = new System.Drawing.Size(56, 25);
            this.SunRise.TabIndex = 10;
            this.SunRise.Text = "Time";
            // 
            // SunSet
            // 
            this.SunSet.AutoSize = true;
            this.SunSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunSet.Location = new System.Drawing.Point(113, 1153);
            this.SunSet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SunSet.Name = "SunSet";
            this.SunSet.Size = new System.Drawing.Size(56, 25);
            this.SunSet.TabIndex = 11;
            this.SunSet.Text = "Time";
            // 
            // Precipitation
            // 
            this.Precipitation.AutoSize = true;
            this.Precipitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precipitation.Location = new System.Drawing.Point(595, 1153);
            this.Precipitation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Precipitation.Name = "Precipitation";
            this.Precipitation.Size = new System.Drawing.Size(41, 25);
            this.Precipitation.TabIndex = 15;
            this.Precipitation.Text = "0%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 1036);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 1100);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precipitation";
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Humidity.Location = new System.Drawing.Point(547, 989);
            this.Humidity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(130, 36);
            this.Humidity.TabIndex = 12;
            this.Humidity.Text = "Humidity";
            // 
            // Wind
            // 
            this.Wind.AutoSize = true;
            this.Wind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wind.Location = new System.Drawing.Point(1032, 1153);
            this.Wind.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Wind.Name = "Wind";
            this.Wind.Size = new System.Drawing.Size(66, 25);
            this.Wind.TabIndex = 19;
            this.Wind.Text = "0km/h";
            // 
            // UV
            // 
            this.UV.AutoSize = true;
            this.UV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UV.Location = new System.Drawing.Point(1048, 1036);
            this.UV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UV.Name = "UV";
            this.UV.Size = new System.Drawing.Size(23, 25);
            this.UV.TabIndex = 18;
            this.UV.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1019, 1100);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 36);
            this.label9.TabIndex = 17;
            this.label9.Text = "Wind";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(981, 989);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 36);
            this.label10.TabIndex = 16;
            this.label10.Text = "UV Index";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Calgary"});
            this.comboBox1.Location = new System.Drawing.Point(1037, 159);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(43, 47);
            this.labelDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(76, 36);
            this.labelDate.TabIndex = 21;
            this.labelDate.Text = "Date";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weather_Broadcast.Properties.Resources.sunny;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Wind);
            this.Controls.Add(this.UV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Precipitation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.SunSet);
            this.Controls.Add(this.SunRise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DayDetail);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.panelDailyInfo);
            this.Controls.Add(this.labelDaily);
            this.Controls.Add(this.labelMainCity);
            this.Controls.Add(this.labelMainCurrentDescription);
            this.Controls.Add(this.labelMainCurrentTemp);
            this.Controls.Add(this.pbMainCurrentIcon);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Main";
            this.Text = "Weather";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainCurrentIcon)).EndInit();
            this.panelDailyInfo.ResumeLayout(false);
            this.panelDailyInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDailyIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainCurrentIcon;
        private System.Windows.Forms.Label labelMainCurrentTemp;
        private System.Windows.Forms.Label labelMainCurrentDescription;
        private System.Windows.Forms.Label labelMainCity;
        private System.Windows.Forms.Label labelDaily;
        private System.Windows.Forms.Panel panelDailyInfo;
        private System.Windows.Forms.Label labelDailyDate;
        private System.Windows.Forms.Label DailyDesription;
        private System.Windows.Forms.Label labelDailyTemp;
        private System.Windows.Forms.PictureBox pbDailyIcon;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label DayDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SunRise;
        private System.Windows.Forms.Label SunSet;
        private System.Windows.Forms.Label Precipitation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.Label Wind;
        private System.Windows.Forms.Label UV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelDate;
    }
}