using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFDestroyer.Classes
{
    public class WeatherInfo
    {
        public class Root
        {
            public Coord Coord { get; set; }
            public Weather[] Weather { get; set; }
            public Main Main { get; set; }
            public Wind Wind { get; set; }
            public Clouds Clouds { get; set; }
            public Rain Rain { get; set; }
            public Rain Snow { get; set; }
            public Sys Sys { get; set; }
            public long Visibility { get; set; }
            public long Timezone { get; set; }
            public long Id { get; set; }
            public string Name { get; set; }
            public long Cod { get; set; }
        }

        public class Coord 
        { 
            public long Lon { get; set; }
            public long Lat { get; set; }
        }

        public class Weather
        {
            public int Id { get; set; }
            public string Main { get; set; }
            public string Description { get; set; }
            public string Icon { get; set; }
        }

        public class Main
        {
            public double Temp { get; set; }
            public double Feels_like { get; set; }
            public double Temp_min { get; set; }
            public double Temp_max { get; set; }
            public int Pressure { get; set; }
            public int Humidity { get; set; }
        }

        public class Wind
        {
            public double Speed { get; set; }
            //Direction of wind
            public int Deg { get; set; }
        }

        public class Clouds
        {
            //Cloudiness %
            public int All { get; set; }
        }

        public class Rain
        {
            public double The1h { get; set; }
            public long The3h { get; set; }
        }

        public class Sys
        {
            public long Type { get; set; }
            public long Id { get; set; }
            public string Country { get; set; }
            public long Sunrise { get; set; }
            public long Sunset { get; set; }
        }

        

    }
}
