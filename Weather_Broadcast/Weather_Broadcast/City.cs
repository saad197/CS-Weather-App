
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Broadcast
{
   public class City
    {
        public string Name { get; private set; }
        public int ID { get; private set; }


        public City(string name)
        {
            Name = name;
        }

        public int GetCityIDFromCityName(string cityName)
        {
            return 111;
        }
    }
}
