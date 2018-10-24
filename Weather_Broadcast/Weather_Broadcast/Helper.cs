using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Broadcast
{
    public static class Helper
    {      
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
