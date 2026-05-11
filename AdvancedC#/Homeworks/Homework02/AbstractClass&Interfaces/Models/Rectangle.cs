using AbstractClass_Interfaces.BaseEntity;
using AbstractClass_Interfaces.Interfaces;

namespace AbstractClass_Interfaces.Models
{
    public class Rectangle : Shape,IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
             return 2 * (Width + Height);
        }

        public double GetArea()
        {
            double Area = Width * Height;
            return Area;
        }
    }


}
