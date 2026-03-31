using ClassLibrary.BaseSetup.Enums;
using ClassLibrary.BaseSetup.Models;

Employee marko = new Employee(42000)
{
    FirstName = "Marko",
    Type=EmployeeType.Sales,
    LastName = "Markovski"
};
marko.PrintInfo();
Console.WriteLine(marko.GetSalary());
Console.WriteLine("----------------------------");

Employee tadej = new Employee("Tadej", "Markovski", EmployeeType.Manager, 6000);
tadej.PrintInfo();
Console.WriteLine(tadej.GetSalary());
Console.WriteLine("----------------------------");

SalesPerson kirila = new SalesPerson("Kirila", "Dimitrova", 3500);
kirila.PrintInfo();
Console.WriteLine(kirila.GetSalary());
kirila.AddSuccessRevenue(2000); 
kirila.PrintInfo();

Console.WriteLine("----------------------------");
Manager klementina = new Manager("Klementina", "Dimitrova", EmployeeType.Manager, 2500, 70000);
klementina.PrintInfo();
Console.WriteLine(klementina.GetSalary());
klementina.AddBonus(500);
klementina.PrintInfo();


