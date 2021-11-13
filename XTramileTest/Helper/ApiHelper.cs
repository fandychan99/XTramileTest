using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using XTramileTest.Dto;

namespace XTramileTest.Helper
{
    public class ApiHelper
    {
        private readonly HttpClient _httpClient;
        private string _url;

        private Uri BaseEndpoint { get; set; }
        public ApiHelper()
        {
            _httpClient = new HttpClient();
            
        }

        public async Task<WeatherDto> GetWeather(string city)
        {
            try
            {
                _url = String.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid=32f68b142d1e888a7a9de627524463ca", city);
                var requestUrl = new Uri(_url);
                var response = await _httpClient.GetAsync(requestUrl, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();
                var hasil = JsonConvert.DeserializeObject<WeatherDto>(data);
                return hasil;
                //return hasil.FirstOrDefault();
            }
            catch (System.Exception ex)
            {
                var err = ex.Message.ToString();
                throw new SystemException(err);
            }
        }
        
    }
}
