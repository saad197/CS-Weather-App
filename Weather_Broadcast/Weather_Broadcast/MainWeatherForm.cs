using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Broadcast
{
    public partial class MainWeatherForm : Form
    {
        private Weather weather;

        public MainWeatherForm(dynamic WeatherResponse)
        {
            InitializeComponent();
            weather = new Weather(WeatherResponse, dailyDetailsControl1, labelMainCity, labelDate, labelMainCurrentTemp, labelMainCurrentDescription, pbMainCurrentIcon, weatherForecastPanel);
            weather.DisplayCurrentWeather();
            weather.DisplayWeatherForecast();  
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            // get current selected city obj 
            string currentSelectedCityName = textBox1selectNewCityTextBox.Text;

            // pass it to API 
            API apiWeather = new API(currentSelectedCityName);
            //fetch api to get current weather data and store them in CurrentWeatherResponseFromAPI field
            API.FetchWeatherDataFromAPI();
        }
    }
}
