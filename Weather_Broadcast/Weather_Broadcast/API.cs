using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Broadcast
{
    public class API
    {
        City selectedCity;

        public API()
        {

        }

        public API( City city)
        {
            selectedCity = city;
        }

        public double GetTemp()
        {
            return 0.0;
        }

        public double GetHumidity()
        {
            return 0.0;
        }

        public double GetRainChance()
        {
            return 0.0;
        }

        public string GetWeatherCondition()
        {
            return "cold";
        }

        public double GetWindSpeed()
        {
            return 0.0;
        }

        public void GetDailyWeather()
        {

        }

        public DateTime GetSunRiseDayTime()
        {
            return new DateTime();
        }

        public DateTime GetSunSetDayTime()
        {
            return new DateTime();
        }
    }
}
