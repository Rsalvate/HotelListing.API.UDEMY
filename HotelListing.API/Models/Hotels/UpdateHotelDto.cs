using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Hotels
{
    public class UpdateHotelDto : BaseHotelDto
    {
        [Required]
        public int Id { get; set; }
    }
}
