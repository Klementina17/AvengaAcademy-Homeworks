using Homework03.Models;

namespace Homework03.Services
{
    public class UserDatabaseService
    {

        public User SearchById(int id)
        {
            return UserDatabase.Users.FirstOrDefault(user => user.Id == id);
        }

        public List<User> SearchByName(string name)
        {
            return UserDatabase.Users.Where(user => user.Name.ToLower() == name).ToList();
        }

        public List<User> SearchByAge(int age)
        {
            return UserDatabase.Users.Where(user => user.Age == age).ToList();
        }

        public List<User> SearchByNameAndAge(string name,int age)
        {
            return UserDatabase.Users.Where(user => user.Name.ToLower() == name && user.Age == age).ToList();
        }
    }
}
