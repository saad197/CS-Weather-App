using Newtonsoft.Json;
using System;
using System.Net.Http;

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
            FetchApiData(city.Name);
            ParsedData = ParseData(jsonData);
        }




        //used to make api call and retrieve json
        private async static void FetchApiData(string city)
        {
            //appid is the api key
            string apiLink = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=dd9231cf046811167ae556241662dc09";

            // ... Use HttpClient.
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(apiLink))
            using (HttpContent content = response.Content)

            {
                // ... Read the string.
                string result = await content.ReadAsStringAsync();
                jsonData = result;
            }
        }

        //will parse data
        private dynamic ParseData(dynamic jsondata)
        {
            dynamic result = JsonConvert.DeserializeObject<dynamic>(jsondata);
            return result;
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
