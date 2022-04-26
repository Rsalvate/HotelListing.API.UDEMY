using AutoMapper;
using HotelListing.API.Data.Entity;
using HotelListing.API.Models.Country;
using HotelListing.API.Models.Hotels;

namespace HotelListing.API.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDtoBase>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();
        }
    }
}
