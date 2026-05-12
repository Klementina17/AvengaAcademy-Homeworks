namespace Exericise01_ConsoleApp.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public Dog()
        {
            
        }
        public Dog(string name,string color)
        {
            Name = name;
            Color = color;
            
        }
        public void Bark()
        {
            Console.WriteLine($"Wooff woof woof...");
        }

        public static bool Validate(int id, string name, string color)
        {
            return id >= 0 && !string.IsNullOrWhiteSpace(name) && name.Length >= 2 && !string.IsNullOrWhiteSpace(color);
        }
    }
}
