namespace WebApplication1.Models
{
    public class Weather
    {
        public int Id { get; set; }
        public string? WeatherName { get; set; }
        
        public int Temperature { get; set; }
        

        public ICollection<Country> Countries { get; set; }
    }
}
