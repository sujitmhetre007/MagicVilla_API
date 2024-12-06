using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().HasData(new Villa

            {

                Id = 1,

                Name = "Luxury Apartment",

                Details = "A spacious luxury apartment with modern amenities.",

                Rate = 1500.00,

                Sqft = 1200,

                Occupancy = 4,

                ImageUrl = "https://example.com/luxury-apartment.jpg",

                Amenity = "Pool, Gym, Parking",

                CreatedDate = DateTime.Now,

                UpdatedDate = DateTime.Now

            },

            new Villa

            {

                Id = 2,

                Name = "Cozy Studio",

                Details = "A small, cozy studio apartment in the city center.",

                Rate = 800.00,

                Sqft = 450,

                Occupancy = 2,

                ImageUrl = "https://example.com/cozy-studio.jpg",

                Amenity = "Wi-Fi, Coffee Maker",

                CreatedDate = DateTime.Now,

                UpdatedDate = DateTime.Now

            });

        }
    }
}
