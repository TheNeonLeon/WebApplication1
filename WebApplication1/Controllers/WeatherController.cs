using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [DisableCors]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherDbContext _context;
        public WeatherController(WeatherDbContext context) { _context = context; }

        [HttpGet]
        public async Task<ActionResult<Weather>> GetWeathers()
        {
            var weather = await _context.Weather.ToListAsync();

            if(weather == null)
            {
                return NotFound();
            }
            return Ok (weather);
            
        }

        [HttpPost]
        public async Task<ActionResult<Weather>> PostWeather(Weather weather)
        {
           await _context.Weather.AddAsync(weather);
            await _context.SaveChangesAsync();  
            return CreatedAtAction(nameof(weather), new { id = weather.Id }, weather);
            
        }

    }
}
