using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
	public class CountryConfiguration : IEntityTypeConfiguration<Country>
	{
		public void Configure(EntityTypeBuilder<Country> builder)
		{
			builder.HasData(
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
		}
	}
}

