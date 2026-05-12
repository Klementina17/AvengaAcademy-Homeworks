using Exercise01.Interfaces;

namespace Exercise01.BaseEntity
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        protected User()
        {
            
        }
        protected User(int id,string name,string username,string password)
        {
            Id = id;
            Name = name;
            UserName = username;
            Password = password;
        }
        public virtual void PrintUser()
        {
            Console.WriteLine($"{Id}. Name: {Name} - Username: {UserName}");
        }
    }
}
