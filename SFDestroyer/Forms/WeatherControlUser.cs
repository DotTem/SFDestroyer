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
            SetRoundedShape(panel_F_Today, 30);
            SetRoundedShape(panel_F_OtherDays, 30);
            SetRoundedShape(txtBox_City, 10);
            SetRoundedShape(panel_F_Tomorrow, 30);
            SetRoundedShape(panel_F_Third, 30);

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
            Label[] labels_F_TempList = { label_F_TempToday, label_F_TempTomorrow, label_F_TempThird, label_F_TempFourth, label_F_TempFifth };
            Label[] labels_F_DateList = { label_F_Date0, label_F_Date1, label_F_Date2, label_F_Date3, label_F_Date4 };
            PictureBox[] picBoxes_F_List = { picBox_F_Today, picBox_F_1, picBox_F_2, picBox_F_3, picBox_F_4 };

            using (WebClient apiLoading = new WebClient { Encoding = Encoding.UTF8 })
            {
                //using "User-Agent" header for access to the site page
                apiLoading.Headers["User-Agent"] = "Mozilla/5.0";
                //urls of api-site
                string weatherUrl = "http://api.openweathermap.org/data/2.5/weather?q="+city+"&units=metric&appid=0ed1773f3181837e871a4af846d38ab1";
                //download json from current urls
                string weatherJson = apiLoading.DownloadString(weatherUrl);
                //Convertation page with current weather
                WeatherInfo.Root weatherInfo = JsonConvert.DeserializeObject<WeatherInfo.Root>(weatherJson);

                //Url of all-in-one api-site
                string oneCallUrl = "http://api.openweathermap.org/data/2.5/onecall?lat="+weatherInfo.Coord.Lat+"&lon="+weatherInfo.Coord.Lon+"&units=metric&exclude=minutely&appid=0ed1773f3181837e871a4af846d38ab1";
                //Downloading json from current Url
                string oneCallJson = apiLoading.DownloadString(oneCallUrl);
                //Convertation all-in-one request
                OneCallInfo.Root oneCallInfo = JsonConvert.DeserializeObject<OneCallInfo.Root>(oneCallJson);

                #region Binding data to control user

                    #region Current Weather
                    //Labels
                    label_Temperature.Text = ((int)oneCallInfo.Daily[0].Temp.Min + "°/" + (int)oneCallInfo.Daily[0].Temp.Max + '°').ToString();
                    label_curTemperature.Text = ((int)oneCallInfo.Current.Temp + "°").ToString();
                    label_curWeather.Text = oneCallInfo.Current.Weather[0].Main;
                    label_curCity.Text = ("Weather: " + weatherInfo.Name);
                    label_Feel.Text = String.Format("Feel: {0}°", (int)oneCallInfo.Current.Feels_like);
                    //Images
                    using (Stream stream = apiLoading.OpenRead("http://openweathermap.org/img/wn/" + oneCallInfo.Current.Weather[0].Icon + "@4x.png"))
                    {
                        picBox_CurWeather.Image = Bitmap.FromStream(stream);
                    }

                #endregion
                    #region Forecast
                {
                    //Labels

                    for(int index = 0; index < 5; index++)
                    {
                        //return current date
                        var posixTime = DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc);
                        //add to groupboxes texts
                        labels_F_DateList[index].Text = posixTime.AddMilliseconds(oneCallInfo.Daily[index].Dt * 1000).ToString("dd:MMM");
                        labels_F_DateList[index].Left = picBoxes_F_List[index].Location.X + picBoxes_F_List[index].Width / 2 - labels_F_DateList[index].Width / 2;
                    }
                    
                    //Temps
                    for (int index = 0; index < 5; index++)
                    {
                        //claiming temps
                        labels_F_TempList[index].Text = String.Format("{0}°/{1}° \n \n {2}", (int)oneCallInfo.Daily[index].Temp.Min, (int)oneCallInfo.Daily[index].Temp.Max, oneCallInfo.Daily[index].Weather[0].Main);
                        //centerizing
                        labels_F_TempList[index].Left = picBoxes_F_List[index].Location.X + picBoxes_F_List[index].Width / 2 - labels_F_TempList[index].Width / 2;
                    }
                    //Images
                    for(int index = 0; index < 5; index++)
                    {
                        using (Stream stream = apiLoading.OpenRead("http://openweathermap.org/img/wn/" + oneCallInfo.Daily[index].Weather[0].Icon + "@4x.png"))
                        {
                            picBoxes_F_List[index].Image = Bitmap.FromStream(stream);
                        }
                    }
                }
                #endregion
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
