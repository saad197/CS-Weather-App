using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Broadcast
{
    public partial class DailyDetailsControl : UserControl
    {
        public DailyDetailsControl()
        {
            InitializeComponent();
        }

        public string SunRiseTimeValue
        {
            get { return SunRise.Text; }
            set
            {
                SunRise.Text = value.ToString();
            }
        }

        public string SunSetTimeValue
        {
            get { return SunSet.Text; }
            set
            {
                SunSet.Text = value.ToString();
            }
        }

        public string MoonRiseTimeValue
        {
            get { return MoonRise.Text; }
            set
            {
                MoonRise.Text = value.ToString();
            }
        }

        public string MoonSetTimeValue
        {
            get { return MoonSet.Text; }
            set
            {
                MoonSet.Text = value.ToString();
            }
        }

        public string HumidityValue
        {
            get { return Humidity.Text; }
            set
            {
                Humidity.Text = value.ToString();
            }
        }

        public string PrecipitationValue
        {
            get { return Precipitation.Text; }
            set
            {
                Precipitation.Text = value.ToString();
            }
        }

        public string UVValue
        {
            get { return UV.Text; }
            set
            {
                UV.Text = value.ToString();
            }
        }

        public string WindValue
        {
            get { return Wind.Text; }
            set
            {
                Wind.Text = value.ToString() + " KM/H";
            }
        }



        private void DailyDetailsControl_Load(object sender, EventArgs e)
        {

        }
    }
}
