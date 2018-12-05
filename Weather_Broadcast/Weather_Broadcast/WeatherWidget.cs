using System;
using System.Windows.Forms;

namespace Weather_Broadcast
{
    public class WeatherWidget
    {
        // Fields to hold View Controls reference
        public Label LabelCityName { get; private set; }
        public Label LabelCurrentDate { get; private set; }
        public Label LabelCurrentTemperature { get; private set; }
        public Label LabelDescription { get; private set; }
        public PictureBox PictureBoxIcon { get; private set; }
        public Label WeekDayLabel { get; private set; }
        public dynamic WeatherResponseFromAPI { get; private set; }


        public WeatherWidget(dynamic dataResponse, Label labelCityName, Label labelDate, Label labelCurrentTemp, Label labelDescription, PictureBox weatherIcon, Label weekdayLabel)
        {
            // init weather data
            WeatherResponseFromAPI = dataResponse;

            // Init view control reference
            LabelCityName = labelCityName;
            LabelCurrentDate = labelDate;
            LabelCurrentTemperature = labelCurrentTemp;
            LabelDescription = labelDescription;
            PictureBoxIcon = weatherIcon;
            WeekDayLabel = weekdayLabel;
        }


        public WeatherWidget()
        {

        }

        public void DisplayCurrentWeather()
        {
            DisplayWeather();
            DisplayTemp();
            DisplayCurrentDate();
            DisplayDescription();
            DisplayIcon();
            DisplayWeekDay();
        }

        private void DisplayWeather()
        {          
            LabelCityName.Text = WeatherResponseFromAPI.location.name;
        }

        private void DisplayTemp()
        {
            LabelCurrentTemperature.Text = WeatherResponseFromAPI.current.temp_c + " ˚C";
        }

        private void DisplayCurrentDate()
        {
            LabelCurrentDate.Text = WeatherResponseFromAPI.forecast.forecastday[0].date.ToString();
        }

        private void DisplayDescription()
        {
            LabelDescription.Text = WeatherResponseFromAPI.current.condition.text.ToString();
        }

        private void DisplayIcon()
        {
            var UrlPath = WeatherResponseFromAPI.current.condition.icon;
            PictureBoxIcon.Load(@"http:" + UrlPath.ToString());
        }

        private void DisplayWeekDay()
        {
            var currentDate = (DateTime)WeatherResponseFromAPI.forecast.forecastday[0].date;
            var dayOfWeek = GetWeekDayFromGivenDate(currentDate);
            WeekDayLabel.Text = dayOfWeek;

        }

        private string GetWeekDayFromGivenDate(DateTime givenDate)
        {
            return givenDate.DayOfWeek.ToString();
        }
    }

}
