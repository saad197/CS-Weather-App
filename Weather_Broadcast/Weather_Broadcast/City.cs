
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Broadcast
{
   public class City
    {
        public string _name { get; set; }
        public int _id { get; set; }


        public City(string name)
        {
            _name = name;
        }

        public int GetCityFromCityName()
        {
          throw new NotImplementedException();
        }
    }
}
