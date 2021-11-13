using System.Collections.Generic;
using XTramileTest.Model;

namespace XTramileTest.Dto
{
    public class WeatherDto
    {
        //public WeatherDto()
        //{
        //    Coord = new Location();
        //    Wind = new Wind();
        //    weather = new List<Weather>();
        //    Main = new Temperature();
        //}
        public Location coord { get; set; }
        public int TimeZone { get; set; }
        public Wind Wind { get; set; }
        public double Visibility { get; set; }
        public List<Weather> weather { get; set; }
        public TempTemperature Main { get; set; }
        public Temperature TempCelcius
        {
            get
            {
                var a = new Temperature
                {
                    Temp_max = (Main.Temp_max - 32) * 5 / 9,
                    Temp = (Main.Temp - 32) * 5 / 9,
                    Temp_min = (Main.Temp_min - 32) * 5 / 9,
                    Feels_like = (Main.Feels_like - 32) * 5 / 9
                };

                return a;
            }
        }
        public string name { get; set; }
    }
}
