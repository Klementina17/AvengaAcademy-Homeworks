using VideoRentalOnlineShopApp.Domain;

namespace VideoRentalOnlineShopApp.Models.ViewModels
{
    public class RentalVM
    {
        public int Id { get; set; }
        public DateTime RentedOn { get; set; }
        public DateTime? ReturnedOn { get; set; }
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}
