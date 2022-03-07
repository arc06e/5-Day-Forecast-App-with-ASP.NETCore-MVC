using System;

namespace WeatherDashNine.Models
{
    public class TimeUtils
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
