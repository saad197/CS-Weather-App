using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Broadcast
{
    public partial class WeatherBoard : Form
    {
        public WeatherBoard()
        {
            InitializeComponent();
            FillCityNamesToCityComboBox();
        }

        private List<string> GetListCityNames()
        {
            List<string> cityNames = new List<string>();

            foreach (var pair in Constant.MapOfCityNameAndID)
            {
                cityNames.Add(pair.Key);
            }

            return cityNames;
        }

        private void FillCityNamesToCityComboBox()
        {
            List<string> cityNames = GetListCityNames();
            cbCityList.DataSource = cityNames;
        }
    }
}
