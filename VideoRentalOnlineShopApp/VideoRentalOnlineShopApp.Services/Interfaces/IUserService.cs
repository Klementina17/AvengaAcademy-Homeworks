using VideoRentalOnlineShopApp.Domain;

namespace VideoRentalOnlineShopApp.Services.Interfaces
{
    public interface IUserService
    {
        User GetUserByCardNumber(string cardNumber);
    }
}
