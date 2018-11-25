using System;
using System.Windows.Forms;

namespace Weather_Broadcast
{
    public class Weather
    {
        
        private string selectedCity;

        // Fields to hold View Controls reference
        public Label LabelCityName { get; private set; }
        public Label LabelCurrentDate { get; private set; }
        public Label LabelCurrentTemperature { get; private set; }
        public Label LabelDescription { get; private set; }
        public PictureBox PictureBoxIcon { get; private set; }
        public dynamic WeatherResponseFromAPI { get; private set; }

        // Fields to hold weather data
        private double temp { get; set; }
        private string condition { get; set; }
        private double humidity { get; set; }
        private double rainChance { get; set; }
        private DateTime sunrise { get; set; }
        private DateTime sunset { get; set; }
        private double windspeed { get; set; }
        private double precipitation { get; set; }
        private string icon { get; set; }
      
        public Weather(dynamic dataResponse, Label labelCityName, Label labelDate, Label labelCurrentTemp, Label labelDescription, PictureBox weatherIcon)
        {
            // init weather data
            WeatherResponseFromAPI = dataResponse;

            // Init view control reference
            LabelCityName = labelCityName;
            LabelCurrentDate = labelDate;
            LabelCurrentTemperature = labelCurrentTemp;
            LabelDescription = labelDescription;
            PictureBoxIcon = weatherIcon;
            DisplayCurrentWeather();

        }
        
        public void DisplayCurrentWeather()
        {
            DisplayWeather();
            DisplayTemp();
            DisplayCurrentDate();
            DisplayDescription();
            DisplayHumidity();
            DisplayRainChance();
            DisplayDayNight();
            DisplayWindSpeed();
            DisplayIcon();
            
        }

        public void DisplayWeather()
        {
            MessageBox.Show(WeatherResponseFromAPI.ToString());
            LabelCityName.Text = WeatherResponseFromAPI.location.name;
        }

        public void DisplayTemp()
        {
            LabelCurrentTemperature.Text = WeatherResponseFromAPI.current.temp_c;
        }

        public void DisplayCurrentDate()
        {
            LabelCurrentDate.Text = WeatherResponseFromAPI.forecast.forecastday[0].date.ToString();
        }

        public void DisplayDescription()
        {
            LabelDescription.Text = WeatherResponseFromAPI.current.condition.text.ToString();
        }
        public void DisplayHumidity()
        {

        }

        public void DisplayRainChance()
        {

        }

        public void DisplayDayNight()
        {

        }

        public void DisplayWindSpeed()
        {

        }

        public void DisplayIcon()
        {
            var UrlPath = WeatherResponseFromAPI.current.condition.icon;
            PictureBoxIcon.Load(@"http:" + UrlPath.ToString());
        }
    }

}
