using System;

namespace Weather_Broadcast
{
    public class Weather
    {
        private double temp { get; set; }
        private string condition { get; set; }
        private double humidity { get; set; }
        private double rainChance { get; set; }
        private DateTime sunrise { get; set; }
        private DateTime sunset { get; set; }
        private double windspeed { get; set; }
        private double precipitation { get; set; }
        private string icon { get; set; }

        API apiWeather;

        public Weather()
        {
            apiWeather = new API();
            temp = apiWeather.GetTemp();
            condition = apiWeather.GetWeatherCondition();
            humidity = apiWeather.GetHumidity();
            rainChance = apiWeather.GetRainChance();
            sunrise = apiWeather.GetSunRiseDayTime();
            sunset = apiWeather.GetSunSetDayTime();
            windspeed = apiWeather.GetWindSpeed();

        }

        public static void DisplayWeather()
        {
            
        }

        public static void DisplayTemp()
        {

        }

        public static void DisplayBackground()
        {

        }

        public static void DisplayHumidity()
        {

        }

        public static void DisplayRainChance()
        {

        }

        public static void DisplayDayNight()
        {

        }

        public static void DisplayWindSpeed()
        {

        }

        public static void DisplayIcon()
        {

        }
    }

}
