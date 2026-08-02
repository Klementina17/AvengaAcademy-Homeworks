using VideoRentalOnlineShopApp.Domain.Enums;

namespace VideoRentalOnlineShopApp.Domain
{
    public class Cast : BaseEntity
    {
        public string Name { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public Part Part { get; set; }
    }
}
