using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Broadcast
{
    class Constant
    {
        // this dictionary holds cityname and city id in pair
        public static Dictionary<string, int> MapOfCityNameAndID = new Dictionary<string, int>()
        {
            { "Calgary", 5913490 },
            { "Toronto", 6087824 },
            { "Vancouver", 6090785 },
            { "Saskatoon", 6141256 },
            { "Quebec", 6325494 },
            { "Airdrie", 5882799 },
            { "Medicine Hat", 6071618},
            { "Banff", 5892532 },
            { "California", 4350049 },
            { "Florida", 3851244 }
        };

        // API KEY
        public static string API_KEY = "49dd73dca58244a685c52418182910";

        // URL TO FETCH
        public static string FETCH_WEATHER_URL = "http://api.apixu.com/v1/forecast.json?key=";
        public static int NUMBER_OF_WEATHER_FORECAST_DAYS = 5;
    }
}
