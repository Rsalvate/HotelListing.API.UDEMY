using HotelListing.API.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configuration
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(MockHotel());
        }
        private IList<Hotel> MockHotel()
        {
            return new List<Hotel>(){new Hotel
            {
                Id = 1,
                Name = "Heaney-Pollich",
                Address = "42 Chive Road",
                Rating = 1.2,
                CountryId = 3
            },
             new Hotel
             {
                 Id = 2,
                 Name = "Wuckert Group",
                 Address = "9 Aberg Court",
                 Rating = 2.1,
                 CountryId = 2
             }, new Hotel
             {
                 Id = 3,
                 Name = "Hermiston-Turcotte",
                 Address = "84 Thompson Crossing",
                 Rating = 4.7,
                 CountryId = 2
             }, new Hotel
             {
                 Id = 4,
                 Name = "Will-Keebler",
                 Address = "70 Stephen Place",
                 Rating = 3.4,
                 CountryId = 1
             }, new Hotel
             {
                 Id = 5,
                 Name = "Schuppe-Kovacek",
                 Address = "52 Stephen Way",
                 Rating = 1.4,
                 CountryId = 3
             }, new Hotel
             {
                 Id = 6,
                 Name = "Dietrich, Berge and Deckow",
                 Address = "902 Tony Trail",
                 Rating = 4.6,
                 CountryId = 3
             }, new Hotel
             {
                 Id = 7,
                 Name = "Monahan, O'Reilly and Greenholt",
                 Address = "9968 Bayside Alley",
                 Rating = 4.3,
                 CountryId = 3
             }, new Hotel
             {
                 Id = 8,
                 Name = "Christiansen-Huel",
                 Address = "5846 Debra Plaza",
                 Rating = 4.9,
                 CountryId = 2
             }, new Hotel
             {
                 Id = 9,
                 Name = "Emmerich, Gutkowski and MacGyver",
                 Address = "99440 Melrose Crossing",
                 Rating = 2.9,
                 CountryId = 3
             }, new Hotel
             {
                 Id = 10,
                 Name = "Toy Group",
                 Address = "1490 Cardinal Street",
                 Rating = 1.5,
                 CountryId = 3
             }
            };
        }
    }
}
