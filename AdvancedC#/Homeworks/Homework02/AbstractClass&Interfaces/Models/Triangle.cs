using AbstractClass_Interfaces.BaseEntity;
using AbstractClass_Interfaces.Interfaces;

namespace AbstractClass_Interfaces.Models
{
    // Removed the interface IShape  because of method(which is needed to be implement and i commented the previous propreties)
    public class Triangle : Shape
    {
        //public double Base { get; set; }
        //public double Height { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(
                s * (s - SideA) * (s - SideB) * (s - SideC)
            );
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        //public double GetArea()
        //{
        //    double num = 0.5;
        //    double Area = num*Base * Height;
        //    return Area;

        //}
    }
}
