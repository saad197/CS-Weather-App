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
            ((System.ComponentModel.ISupportInitialize)(this.pbMainCurrentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMainCurrentIcon
            // 
            this.pbMainCurrentIcon.Location = new System.Drawing.Point(486, 192);
            this.pbMainCurrentIcon.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pbMainCurrentIcon.Name = "pbMainCurrentIcon";
            this.pbMainCurrentIcon.Size = new System.Drawing.Size(302, 256);
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
            this.labelMainCurrentDescription.Location = new System.Drawing.Point(840, 332);
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
            this.labelMainCity.Location = new System.Drawing.Point(574, 73);
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
            this.Refresh.Location = new System.Drawing.Point(1454, 40);
            this.Refresh.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(172, 100);
            this.Refresh.TabIndex = 6;
            this.Refresh.Text = "⟳";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Calgary"});
            this.comboBox1.Location = new System.Drawing.Point(1301, 202);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(364, 33);
            this.comboBox1.TabIndex = 20;
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
            // MainWeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1682, 1310);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelDate;
    }
}