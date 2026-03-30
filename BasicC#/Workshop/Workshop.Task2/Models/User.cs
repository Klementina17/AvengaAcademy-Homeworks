namespace Workshop.Task2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }
        public User()
        {
            
        }
        public User(int userId,string username,string password,string[] messages)
        {
            Id = userId;
            Username = username;
            Password = password;
            Messages = messages ?? new string[0];

        }
    }
}
