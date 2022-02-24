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
        public List<List> list { get; set; }
        public City city { get; set; }
    }


    public class Rootobject
    {
        public string cod { get; set; }
        public int message { get; set; }
        public int cnt { get; set; }
    }

    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public int population { get; set; }
        public int timezone { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class List
    {
        public int dt { get; set; }
        public Main main { get; set; }
        public Weather[] weather { get; set; }
        public int visibility { get; set; }
        public float pop { get; set; }
        public string dt_txt { get; set; }
    }

    public class Main
    {
        public float temp { get; set; }
        public float feels_like { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }
        public int pressure { get; set; }
        public int sea_level { get; set; }
        public int grnd_level { get; set; }
        public int humidity { get; set; }
        public float temp_kf { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }


    public static class TimeUtils
    {
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // The unix timestamp is how many seconds since the epoch time
            // so just substract
            var epochDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            epochDateTime = epochDateTime.AddSeconds(unixTimeStamp).ToLocalTime();

            return epochDateTime;
        }
    }
}
