using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Weather_Broadcast
{
    public class API
    {
        City selectedCity;
        private static dynamic jsonData { get; set; }
        private static dynamic ParsedData { get; set; }

        public API()
        {

        }

        public API( City city)
        {
            selectedCity = city;


            //fetch api data and store json
            FetchApiData(selectedCity.Name);
            
            if (jsonData != null)
            {
                MessageBox.Show(jsonData.current.temp_c.ToString());
            }

            else
            {
                MessageBox.Show("Loading....");
            }
            

        }


        //used to make api call and retrieve json
        private async static void FetchApiData(string city)
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
                jsonData = JsonConvert.DeserializeObject<dynamic>(result); ;
            }
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
