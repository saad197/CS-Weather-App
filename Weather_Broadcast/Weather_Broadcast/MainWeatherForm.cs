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
            weather = new Weather(WeatherResponse, labelMainCity, labelDate, labelMainCurrentTemp, labelMainCurrentDescription, pbMainCurrentIcon, weatherForecastPanel);
            weather.DisplayCurrentWeather();
            weather.DisplayWeatherForecast();
        }
    }
}
