namespace Homework03.Models
{
    public static class UserDatabase
    {
        public static List<User> Users { get; set; } = new List<User>();

        static UserDatabase()
        {
            Users = new List<User>()
            {
               new User{Id=1,Name="Klementina",Age=26},
               new User{Id=2,Name="Kirila",Age=23}
            };
        }

        public static User SearchById(int id)
        {
            return Users.FirstOrDefault(u => u.Id == id);
        }

        public static List<User> SearchByName(string name)
        {
            return Users.Where(u => u.Name.ToLower() == name.ToLower()).ToList();
        }

        public static List<User> SearchByAge(int age)
        {
            return Users.Where(u => u.Age == age).ToList();
        }

        public static List<User> SearchByNameAndAge(string name,int age)
        {
            return Users.Where(u => u.Name.ToLower() == name.ToLower() && u.Age == age).ToList();
        }
    }
}
