using ClassLibrary.BaseSetup.Enums;

namespace ClassLibrary.BaseSetup.Models;

public class SalesPerson : Employee
{
    private double SuccessSaleRevenue { get; set; }

    public SalesPerson(string firstName,string lastName, double successSaleRevenue) : base(firstName,lastName,EmployeeType.Sales,500)
    {
        SuccessSaleRevenue = successSaleRevenue;
    }

    public void AddSuccessRevenue(double revenue)
    {
        SuccessSaleRevenue += revenue;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Hello {FirstName} {LastName}. You type is : {Type}, your salary is {Salary} and you have added revenue {SuccessSaleRevenue}.");
        Console.WriteLine($"Total Salary with bonus: {GetSalary()}");
    }

    public override double GetSalary()
    {
        double bonus = 0;
        if (SuccessSaleRevenue <= 2000)
        {
            bonus = 500;
        }
        else if (SuccessSaleRevenue <= 5000)
        {
            bonus = 1000;
        }
        else
        {
            bonus = 1500;
        }
        return Salary+bonus;
    }

}
