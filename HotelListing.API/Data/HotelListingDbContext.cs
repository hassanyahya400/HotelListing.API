using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
	public class HotelListingDbContext : DbContext
	{
		public HotelListingDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Hotel> Hotels { get; set; }
		public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 111,
                    Name = "Nigeria",
                    ShortName = "NG"
                },
                new Country
                {
                    Id = 222,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 333,
                    Name = "Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    Id = 444,
                    Name = "Cayman Island",
                    ShortName = "CI"
                }
            );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 111,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Address = "George Town",
                    CountryId = 333,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palldium",
                    Address = "Nassua",
                    CountryId = 222,
                    Rating = 4
                }
            );
        }
    }
}

