using Microsoft.EntityFrameworkCore;
using WeatherApi2.Models; 

namespace WeatherApi2.Data
{
    public class ForecastDBContext: DbContext 
    {
        public ForecastDBContext(DbContextOptions<ForecastDBContext> options):base(options)
        {

        }
        //main bare for nemheds skyld 
        public DbSet<Main> Mains { get; set; }
    }
}
