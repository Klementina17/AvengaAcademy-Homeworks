using Homework03.BaseEntity;
using Homework03.Models;

//Task1
User Tadej = new User()
{
    Id = 3,
    Name = "Tadej",
    Age = 11
};

UserDatabase.Users.Add(Tadej);

var users=UserDatabase.SearchByName("Tadej");

foreach(var u in users)
{
    Console.WriteLine($"{u.Name}");
}

var user = UserDatabase.SearchById(2) ?? throw new KeyNotFoundException("User not found!");
Console.WriteLine($"{user.Id}.{user.Name}");

//Task2

Vehicle car = new Car();
car.DisplayInfo();
Vehicle motorbike = new Motorbike();
motorbike.DisplayInfo();
Vehicle boat = new Boat();
boat.DisplayInfo();
Vehicle airplane = new Airplane();
airplane.DisplayInfo();



