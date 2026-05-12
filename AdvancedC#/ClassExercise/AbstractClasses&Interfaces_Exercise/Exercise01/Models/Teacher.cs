using Exercise01.BaseEntity;
using Exercise01.Interfaces;

namespace Exercise01.Models
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get; set; }

        public Teacher()
        {
            
        }
        public Teacher(int id,string name,string username,string password,string subject): base(id,name,username,password)
        {
            Subject = subject;
        }
        public override void PrintUser()
        {
            //base.PrintUser();
            Console.WriteLine($"Subject: {Subject}");
        }
    }
}
