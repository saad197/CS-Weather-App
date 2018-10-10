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
            this.mainCurrentIcon = new System.Windows.Forms.PictureBox();
            this.mainCurrentTemp = new System.Windows.Forms.Label();
            this.mainCurrentDescription = new System.Windows.Forms.Label();
            this.mainCity = new System.Windows.Forms.Label();
            this.DailyLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DailyDate = new System.Windows.Forms.Label();
            this.DailyDesription = new System.Windows.Forms.Label();
            this.DailyTemp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.Date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainCurrentIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCurrentIcon
            // 
            this.mainCurrentIcon.Location = new System.Drawing.Point(369, 100);
            this.mainCurrentIcon.Name = "mainCurrentIcon";
            this.mainCurrentIcon.Size = new System.Drawing.Size(151, 133);
            this.mainCurrentIcon.TabIndex = 0;
            this.mainCurrentIcon.TabStop = false;
            // 
            // mainCurrentTemp
            // 
            this.mainCurrentTemp.AutoSize = true;
            this.mainCurrentTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCurrentTemp.Location = new System.Drawing.Point(526, 129);
            this.mainCurrentTemp.Name = "mainCurrentTemp";
            this.mainCurrentTemp.Size = new System.Drawing.Size(90, 33);
            this.mainCurrentTemp.TabIndex = 1;
            this.mainCurrentTemp.Text = "Temp";
            // 
            // mainCurrentDescription
            // 
            this.mainCurrentDescription.AutoSize = true;
            this.mainCurrentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCurrentDescription.Location = new System.Drawing.Point(526, 178);
            this.mainCurrentDescription.Name = "mainCurrentDescription";
            this.mainCurrentDescription.Size = new System.Drawing.Size(162, 33);
            this.mainCurrentDescription.TabIndex = 2;
            this.mainCurrentDescription.Text = "Description";
            // 
            // mainCity
            // 
            this.mainCity.AutoSize = true;
            this.mainCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCity.Location = new System.Drawing.Point(423, 38);
            this.mainCity.Name = "mainCity";
            this.mainCity.Size = new System.Drawing.Size(66, 33);
            this.mainCity.TabIndex = 3;
            this.mainCity.Text = "City";
            this.mainCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DailyLabel
            // 
            this.DailyLabel.AutoSize = true;
            this.DailyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyLabel.Location = new System.Drawing.Point(426, 367);
            this.DailyLabel.Name = "DailyLabel";
            this.DailyLabel.Size = new System.Drawing.Size(81, 33);
            this.DailyLabel.TabIndex = 4;
            this.DailyLabel.Text = "Daily";
            this.DailyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DailyDate);
            this.panel1.Controls.Add(this.DailyDesription);
            this.panel1.Controls.Add(this.DailyTemp);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 302);
            this.panel1.TabIndex = 5;
            // 
            // DailyDate
            // 
            this.DailyDate.AutoSize = true;
            this.DailyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyDate.Location = new System.Drawing.Point(111, 34);
            this.DailyDate.Name = "DailyDate";
            this.DailyDate.Size = new System.Drawing.Size(57, 25);
            this.DailyDate.TabIndex = 7;
            this.DailyDate.Text = "Date";
            this.DailyDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DailyDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // DailyDesription
            // 
            this.DailyDesription.AutoSize = true;
            this.DailyDesription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyDesription.Location = new System.Drawing.Point(94, 236);
            this.DailyDesription.Name = "DailyDesription";
            this.DailyDesription.Size = new System.Drawing.Size(104, 24);
            this.DailyDesription.TabIndex = 6;
            this.DailyDesription.Text = "Description";
            // 
            // DailyTemp
            // 
            this.DailyTemp.AutoSize = true;
            this.DailyTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyTemp.Location = new System.Drawing.Point(109, 201);
            this.DailyTemp.Name = "DailyTemp";
            this.DailyTemp.Size = new System.Drawing.Size(66, 25);
            this.DailyTemp.TabIndex = 5;
            this.DailyTemp.Text = "Temp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(65, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 133);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Refresh
            // 
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(866, 12);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(96, 59);
            this.Refresh.TabIndex = 6;
            this.Refresh.Text = "⟳";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // DayDetail
            // 
            this.DayDetail.AutoSize = true;
            this.DayDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayDetail.Location = new System.Drawing.Point(380, 746);
            this.DayDetail.Name = "DayDetail";
            this.DayDetail.Size = new System.Drawing.Size(165, 33);
            this.DayDetail.TabIndex = 7;
            this.DayDetail.Text = "Day Details";
            this.DayDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 804);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sun Rise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 894);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sun Set";
            // 
            // SunRise
            // 
            this.SunRise.AutoSize = true;
            this.SunRise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunRise.Location = new System.Drawing.Point(85, 842);
            this.SunRise.Name = "SunRise";
            this.SunRise.Size = new System.Drawing.Size(43, 20);
            this.SunRise.TabIndex = 10;
            this.SunRise.Text = "Time";
            // 
            // SunSet
            // 
            this.SunSet.AutoSize = true;
            this.SunSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunSet.Location = new System.Drawing.Point(85, 937);
            this.SunSet.Name = "SunSet";
            this.SunSet.Size = new System.Drawing.Size(43, 20);
            this.SunSet.TabIndex = 11;
            this.SunSet.Text = "Time";
            // 
            // Precipitation
            // 
            this.Precipitation.AutoSize = true;
            this.Precipitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precipitation.Location = new System.Drawing.Point(446, 937);
            this.Precipitation.Name = "Precipitation";
            this.Precipitation.Size = new System.Drawing.Size(32, 20);
            this.Precipitation.TabIndex = 15;
            this.Precipitation.Text = "0%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 842);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 894);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precipitation";
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Humidity.Location = new System.Drawing.Point(410, 804);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(106, 29);
            this.Humidity.TabIndex = 12;
            this.Humidity.Text = "Humidity";
            // 
            // Wind
            // 
            this.Wind.AutoSize = true;
            this.Wind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wind.Location = new System.Drawing.Point(774, 937);
            this.Wind.Name = "Wind";
            this.Wind.Size = new System.Drawing.Size(52, 20);
            this.Wind.TabIndex = 19;
            this.Wind.Text = "0km/h";
            // 
            // UV
            // 
            this.UV.AutoSize = true;
            this.UV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UV.Location = new System.Drawing.Point(786, 842);
            this.UV.Name = "UV";
            this.UV.Size = new System.Drawing.Size(18, 20);
            this.UV.TabIndex = 18;
            this.UV.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(764, 894);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Wind";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(736, 804);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "UV Index";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Calgary"});
            this.comboBox1.Location = new System.Drawing.Point(778, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(33, 38);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(63, 29);
            this.Date.TabIndex = 21;
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 1002);
            this.Controls.Add(this.Date);
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DailyLabel);
            this.Controls.Add(this.mainCity);
            this.Controls.Add(this.mainCurrentDescription);
            this.Controls.Add(this.mainCurrentTemp);
            this.Controls.Add(this.mainCurrentIcon);
            this.Name = "Main";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainCurrentIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainCurrentIcon;
        private System.Windows.Forms.Label mainCurrentTemp;
        private System.Windows.Forms.Label mainCurrentDescription;
        private System.Windows.Forms.Label mainCity;
        private System.Windows.Forms.Label DailyLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DailyDate;
        private System.Windows.Forms.Label DailyDesription;
        private System.Windows.Forms.Label DailyTemp;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.Label Date;
    }
}