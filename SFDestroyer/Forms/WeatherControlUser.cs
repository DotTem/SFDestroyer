using Newtonsoft.Json;
using SFDestroyer.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SFDestroyer.Forms
{
    public partial class WeatherControlUser : UserControl
    {
        public WeatherControlUser()
        {
            InitializeComponent();
            SetRoundedShape(panel_Temps, 30);
            SetRoundedShape(panel_forecast, 30);
            #region first try
            /*            //parsing
                        using (WebClient apiInteracion = new WebClient { Encoding = Encoding.UTF8 })
                        {
                            //using "User-Agent" header for access to the site page
                            apiInteracion.Headers["User-Agent"] = "Mozilla/5.0";
                            //<span data-testid="TemperatureValue">17°</span>
                            //data-testid="TemperatureValue">6°</span></div></div>
                            //download site page
                            string site = apiInteracion.DownloadString("https://weather.com");
                            //finding max temperature
                            string temperature_max = System.Text.RegularExpressions.Regex.Match(site, @"<span data-testid=""TemperatureValue"">([0-9]+\°)</span>").Groups[1].Value;
                            //finding min temperature
                            string temperature_min = System.Text.RegularExpressions.Regex.Match(site, @"data-testid=""TemperatureValue"">([0-9]+\°)</span></div></div>").Groups[1].Value;
                            //finding current temperature
                            string temperature_current = System.Text.RegularExpressions.Regex.Match(site, @"<span data-testid=""TemperatureValue"" class=""_3KcTQ"">([0-9]+\°)</span>").Groups[1].Value;
                            //returning all finded values to the ControlUser
                            label_Temperature.Text = (temperature_max + '|' + temperature_min);
                            label_curTemperature.Text = temperature_current;
                        }
                        ///.appid=155c3b3a2b8bab42fcc95040d7ceb123
                        //.http://api.openweathermap.org/data/2.5/forecast?id=524901&APPID=0ed1773f3181837e871a4af846d38ab1
             */
            #endregion

            panel_Temps.BringToFront();
            apiInteraction(Properties.Settings.Default.CitySetDefault);
        }

        #region Buttons
        private void but_curTemp_Click(object sender, System.EventArgs e)
        {
            panel_Temps.BringToFront();
            but_curTemp.BackColor = Color.FromArgb(55, 55, 55);
            but_Forecast.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void but_Forecast_Click(object sender, System.EventArgs e)
        {
            panel_forecast.BringToFront();
            but_curTemp.BackColor = Color.FromArgb(50, 50, 50);
            but_Forecast.BackColor = Color.FromArgb(55, 55, 55);
        }


        #endregion

        #region Main Metods
        /// <summary>
        /// Internet part
        /// </summary>
        /// <param name="city"> City you need</param>
        /// api.openweathermap.org/data/2.5/forecast/daily?q=Moscow&cnt=5&appid=0ed1773f3181837e871a4af846d38ab1
        void apiInteraction (string city)
        {
            using (WebClient apiLoading = new WebClient { Encoding = Encoding.UTF8 })
            {
                //using "User-Agent" header for access to the site page
                apiLoading.Headers["User-Agent"] = "Mozilla/5.0";
                //urls of api-site
                string weatherUrl = "http://api.openweathermap.org/data/2.5/weather?q="+city+"&units=metric&appid=0ed1773f3181837e871a4af846d38ab1";
                string forecastUrl = "http://api.openweathermap.org/data/2.5/forecast?id=524901&APPID=0ed1773f3181837e871a4af846d38ab1";
                //download jsons from current urls
                string weatherJson = apiLoading.DownloadString(weatherUrl);
                string forecastJson = apiLoading.DownloadString(forecastUrl);

                //Convertation page with current weather
                WeatherInfo.Root weatherInfo = JsonConvert.DeserializeObject<WeatherInfo.Root>(weatherJson);
                //Convertation page with 5 day(interave; = 3 hours) forecast
                ForecastInfo.Root forecastInfo = JsonConvert.DeserializeObject<ForecastInfo.Root>(forecastJson);

                #region Binding data to control user
                //Labels
                label_Temperature.Text = ((int)weatherInfo.Main.Temp_min + "°/" + (int)weatherInfo.Main.Temp_max + '°').ToString();
                label_curTemperature.Text = ((int)weatherInfo.Main.Temp + "°").ToString();
                label_curWeather.Text = weatherInfo.Weather[0].Main;
                label_curCity.Text = ("Weather: " + weatherInfo.Name);
                label_Feel.Text = String.Format("Feel: {0}°", (int)weatherInfo.Main.Feels_like);
                //Images
                using (Stream stream = apiLoading.OpenRead("http://openweathermap.org/img/wn/" + weatherInfo.Weather[0].Icon + "@4x.png"))
                {
                    picBox_CurWeather.Image = Bitmap.FromStream(stream);
                }
                #endregion
            }
        }

        /// <summary>
        /// Main Method with correct city input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBox_City_KeyDown(object sender, KeyEventArgs e)
        {
            string wrotenCity = txtBox_City.Text;
            if (e.KeyCode == Keys.Enter && !String.IsNullOrWhiteSpace(wrotenCity))
            {
                e.SuppressKeyPress = true;
                try
                {
                    apiInteraction(wrotenCity);
                }
                catch (WebException)
                {
                    MessageBox.Show("No city with " + '"' + wrotenCity + '"' + " name");
                }
            }

        }

        #endregion


        //For rounded corners
        static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }
    }
}
