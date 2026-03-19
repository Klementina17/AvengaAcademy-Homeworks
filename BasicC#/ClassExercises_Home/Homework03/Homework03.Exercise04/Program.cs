int[] numbers = new int[5];
int index = 0;

for(; ; )
{
    if (index == numbers.Length)
    {
        Console.WriteLine("Array is full.");
        break;
    }

    Console.WriteLine("Enter number: ");
    bool isParsedNumber = int.TryParse(Console.ReadLine(),out int number);

    if (!isParsedNumber)
    {
        Console.WriteLine("Enter valid number.");
        return;
    }

    numbers[index] = number;
    index++;

    Console.WriteLine("This will go on forever until you enter X or x!");
    string input = Console.ReadLine();
    if (input == "X" || input == "x")
        break;
}

foreach (int num in numbers)
{
    Console.WriteLine(num);
}
