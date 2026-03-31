using ClassLibrary.BaseSetup.Enums;
namespace ClassLibrary.BaseSetup.Models;

public class Manager : Employee
{
  private double Bonus { get; set; }

    public Manager(string firstName,string lastName,EmployeeType type, double bonus,double salary): base(firstName,lastName,type,salary)
    {
        Bonus = bonus;
    }

    public void AddBonus(double bonus)
    {
        Bonus += bonus;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Hello {FirstName} {LastName}. You type is : {Type}, your salary is {Salary} and you have bonus: {Bonus}.");
        Console.WriteLine($"Total Salary with bonus: {GetSalary()}");  
    }

    public override double GetSalary()
    {
        return Salary+Bonus;
    }
}
