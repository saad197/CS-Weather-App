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
        
        public string Date
        {
            get { return DateLabel.Text; }
            set
            {             
                DateLabel.Text = value.ToString();

                // Parse the Dayofweek from the date retireved from API response
                // then set it to the DayOfWeek Label
                var dateTokens = value.Split('-');
                int year = int.Parse(dateTokens[0]);
                int month = int.Parse(dateTokens[1]);
                int day = int.Parse(dateTokens[2]);            
                DateTime dateValue = new DateTime(year, month, day);
                DayOfWeek dayOfWeek = dateValue.DayOfWeek;
                WeekDayLabel.Text = dayOfWeek.ToString();
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
            set
            {   
                WeatherIconPictureBox.Load(@"http:" + value);
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

        private void DailyWeatherControl_Load(object sender, EventArgs e)
        {

        }
    }
}
