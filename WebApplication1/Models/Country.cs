﻿namespace WebApplication1.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string? CountryName { get; set; }

        //Relationship
        public int? WeatherId { get; set; }
        public Weather Weather { get; set; }

    }
}