using System.Collections.Generic;
using XTramileTest.Model;

namespace XTramileTest.Helper
{
    public static class DummyHelper
    {
        public static List<Country> GetCountries()
        {
            var country = new List<Country>
            {
                new Country{CountryID = "ID", CountryName = "INDONESIA"},
                new Country{CountryID = "MY", CountryName = "MALAYSIA"},
                new Country { CountryID = "AU", CountryName = "AUSTRALIA" },
            };

            return country;
        }

        public static List<City> GetCities()
        {
            var citys = new List<City>
            {
                new City{CityID = 1, CountryID = "ID", CityName ="Medan"},
                new City{CityID = 2, CountryID = "ID", CityName ="Jakarta"},
                new City{CityID = 3, CountryID = "ID", CityName ="Bandung"},
                new City{CityID = 4, CountryID = "MY", CityName ="Kuala Lumpur"},
                new City{CityID = 5, CountryID = "MY", CityName ="Kuching"},
                new City{CityID = 6, CountryID = "MY", CityName ="Johor Bahru"},
                new City{CityID = 7, CountryID = "AU", CityName ="Sydney"},
                new City{CityID = 8, CountryID = "AU", CityName ="Melbourne"},
                new City{CityID = 9, CountryID = "AU", CityName ="Perth"},
            };

            return citys;
        }
    }
}
