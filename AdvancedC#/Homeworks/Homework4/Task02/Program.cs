using Task02.Models;
//Task02
Console.WriteLine($"========= Task02 =========");
Vehicle car = new Car();
car.DisplayInfo();
Vehicle motorbike = new Motorbike();
motorbike.DisplayInfo();
Vehicle boat = new Boat();
boat.DisplayInfo();
Vehicle plane = new Airplane();
plane.DisplayInfo();

Console.WriteLine($"========= Task03 =========");
//Task03
Car car2 = new Car();
car2.Drive();
Motorbike motorbike2 = new Motorbike();
motorbike2.Wheelie();
Boat boat2 = new Boat();
boat2.Sail();
Airplane plane2 = new Airplane();
plane2.Fly();
