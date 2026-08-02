using VideoRentalOnlineShopApp.DataAccess.Interfaces;
using VideoRentalOnlineShopApp.Domain;
using VideoRentalOnlineShopApp.Services.Interfaces;

namespace VideoRentalOnlineShopApp.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public User GetUserByCardNumber(string cardNumber)
        {
            return _userRepository.GetAll().FirstOrDefault(u => u.CardNumber == cardNumber);
        }
    }
}
