using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Weather_Broadcast
{
    public class API
    {
        public static string SelectedCity { get; private set; }
        private static dynamic DataResponseFromAPI { get; set; }
        private static dynamic CurrentWeatherInfo { get; set; }     
        private static dynamic ForecastWeatherInfo { get; set; }
        public static MainWeatherForm MainWeatherForm { get; private set; }

        public API( string city)
        {
            SelectedCity = city;          
        }

        public async static void FetchWeatherDataFromAPI(bool widget)
        {
            var url = Constant.FETCH_WEATHER_URL + Constant.API_KEY + "+&q=" + SelectedCity + "&days=" + Constant.NUMBER_OF_WEATHER_FORECAST_DAYS;

            try
            {
                //fetch the result from api.
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = await client.GetAsync(url))
                using (HttpContent content = response.Content)
                {
                    // ... Read the string.
                    string result = await content.ReadAsStringAsync();
                    //assign the json data, parsed
                    DataResponseFromAPI = JsonConvert.DeserializeObject<dynamic>(result);

                    if (DataResponseFromAPI != null)
                    {
                        if (widget)
                        {
                            Widget Widget = new Widget(DataResponseFromAPI);
                            Widget.Show();
                        }
                        else
                        {
                            MainWeatherForm = new MainWeatherForm(DataResponseFromAPI);
                            MainWeatherForm.Show();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid city name. Try again!!!");
            }
            
        }      
    }
}
