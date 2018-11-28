﻿using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace Weather_Broadcast
{
    public class API
    {
        public static string SelectedCity { get; private set; }
        private static dynamic DataResponseFromAPI { get; set; }
        private static dynamic CurrentWeatherInfo { get; set; }     
        private static dynamic ForecastWeatherInfo { get; set; }
        
               

        public API(string city)
        {
            SelectedCity = city;        

        }

        public async static void FetchWeatherDataFromAPI()
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

                    MainWeatherForm mainWeatherForm = new MainWeatherForm(DataResponseFromAPI);

                    mainWeatherForm.Show();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }      
    }
}
