using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Broadcast
{
    public partial class DailyWeatherControl : UserControl
    {
        public string WeekDayTitle
        {
            get { return WeekDayLabel.Text; }
            set
            {
                WeekDayLabel.Text = value.ToString();
            }
        }

        public string Date
        {
            get { return DateLabel.Text; }
            set
            {
                DateLabel.Text = value.ToString();
            }
        }

        public string WeatherDescription
        {
            get { return WeatherDescriptionLabel.Text; }
            set
            {
                WeatherDescriptionLabel.Text = value.ToString();
            }
        }

        public string WeatherIcon
        {
            get { return WeatherIconPictureBox.ImageLocation; }
            set
            {
                //WeatherIconPictureBox.Image = Image.FromFile("../images/" + value.ToString());
            }
        }

        public string TempC
        {
            get { return TempDailyBoxLabel.Text; }
            set
            {
                TempDailyBoxLabel.Text = value.ToString();
            }
        }

        public DailyWeatherControl()
        {
            InitializeComponent();
        }        
    }
}
