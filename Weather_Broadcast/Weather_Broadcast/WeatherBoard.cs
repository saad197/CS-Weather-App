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
        List<City> cityList;
        City currentSelectedCity;
        
        public WeatherBoard()
        {
            InitializeComponent();
            FillListCityData();
            FillCityNamesToCityComboBox();          
        }

        private void FillListCityData()
        {
            cityList = new List<City>();

            foreach (var pair in Constant.MapOfCityNameAndID)
            {
                City city = new City(pair.Key);
                cityList.Add(city);
            }
        }

        private void FillCityNamesToCityComboBox()
        {
            List<string> cityNames = new List<string>();

            foreach (var city in cityList)
            {
                cityNames.Add(city.Name);
            }

            cbCityList.DataSource = cityNames;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // get current selected city obj 
            string currentSelectedCityName = cbCityList.Text;

            // pass it to API 
            API apiWeather = new API(currentSelectedCityName);
        
        }
    }
}
