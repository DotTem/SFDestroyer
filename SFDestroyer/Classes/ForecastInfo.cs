using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFDestroyer.Classes
{
    class ForecastInfo
    {
        public class Root
        {
            public long Cod { get; set; }
            public long Message { get; set; }
            public long Cnt { get; set; }
            public List[] List { get; set; }
            public City City { get; set; }
        }

        public class City
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public Coord Coord { get; set; }
            public string Country { get; set; }
            public long Population { get; set; }
            public long Timezone { get; set; }
            public long Sunrise { get; set; }
            public long Sunset { get; set; }
        }

        public class Coord
        {
            public double Lat { get; set; }
            public double Lon { get; set; }
        }

        public class List
        {
            public long Dt { get; set; }
            public MainClass Main { get; set; }
            public Weather[] Weather { get; set; }
            public Clouds Clouds { get; set; }
            public Wind Wind { get; set; }
            public long Visibility { get; set; }
            public double Pop { get; set; }
            public Sys Sys { get; set; }
            public DateTimeOffset DtTxt { get; set; }
            public Rain Rain { get; set; }
        }

        public class Clouds
        {
            public long All { get; set; }
        }

        public class MainClass
        {
            public double Temp { get; set; }
            public double FeelsLike { get; set; }
            public double TempMin { get; set; }
            public double TempMax { get; set; }
            public long Pressure { get; set; }
            public long SeaLevel { get; set; }
            public long GrndLevel { get; set; }
            public long Humidity { get; set; }
            public double TempKf { get; set; }
        }

        public class Rain
        {
            public double The3H { get; set; }
        }

        public class Sys
        {
            public Pod Pod { get; set; }
        }

        public class Weather
        {
            public long Id { get; set; }
            public MainEnum Main { get; set; }
            public string Icon { get; set; }
        }

        public class Wind
        {
            public double Speed { get; set; }
            public long Deg { get; set; }
        }

        public enum Pod { D, N };
        public enum MainEnum { Clear, Clouds, Rain };
    }
}
