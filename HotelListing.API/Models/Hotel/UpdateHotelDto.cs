using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Models.Hotel
{
	public class UpdateHotelDto : BaseHotelDto
	{
        public int Id { get; set; }
    }
}

