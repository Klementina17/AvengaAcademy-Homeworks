namespace AbstractClass_Interfaces.BaseEntity
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public void DisplayInfo()
        {
            Console.WriteLine($"Area is: {CalculateArea():0.00}");
            Console.WriteLine($"Perimeter is: {CalculatePerimeter(): 0.00}");
        }
    }
}
