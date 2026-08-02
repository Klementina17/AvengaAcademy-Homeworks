using System.ComponentModel.DataAnnotations;

namespace VideoRentalOnlineShopApp.Models.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Card number is required.")]
        public string CardNumber { get; set; }
    }
}
