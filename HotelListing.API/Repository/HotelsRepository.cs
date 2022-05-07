using HotelListing.API.Contracts;
using HotelListing.API.Data;
using HotelListing.API.Data.Entity;

namespace HotelListing.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
