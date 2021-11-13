using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using XTramileTest.Dto;
using XTramileTest.Helper;
using XTramileTest.Models;

namespace XTramileTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApiHelper _apiHelper;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _apiHelper = new ApiHelper();
        }

        public IActionResult Index()
        {
            var hasil = DummyHelper.GetCountries();
            return View(hasil);
        }

        public IActionResult AjaxGetCiti(string id)
        {
            var hasil = DummyHelper.GetCities().Where(x => x.CountryID == id).ToList();
            return PartialView("_AjaxCiti", hasil);
        }

        public async Task<IActionResult> AjaxGetWeather(string citi)
        {
            var hasil = await _apiHelper.GetWeather(citi);
            var result = new WeatherMappingDto
            {
                Location = hasil.name + " ( " + hasil.coord.lat + " , " + hasil.coord.lon + " )",
                Time = hasil.TimeZone.ToString(),
                Wind = String.Format("Speed : {0} m/s , Direction : {1} ", hasil.Wind.speed, hasil.Wind.deg),
                Visibility = hasil.Visibility + " %",
                SkyCondition = hasil.weather[0].Main.ToString(),
                TemperatureC = hasil.Main.Temp.ToString() + " C", 
                TemperatureF = hasil.TempCelcius.Temp.ToString() + " F",
                RelativeHumidity = hasil.Main.humidity + " %",
                Pressure = hasil.Main.Pressure + " hPa"
            };
            return PartialView("_AjaxIsi", result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
