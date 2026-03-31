using ClassLibrary.BaseSetup.Enums;

namespace ClassLibrary.BaseSetup.Models;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public EmployeeType Type { get; set; }
    protected double Salary { get; set; }

    public Employee(double salary)
    {
        Salary = salary;
    }
    public Employee(string firstName,string lastName,EmployeeType type,double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Type = type;
        Salary = salary;
    }
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Hello {FirstName} {LastName}. You type is : {Type} and your salary is {Salary}.");
    }

    public virtual double GetSalary()
    {
        return Salary;
    }
}
