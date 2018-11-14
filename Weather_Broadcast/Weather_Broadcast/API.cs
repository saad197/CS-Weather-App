using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Weather_Broadcast
{
    public class API
    {
        City selectedCity;
        private static dynamic CurrentWeatherResponseFromAPI { get; set; }
        private static dynamic CurrentWeatherInfo { get; set; }
        private static dynamic ForecastWeatherInfo { get; set; }

        public API()
        {

        }

        public API( City city)
        {
            selectedCity = city;


            //fetch api to get current weather data and store them in CurrentWeatherResponseFromAPI field
            FetchCurrentWeatherInfo(selectedCity.Name);

            if (CurrentWeatherResponseFromAPI != null)
            {
                // Extract current weather info from API response
                CurrentWeatherInfo = CurrentWeatherResponseFromAPI.current;
            }
            
            if (CurrentWeatherInfo != null)
            {
                MessageBox.Show(CurrentWeatherInfo.temp_c.ToString());
            }
            else
            {
                MessageBox.Show("Loading....");
            }          

        }


        //used to make api call and retrieve json
        private async static void FetchCurrentWeatherInfo(string city)
        {
            var apiKey = "49dd73dca58244a685c52418182910";
            var url = "http://api.apixu.com/v1/current.json?key=" + apiKey + "+&q=" + city;

            //fetch the result from api.
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(url))
            using (HttpContent content = response.Content)
            {
                // ... Read the string.
                string result = await content.ReadAsStringAsync();

                //assign the json data, parsed
                CurrentWeatherResponseFromAPI =  JsonConvert.DeserializeObject<dynamic>(result);                
            }
        }
     
        
        public double GetTempC()
        {
            return CurrentWeatherInfo.temp_c;
        }

        public double GetTempF()
        {
            return CurrentWeatherInfo.temp_f;
        }

        public double GetHumidity()
        {
            return CurrentWeatherInfo.huminity;
        }

        public double GetRainChance()
        {
            return 0.0;
        }

        public string GetWeatherCondition()
        {
            return CurrentWeatherInfo.condition.text;
        }

        public double GetWindSpeed()
        {
            return CurrentWeatherInfo.wind_mph;
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
