using VideoRentalOnlineShopApp.DataAccess.Interfaces;
using VideoRentalOnlineShopApp.Domain;

namespace VideoRentalOnlineShopApp.DataAccess.Implementations
{
    public class UserRepository : IRepository<User>
    {
        private readonly VideoRentalOnlineShopAppDbContext _contex;

        public UserRepository(VideoRentalOnlineShopAppDbContext contex)
        {
            _contex = contex;
        }
        public List<User> GetAll()
        {
            var users = _contex.Users.ToList();
            return users;
        }

        public User GetById(int id)
        {
            var user = _contex.Users.FirstOrDefault(u => u.Id == id);
            return user;
        }

        public void Create(User entity)
        {
            _contex.Users.Add(entity);
            _contex.SaveChanges();
        }

        public void Update(User entity)
        {
            _contex.Users.Update(entity);
            _contex.SaveChanges();
        }
        public void Delete(int id)
        {
            var userToDelete = GetById(id);
            if (userToDelete != null)
            {
                _contex.Users.Remove(userToDelete);
                _contex.SaveChanges();
            }
        }
    }
}
