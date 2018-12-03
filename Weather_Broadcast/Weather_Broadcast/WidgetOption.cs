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
    public partial class WidgetOption : Form
    {
        public WidgetOption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            API apiWeather = new API(selectCity.Text);
            //fetch api to get current weather data and store them in CurrentWeatherResponseFromAPI field
            API.FetchWeatherDataFromAPI(true);
            this.Close();
        }

        private void WidgetOption_Load(object sender, EventArgs e)
        {
            //selectCity
            AutoCompleteStringCollection cityColl = new AutoCompleteStringCollection();

            string[] listCityNames = Helper.GetListOfCityNames();

            foreach (var cityname in listCityNames)
            {
                cityColl.Add(cityname);
            }

            selectCity.AutoCompleteMode = AutoCompleteMode.Suggest;
            selectCity.AutoCompleteSource = AutoCompleteSource.CustomSource;
            selectCity.AutoCompleteCustomSource = cityColl;
        }

        private void ConfirmCity(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
