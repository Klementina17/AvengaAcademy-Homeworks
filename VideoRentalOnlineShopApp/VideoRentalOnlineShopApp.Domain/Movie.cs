using VideoRentalOnlineShopApp.Domain.Enums;

namespace VideoRentalOnlineShopApp.Domain
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public Language Language { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Length { get; set; }
        public int AgeRestriction { get; set; }
        public int Quantity { get; set; }

        public ICollection<Rental> Rentals { get; set; }
        public ICollection<Cast> Casts { get; set; }
    }
}
