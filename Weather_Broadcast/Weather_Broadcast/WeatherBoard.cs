﻿using System;
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


        //form movement variables
        private bool isDragging = false;
        private Point newPoint = new Point(0, 0);

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

            //cbCityList.DataSource = cityNames;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // get current selected city obj 
            string currentSelectedCityName = selectCityTextBox.Text;

            // pass it to API 
            API apiWeather = new API(currentSelectedCityName);
            //fetch api to get current weather data and store them in CurrentWeatherResponseFromAPI field
            API.FetchWeatherDataFromAPI(false);
        }

        private void WeatherBoard_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection cityColl = new AutoCompleteStringCollection();

            foreach (var cityname in Helper.ListOfCityNames)
            {
                cityColl.Add(cityname);
            }

            selectCityTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            selectCityTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            selectCityTextBox.AutoCompleteCustomSource = cityColl;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Close();
        }

        //moves window around based on mouse movement
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - newPoint.X, p.Y - newPoint.Y);
            }
        }

        //when mouse is down on panel
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;  
            newPoint = new Point(e.X, e.Y);

        }

        //when user lets go of mouse
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        //minimize
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
