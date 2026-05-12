using Homework03.BaseEntity;

namespace Homework03.Models
{
    public class Boat : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Im a boat and i do not have wheels :(");
        }
    }
}
