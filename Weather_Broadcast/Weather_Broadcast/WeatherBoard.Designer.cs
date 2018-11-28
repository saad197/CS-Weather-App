namespace Weather_Broadcast
{
    partial class WeatherBoard
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
            this.picBoxBgImageWelcomePage = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.selectCityTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBgImageWelcomePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxBgImageWelcomePage
            // 
            this.picBoxBgImageWelcomePage.Image = global::Weather_Broadcast.Properties.Resources.kumiko_shimizu_731627_unsplash;
            this.picBoxBgImageWelcomePage.Location = new System.Drawing.Point(16, 8);
            this.picBoxBgImageWelcomePage.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxBgImageWelcomePage.Name = "picBoxBgImageWelcomePage";
            this.picBoxBgImageWelcomePage.Size = new System.Drawing.Size(805, 550);
            this.picBoxBgImageWelcomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBgImageWelcomePage.TabIndex = 0;
            this.picBoxBgImageWelcomePage.TabStop = false;
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(332, 47);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(145, 114);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weather App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose your City";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(314, 449);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(163, 43);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // selectCityTextBox
            // 
            this.selectCityTextBox.Location = new System.Drawing.Point(319, 374);
            this.selectCityTextBox.Name = "selectCityTextBox";
            this.selectCityTextBox.Size = new System.Drawing.Size(150, 22);
            this.selectCityTextBox.TabIndex = 6;
            // 
            // WeatherBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 582);
            this.Controls.Add(this.selectCityTextBox);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.picBoxBgImageWelcomePage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WeatherBoard";
            this.Text = "Weather Broadcast";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBgImageWelcomePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBgImageWelcomePage;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox selectCityTextBox;
    }
}

