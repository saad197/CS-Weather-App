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
            MessageBox.Show(jsonData);
            var res = Parse(jsonData);
            MessageBox.Show(res);
            

        }

        //will parse data
        public static dynamic Parse(string data)
        {
           MessageBox.Show(data);
            dynamic result = JsonConvert.DeserializeObject<dynamic>(data);
            dynamic name = result.current.condition.text;
            Console.WriteLine(name);

            return name.ToString();
        }

        //used to make api call and retrieve json
        private async static void FetchApiData(string city)
        {
            var apiKey = "49dd73dca58244a685c52418182910";
            var url = "http://api.apixu.com/v1/current.json?key=" + apiKey + "+&q=" + city;

            // ... Use HttpClient.
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(url))
            using (HttpContent content = response.Content)
            {
                // ... Read the string.
                string result = await content.ReadAsStringAsync();

                //assign the json data
                jsonData = result;
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
