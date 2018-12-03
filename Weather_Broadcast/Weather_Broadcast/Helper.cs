using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Weather_Broadcast
{
    public static class Helper
    {

        public static string  PATH_CITY_NAMES = @"../../Resources/citynames.txt";

        public static string[] GetListOfCityNames()
        {
            List<string> cityNames = new List<string>();

            using (StreamReader sr = new StreamReader(PATH_CITY_NAMES))
            {
                var data = sr.ReadLine();
                while (data != null)
                {
                    cityNames.Add(data);
                    data = sr.ReadLine();
                }
            }
            return cityNames.ToArray();
        }

        public static string ConvertFahrenheitToCelsius(double fahrenheitTemp)
        {
            return ((5 / 9) * (fahrenheitTemp - 32)).ToString();
        }

        public static string ConvertCelsiusToFahrenheit(double celcisustTemp)
        {
            return ((celcisustTemp * 1.8) + 32).ToString();
        }
    }
}
