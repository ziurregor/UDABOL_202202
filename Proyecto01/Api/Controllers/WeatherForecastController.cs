using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Hoooolaaaa", "Me parece insteresante", "No lo creo :0", "Cool",
            "Quien soy?", "Aguita de coco", "Hamburgesas de platano", "Ayer cuando era hoy", "No entiendo", "Me quede asi :O"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
           
            var rng = new Random();
            return Enumerable.Range(1, 100).Select(index => new WeatherForecast
            {               
                MensajeId = rng.Next(0, 1000),
                UseridId = rng.Next(-20, 55),
                Mensaje = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
