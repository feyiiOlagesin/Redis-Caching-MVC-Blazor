using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedisDemoCore.Models;

namespace RedisDemoCore.Services
{
    public class WeatherForecastService
    {
        private readonly string[] summaries = new string[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public async Task<WeatherForecastModel[]> GetWeatherForecastsAsync(DateTime startDate)
        {
            var rand = new Random();
            await Task.Delay(1500);
            return Enumerable.Range(1, 5).Select(index => new WeatherForecastModel
            {
                Date = startDate.AddDays(index),
                TemperatureInC = rand.Next(-20, 55),
                Summary = summaries[rand.Next(summaries.Length)]
            }).ToArray();
        }
    }
}
