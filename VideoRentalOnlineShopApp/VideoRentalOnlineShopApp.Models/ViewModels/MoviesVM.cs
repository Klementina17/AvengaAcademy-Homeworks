using VideoRentalOnlineShopApp.Domain.Enums;

namespace VideoRentalOnlineShopApp.Models.ViewModels
{
    public class MoviesVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public Language Language { get; set; }
        public bool IsAvailable { get; set; }
        public TimeSpan Length { get; set; }
    }
}
