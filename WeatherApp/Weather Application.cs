using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using static System.Net.WebRequestMethods;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Weather Application";
        }

        string APIKey = "f8ab756bb854923c792019374c7a34f4";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        double lon;
        double lat;

        double convertToC(double kelvin)
        {
            double celsius;

            celsius = kelvin - 273;
            return celsius;
        }

        double convertToF(double kelvin)
        {
            double fahrenheit;

            fahrenheit = 1.8 * (kelvin - 273) + 32;
            return fahrenheit;
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";

                TempC.Text = convertToC(Info.main.temp).ToString();
                TempF.Text = convertToF(Info.main.temp).ToString();

                labCondition.Text = Info.weather[0].main;
                labDetails.Text = Info.weather[0].description;

                labSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                labSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                labWindSpeed.Text = Info.wind.speed.ToString();
                labPressure.Text = Info.main.pressure.ToString();

                lon = Info.coord.lon;
                lat = Info.coord.lat;
            }
        }

        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }

        void getForcast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/3.0/onecall?lat={0}&lon={1}&exclude=hourly,daily&appid={2}", lat, lon, APIKey);
                var json = web.DownloadString(url);



            }
        }
    }
}
