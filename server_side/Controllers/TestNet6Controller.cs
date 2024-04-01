namespace CoffeeShopApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models;


    [ApiController]
    [Route("[controller]")]
    public class TestNet6Controller : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<TestNet6Controller> _logger;

        public TestNet6Controller(ILogger<TestNet6Controller> logger)
        {
            _logger = logger;
        }

        //     [HttpGet("GetWeatherForecast")]
        //     public IEnumerable<WeatherForecast> Get()
        //     {
        //         return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //         {
        //             Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //             TemperatureC = Random.Shared.Next(-20, 55),
        //             Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //         })
        //         .ToArray();
        //     }
        // }

        [HttpGet("TestNet6")]
        public async Task<string> Get()
        {
            return "Net 6 still works";
        }
    }
}