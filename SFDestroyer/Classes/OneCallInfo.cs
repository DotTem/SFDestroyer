using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFDestroyer.Classes
{
    class OneCallInfo
    {
        public partial class Root
        {
            public double Lat { get; set; }
            public double Lon { get; set; }
            public string Timezone { get; set; }
            public long Timezone_Offset { get; set; }
            public Current Current { get; set; }
            public Current[] Hourly { get; set; }
            public Daily[] Daily { get; set; }
            public Alert[] Alerts { get; set; }
        }

        public partial class Alert
        {
            public string SenderName { get; set; }
            public string Event { get; set; }
            public long Start { get; set; }
            public long End { get; set; }
            public string Description { get; set; }
        }

        public partial class Current
        {
            public long Dt { get; set; }
            public long? Sunrise { get; set; }
            public long? Sunset { get; set; }
            public double Temp { get; set; }
            public double Feels_like { get; set; }
            public long Pressure { get; set; }
            public long Humidity { get; set; }
            public double Dew_point { get; set; }
            public double? Uvi { get; set; }
            public long Clouds { get; set; }
            public long Visibility { get; set; }
            public double Wind_speed { get; set; }
            public long Wind_deg { get; set; }
            public Weather[] Weather { get; set; }
            public double? Pop { get; set; }
            public Rain Rain { get; set; }
        }

        public partial class Rain
        {
            public double The1H { get; set; }
        }

        public partial class Weather
        {
            public long Id { get; set; }
            public string Main { get; set; }
            public string Description { get; set; }
            public string Icon { get; set; }
        }

        public partial class Daily
        {
            public long Dt { get; set; }
            public long Sunrise { get; set; }
            public long Sunset { get; set; }
            public Temp Temp { get; set; }
            public FeelsLike Feels_like { get; set; }
            public long Pressure { get; set; }
            public long Humidity { get; set; }
            public double Dew_Point { get; set; }
            public double Wind_Speed { get; set; }
            public long Wind_Deg { get; set; }
            public Weather[] Weather { get; set; }
            public long Clouds { get; set; }
            public double Pop { get; set; }
            public double? Rain { get; set; }
            public double Uvi { get; set; }
        }

        public partial class FeelsLike
        {
            public double Day { get; set; }
            public double Night { get; set; }
            public double Eve { get; set; }
            public double Morn { get; set; }
        }

        public partial class Temp
        {
            public double Day { get; set; }
            public double Min { get; set; }
            public double Max { get; set; }
            public double Night { get; set; }
            public double Eve { get; set; }
            public double Morn { get; set; }
        }
    }
}
