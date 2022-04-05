using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
       {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private readonly WeatherDbContext? _context;

        public WeatherController(WeatherDbContext context)
        {
            _context = context; 
        }
        /// <summary>
        /// Testing
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Weather> GetWeather()
        {
            return Enumerable.Range(1, 5).Select(index => new Weather
            {
                Temperature = Random.Shared.Next(-20, 55),
                WeatherName = Summaries[Random.Shared.Next(Summaries.Length)]
                
            })
            .ToArray();
        }
    }
}
