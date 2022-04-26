using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Country
{
    public class UpdateCountryDtoBase : BaseCountryDto
    {
        [Required]
        public int Id { get; set; }
    }
}