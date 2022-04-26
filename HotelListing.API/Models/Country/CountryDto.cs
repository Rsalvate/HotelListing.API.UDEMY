﻿using HotelListing.API.Models.Hotels;

namespace HotelListing.API.Models.Country
{
    public class CountryDto: BaseCountryDto
    {
        public int Id { get; set; }

        public virtual List<HotelDto> Hotels { get; set; }
    }
}
