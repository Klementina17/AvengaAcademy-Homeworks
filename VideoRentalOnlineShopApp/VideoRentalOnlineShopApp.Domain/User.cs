using VideoRentalOnlineShopApp.Domain.Enums;

namespace VideoRentalOnlineShopApp.Domain
{
    public class User : BaseEntity
    {
        
        public string FullName { get; set; }
        public int Age { get; set; }
        public string CardNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsSubscriptionExpired { get; set; }
        public SubscriptionType SubscriptionType { get; set; }

        public ICollection<Rental> Rentals { get; set; }

    }
}
