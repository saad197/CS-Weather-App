using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Weather_Broadcast
{
    public class API
    {
        private string selectedCity;
        private static dynamic DataResponseFromAPI { get; set; }
        private static dynamic CurrentWeatherInfo { get; set; }     
        private static dynamic ForecastWeatherInfo { get; set; }
        public bool IsDataFullLoaded { get; } = false;

        public API( string city)
        {
            selectedCity = city;

            //fetch api to get current weather data and store them in CurrentWeatherResponseFromAPI field
            FetchWeatherDataFromAPI(selectedCity, Constant.NUMBER_OF_WEATHER_FORECAST_DAYS);

            //if (DataResponseFromAPI != null)
            //{
            //    CurrentWeatherInfo = DataResponseFromAPI.current;
            //    ForecastWeatherInfo = DataResponseFromAPI.forecast.forecastday;

            //    if (CurrentWeatherInfo != null || ForecastWeatherInfo != null)
            //    {
            //        IsDataFullLoaded = true;
            //    }
            //}
        }

        private async static void FetchWeatherDataFromAPI(string city, int numberOfDays)
        {
            var url = Constant.FETCH_WEATHER_URL + Constant.API_KEY + "+&q=" + city + "&days=" + numberOfDays;

            //fetch the result from api.
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(url))
            using (HttpContent content = response.Content)
            {
                // ... Read the string.
                string result = await content.ReadAsStringAsync();
                //assign the json data, parsed
                DataResponseFromAPI = JsonConvert.DeserializeObject<dynamic>(result);

                // Passing the response from api to Weather main form
                MainWeatherForm mainWeatherForm = new MainWeatherForm(DataResponseFromAPI);
                mainWeatherForm.Show();
            }
        }      
    }
}
