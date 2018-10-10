using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Broadcast
{
    class Helper
    {
        public string DegreeConversion { get; private set; }

        public string ConvertFahrenheitToCelsius(double temp)
        {
            return DegreeConversion = ((5 / 9) * (temp - 32)).ToString();
        }

        public string ConvertCelsiusToFahrenheit(double temp)
        {
            return DegreeConversion = ((temp * 1.8) + 32).ToString();
        }
    }
}
