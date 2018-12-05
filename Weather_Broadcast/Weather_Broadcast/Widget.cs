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
    public partial class Widget : Form
    {
        //form movement variables
        private bool isDragging = false;
        private Point newPoint = new Point(0, 0);

        //used for refreshing
        public WeatherWidget Reload = new WeatherWidget();

        public Widget(dynamic WeatherResponse)
        {
            InitializeComponent();

            WeatherWidget widget = new WeatherWidget(WeatherResponse, cityLabel, date, TempDailyBoxLabel, WeatherDescriptionLabel, WeatherIconPictureBox, WeekDayLabel);
            widget.DisplayCurrentWeather();
            Reload = widget;
        }

        private void Widget_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - newPoint.X, p.Y - newPoint.Y);
            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            newPoint = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //reload the widget
        private void button1_Click(object sender, EventArgs e)
        {
            Reload.DisplayCurrentWeather();
            MessageBox.Show("Widget refreshed");
        }

        private void Widget_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
                Application.Exit();
        }
    }
}
