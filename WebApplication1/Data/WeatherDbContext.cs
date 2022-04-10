using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
namespace WebApplication1.Data
{
    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext(DbContextOptions<WeatherDbContext> options): base(options)
        {

        }
        public DbSet<Country>? Country { get; set; }
        public DbSet<Weather>? Weather { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=weatherdb;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Weather>().HasData(
                new Weather
                {

                    Id = 1,
                    WeatherName = "Rainy",
                    Temperature = 10,

                    
                },
                 new Weather
                 {
                     Id = 2,
                     WeatherName = "Sunny",
                     Temperature = 20
                 },
                  new Weather
                  {
                      Id = 3,
                      WeatherName = "Snowy",
                      Temperature = 0
                  }
            );

           modelBuilder.Entity<Country>().HasData(
                new Country
                { 
                    CountryId = 1, 
                    CountryName = "Sweden" ,
                    WeatherId = 1,
                },
                 new Country
                 {
                     CountryId = 2,
                     CountryName = "Spain",
                     WeatherId = 1,

                 },
                  new Country
                  {
                      CountryId = 3,
                      CountryName = "Norway",
                      WeatherId= 1,
                  }
            );
        }
    }
   
}