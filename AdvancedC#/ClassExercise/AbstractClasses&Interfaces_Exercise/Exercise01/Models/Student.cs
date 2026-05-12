using Exercise01.BaseEntity;
using Exercise01.Interfaces;

namespace Exercise01.Models
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; } = new List<int>();

        public Student()
        {
            
        }
        public Student(int id, string name, string username, string password, List<int> grades) : base(id, name, username, password)
        {
            Grades = grades;
        }
        public override void PrintUser()
        {
            //base.PrintUser();
            Console.WriteLine("Grades: ");
            foreach (var grade in Grades)
            {
                Console.WriteLine($"{grade}");
            }
        }
    }
}
