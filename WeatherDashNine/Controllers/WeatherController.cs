using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherDashNine.Models;
using WeatherDashNine.Repository;
using Newtonsoft.Json;

namespace WeatherDashNine.Controllers
{
    public class WeatherController : Controller
    {

        private readonly IForecastRepository _forecastRepository;

        public WeatherController(IForecastRepository forecastRepository)
        {
            _forecastRepository = forecastRepository;
        }

        public IActionResult SearchCity()
        {
            return View();
        }
        
        public async Task<IActionResult> City(CityModel cityNameFromView)
        {
            var cityDetail = await _forecastRepository.GetCityForecastAsync(cityNameFromView.Name);
            return View(cityDetail);
        }
    }
}
