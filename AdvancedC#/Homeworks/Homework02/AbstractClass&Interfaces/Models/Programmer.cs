using AbstractClass_Interfaces.BaseEntity;

namespace AbstractClass_Interfaces.Models
{
    public class Programmer : Employee
    {
        public decimal HourlyRate { get; set; }
        public decimal HoursWorked { get; set; }
        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Role: Manager");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Salary: {CalculateSalary():F2}");
            Console.WriteLine("----------------------");
        }
    }
}
