namespace Exercise01.Interfaces
{
    public interface IUser
    {
         int Id { get; set; }
         string Name { get; set; }
         string UserName { get; set; }
         string Password { get; set; }

        void PrintUser();
    }
}
