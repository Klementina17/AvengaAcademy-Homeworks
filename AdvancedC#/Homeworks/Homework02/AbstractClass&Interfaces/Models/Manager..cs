using AbstractClass_Interfaces.BaseEntity;

namespace AbstractClass_Interfaces.Models
{
    public class Manager : Employee
    {
        public decimal BaseSalary { get; set; }
        public decimal Bonus { get; set; }
        public override decimal CalculateSalary()
        {
            return BaseSalary + Bonus;
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
