using DBWebApplication.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBWebApplication.Server.Data;

namespace DBWebApplication.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> logger;
        private readonly ApplicationDbContext _applicationDbContext;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _applicationDbContext = applicationDbContext;

        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _applicationDbContext.WeatherForecasts.ToArray();
        }

        [HttpGet("create")]
        public ActionResult Create()
        {
            var rng = new Random();
            _applicationDbContext.WeatherForecasts.Add(
                new WeatherForecast
                {
                    Id = Guid.NewGuid(),
                    Date = DateTime.Now.AddDays(rng.Next(1, 5)),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                }
                );
            _applicationDbContext.SaveChanges();
            return Ok();
        }


        [HttpGet("edit")]
        public ActionResult Edit()
        {
            _applicationDbContext.WeatherForecasts.First().Summary = "EDITED!";
            _applicationDbContext.SaveChanges();
            return Ok();
        }

        [HttpGet("delete")]
        public ActionResult Delete()
        {
            _applicationDbContext.WeatherForecasts.Remove(_applicationDbContext.WeatherForecasts.First());
            _applicationDbContext.SaveChanges();
            return Ok();
        }
    }
}
