using AbstractClass_Interfaces.BaseEntity;
using AbstractClass_Interfaces.Interfaces;
using System.Runtime.Intrinsics.Arm;

namespace AbstractClass_Interfaces.Models
{
    public class Circle : Shape, IShape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double GetArea()
        {
            double Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }
    }
}
