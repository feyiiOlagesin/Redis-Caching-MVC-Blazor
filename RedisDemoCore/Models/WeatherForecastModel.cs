using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisDemoCore.Models
{
    public class WeatherForecastModel
    {
        public DateTime Date { get; set; }
        
        public int TemperatureInC { get; set; }

        public int TemperatureInF => 32 + (int)(TemperatureInC / 0.5556);

        public string Summary { get; set; }
    }
}
