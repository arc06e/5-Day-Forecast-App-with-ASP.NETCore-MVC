using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherDashNine.Models;

namespace WeatherDashNine.Repository
{

    public interface IForecastRepository
    {
        Task<CityModel> GetCityForecastAsync(string cityName);
    }

    public class ForecastRepository : IForecastRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;


        public ForecastRepository(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public async Task<CityModel> GetCityForecastAsync(string cityName)
        {

           

                var baseAddress = _configuration.GetValue<string>("openWeatherAPI");
                string apiKey = _configuration.GetValue<string>("apiKey");
                var queryString = $"data/2.5/forecast?q={cityName}&units=imperial&APPID={apiKey}";

                var httpClient = _httpClientFactory.CreateClient();
                httpClient.BaseAddress = new Uri(baseAddress);
                var response = await httpClient.GetAsync(queryString);

                if (response.IsSuccessStatusCode)
                {

                    
                    var content = await response.Content.ReadFromJsonAsync<CityModel>();
                    content.Name = cityName;
                    return content;
                }
            else
            {
                return null;
            }
        }

    }
}

