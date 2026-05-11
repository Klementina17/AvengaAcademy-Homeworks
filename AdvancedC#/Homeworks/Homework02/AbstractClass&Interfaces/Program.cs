
using System.Reflection.Metadata;
using AbstractClass_Interfaces.BaseEntity;
using AbstractClass_Interfaces.Models;

Documents doc = new Documents
{
    Title = "C# Notes",
    Content = "Interfaces are very useful in C#"
};

Console.WriteLine(doc.Search("Java"));
Console.WriteLine(doc.Search("C#"));

WebPage wPage = new WebPage
{
    Url = "google.com",
    Html = "<h1>Hello.</h1>"
};
Console.WriteLine(wPage.Search("hello"));

List<double> areasOfNum = new List<double>();

Circle cirle = new Circle
{
    Radius = 10
};
areasOfNum.Add(cirle.GetArea());

Rectangle rectangle = new Rectangle
{
    Height = 157,
    Width = 51
};
areasOfNum.Add(rectangle.GetArea());

//Triangle triangle = new Triangle
//{
//    Base = 5.3,
//    Height = 3
//};

//areasOfNum.Add(triangle.GetArea());

foreach (var area in areasOfNum)
{
    Console.WriteLine($"Area: {area}");
}

cirle.DisplayInfo();

Employee[] employees = new Employee[2];
Manager Marko = new Manager
{
    Id = 1,
    Name="Marko",
    BaseSalary=27000,
    Bonus=3000
};

Programmer Klementina = new Programmer
{
    Id = 2,
    Name = "Klementina",
    HourlyRate = 10,
    HoursWorked = 160

};

employees[0] = Marko;
employees[1] = Klementina;

foreach(var emp in employees)
{
    emp.DisplayInfo();
}
