namespace HotelListing.API.Data.Entity
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public string ShortName { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }
    }
}