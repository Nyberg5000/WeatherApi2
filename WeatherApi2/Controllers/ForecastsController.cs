using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeatherApi2.Data;
using WeatherApi2.Models;

namespace WeatherApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForecastsController : ControllerBase
    {
        private readonly ForecastDBContext _context;

        public ForecastsController(ForecastDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<Main>> GetWeatherMains()
        {
            return await _context.Mains.ToListAsync();
            
        }
    }
}
