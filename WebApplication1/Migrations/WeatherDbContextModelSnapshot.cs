﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(WeatherDbContext))]
    partial class WeatherDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApplication1.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WeatherId")
                        .HasColumnType("int");

                    b.HasKey("CountryId");

                    b.HasIndex("WeatherId");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "Sweden",
                            WeatherId = 1
                        },
                        new
                        {
                            CountryId = 2,
                            CountryName = "Spain",
                            WeatherId = 2
                        },
                        new
                        {
                            CountryId = 3,
                            CountryName = "Norway",
                            WeatherId = 3
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Weather", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Temperature")
                        .HasColumnType("int");

                    b.Property<string>("WeatherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Weather");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Temperature = 10,
                            WeatherName = "Rainy"
                        },
                        new
                        {
                            Id = 2,
                            Temperature = 20,
                            WeatherName = "Sunny"
                        },
                        new
                        {
                            Id = 3,
                            Temperature = 0,
                            WeatherName = "Snowy"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Country", b =>
                {
                    b.HasOne("WebApplication1.Models.Weather", "Weather")
                        .WithMany("Countries")
                        .HasForeignKey("WeatherId");

                    b.Navigation("Weather");
                });

            modelBuilder.Entity("WebApplication1.Models.Weather", b =>
                {
                    b.Navigation("Countries");
                });
#pragma warning restore 612, 618
        }
    }
}
