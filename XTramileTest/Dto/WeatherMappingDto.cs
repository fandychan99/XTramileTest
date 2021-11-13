using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XTramileTest.Dto
{
    public class WeatherMappingDto
    {
        public string Location { get; set; }
        public string Time { get; set; }
        public string Wind { get; set; }
        public string Visibility { get; set; }
        public string SkyCondition { get; set; }
        public string TemperatureC { get; set; }
        public string TemperatureF { get; set; }
        public string DewPoint { get; set; }
        public string RelativeHumidity { get; set; }
        public string Pressure { get; set; }

    }
}
