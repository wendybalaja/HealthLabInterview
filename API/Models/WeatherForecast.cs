using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class WeatherForecast
    {
        [Key]
        public int WeatherForecastId { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Zipcode { get; set; }

        public string Summary { get; set; }
    }
}