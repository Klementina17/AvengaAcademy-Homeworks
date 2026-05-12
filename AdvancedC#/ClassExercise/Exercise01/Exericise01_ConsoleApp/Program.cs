using Exericise01_ConsoleApp.Models;
using Exericise01_ConsoleApp.StaticClasses;

Dog Buli = new Dog()
{
    Id = 1,
    Name = "Buli",
    Color = "White"
};

Dog Snupi = new Dog()
{
    Id = 2,
    Name = "Snupi",
    Color = "Yellow"
};

Dog Astor = new Dog()
{
    Id = 3,
    Name="Astor",
    Color = "Grey"
};

Buli.Bark();

Console.WriteLine(Dog.Validate(Buli.Id,Buli.Name,Buli.Color));
Console.WriteLine(Dog.Validate(Snupi.Id,Snupi.Name,Snupi.Color));
Console.WriteLine(Dog.Validate(Astor.Id, Astor.Name, Astor.Color));

DogShelter.Dogs.Add(Buli);
DogShelter.Dogs.Add(Snupi);
DogShelter.Dogs.Add(Astor);

DogShelter.PrintAll();