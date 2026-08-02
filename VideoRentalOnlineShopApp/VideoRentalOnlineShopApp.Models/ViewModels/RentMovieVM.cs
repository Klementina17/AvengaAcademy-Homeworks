using System.ComponentModel.DataAnnotations;

namespace VideoRentalOnlineShopApp.Models.ViewModels
{
    public class RentMovieVM
    {
        public int MovieId { get; set; }
        public string? MovieName { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a user.")]
        public int UserId { get; set; }
        public string? UserName { get; set; }

    }
}
