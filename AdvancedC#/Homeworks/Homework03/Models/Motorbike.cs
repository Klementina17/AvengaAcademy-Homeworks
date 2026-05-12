using Homework03.BaseEntity;

namespace Homework03.Models
{
    public class Motorbike : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Im a motorbike and i drive on 2 wheels :)");
        }
    }
}
