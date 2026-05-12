using Exericise01_ConsoleApp.Models;
namespace Exericise01_ConsoleApp.StaticClasses
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; } = new List<Dog>();

        public static void PrintAll()
        {
            foreach(var dog in Dogs)
            {
                Console.WriteLine($"{dog.Id}. {dog.Name} {dog.Color}");
            }
        }

    }
}
