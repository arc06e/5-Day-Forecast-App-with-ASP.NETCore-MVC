using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherDashNine.Models
{
    public class CityModel
    {
        public string Name { get; set; }
        public List<List> List { get; set; }
    }

    public class List
    {
        public int Dt { get; set; }
        public Main Main { get; set; }
        public string Icon { get; set; }
        public Weather[] Weather { get; set; }
    }

    public class Main
    {
        public float Temp { get; set; }
        public float Feels_Like { get; set; }
        public float Temp_Min { get; set; }
        public float Temp_Max { get; set; }
        public float Humidity { get; set; }
    }

    public class Weather
    {
        public string Icon { get; set; }
    }



}
