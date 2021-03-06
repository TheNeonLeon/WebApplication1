using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly WeatherDbContext _context;

        public CountryController(WeatherDbContext context) { _context = context; }
        
        [HttpGet]
        public async Task<ActionResult<ICollection<Country>>> GetCountry()
        {
            var country = await _context.Country.Include(w => w.Weather).ToListAsync();
            if(country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(Country country)
        {
            await _context.Country.AddAsync(country);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(country), new { id = country.CountryId}, country);

        }
    }
}
