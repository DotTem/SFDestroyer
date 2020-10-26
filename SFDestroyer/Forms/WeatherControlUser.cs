using Newtonsoft.Json;
using SFDestroyer.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SFDestroyer.Forms
{
    public partial class WeatherControlUser : UserControl
    {
        Color previousColor = new Color();

        public WeatherControlUser()
        {
            InitializeComponent();

            

            SetRoundedShape(panel_Temps, 30);
            SetRoundedShape(panel_forecast, 30);            
            SetRoundedShape(panel_F_Today, 30);
            SetRoundedShape(panel_F_Tomorrow, 30);
            SetRoundedShape(panel_F_Third, 30);
            SetRoundedShape(panel_F_Fourth, 30);
            SetRoundedShape(panel_F_OtherDays, 30);
            SetRoundedShape(txtBox_City, 10);

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
                    label_F_CurCity.Text = ("Weather: " + weatherInfo.Name);
                    for (int index = 0; index < 5; index++)
                    {
                        //return current date
                        var posixTime = DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc);
                        //Init label for date
                        Label date = new Label();
                        date.Location = new Point(picBoxes_F_List[index].Location.X + picBoxes_F_List[index].Width / 4, picBoxes_F_List[index].Location.Y - date.Height);
                        date.Text = posixTime.AddMilliseconds(oneCallInfo.Daily[index].Dt * 1000).ToString("dd:MMM");
                        date.TextAlign = ContentAlignment.MiddleCenter;
                        date.ForeColor = Color.White;
                        date.AutoSize = true;
                        date.Font = new Font("Consolas", 9.75f);
                        date.MouseMove += new MouseEventHandler(Label_MouseMove);
                        date.MouseLeave += new EventHandler(Label_MouseLeave);
                        picBoxes_F_List[index].Parent.Controls.Add(date);
                    }
                    
                    //Temps
                    for (int index = 0; index < 5; index++)
                    {
                        //init label for temp
                        Label temperature = new Label();
                        temperature.Location = new Point(picBoxes_F_List[index].Location.X + picBoxes_F_List[index].Width / 4, picBoxes_F_List[index].Location.Y + picBoxes_F_List[index].Height);
                        temperature.Text = String.Format("{0}°/{1}°\n{2}", (int)oneCallInfo.Daily[index].Temp.Min, (int)oneCallInfo.Daily[index].Temp.Max, oneCallInfo.Daily[index].Weather[0].Main);
                        temperature.TextAlign = ContentAlignment.MiddleCenter;
                        temperature.ForeColor = Color.White;
                        temperature.AutoSize = true;
                        temperature.Font = new Font("Consolas", 20);
                        temperature.MouseMove += new MouseEventHandler(Label_MouseMove);
                        temperature.MouseLeave += new EventHandler(Label_MouseLeave);
                        picBoxes_F_List[index].Parent.Controls.Add(temperature);
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


        /// <summary>
        /// Make the control's corner circlier
        /// </summary>
        /// <param name="control"></param>
        /// <param name="radius"></param>
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

        #region Events

        private void Label_MouseMove(object sender, EventArgs e)
        {
            previousColor = ((Label)sender).BackColor;
            ((Label)sender).Parent.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {

            ((Label)sender).Parent.BackColor = previousColor;
        }

        private void panel_F_Today_MouseMove(object sender, MouseEventArgs e)
        {
            panel_F_Today.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void panel_F_Tomorrow_MouseMove(object sender, MouseEventArgs e)
        {
            panel_F_Tomorrow.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void panel_F_Third_MouseMove(object sender, MouseEventArgs e)
        {
            panel_F_Third.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void panel_F_Fourth_MouseMove(object sender, MouseEventArgs e)
        {
            panel_F_Fourth.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void panel_F_OtherDays_MouseMove(object sender, MouseEventArgs e)
        {
            panel_F_OtherDays.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void panel_F_Today_MouseLeave(object sender, EventArgs e)
        {
            panel_F_Today.BackColor = Color.FromArgb(68, 68, 68);
        }
        private void panel_F_Tomorrow_MouseLeave(object sender, EventArgs e)
        {
            panel_F_Tomorrow.BackColor = Color.FromArgb(66, 66, 66);
        }
        private void panel_F_Third_MouseLeave(object sender, EventArgs e)
        {
            panel_F_Third.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void panel_F_Fourth_MouseLeave(object sender, EventArgs e)
        {
            panel_F_Fourth.BackColor = Color.FromArgb(62, 62, 62);
        }
        private void panel_F_OtherDays_MouseLeave(object sender, EventArgs e)
        {
            panel_F_OtherDays.BackColor = Color.FromArgb(60, 60, 60);
        }
        #endregion
    }
}
