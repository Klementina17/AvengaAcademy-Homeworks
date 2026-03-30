


static void NumberStats(double number)
{
    bool isPositive = number > 0 ? true : false;
    bool isEven = number % 2 == 0 ? true : false;
    bool isInteger = number % 1 == 0 ? true : false;

    Console.WriteLine($"Stats for number: {number}: ");
    Console.WriteLine(string.Format("{0}", isPositive ? "Positive" : "Negative"));
    Console.WriteLine(string.Format("{0}", isInteger ? "Integer" : "Double"));

    if (!isInteger)
    {
        Console.WriteLine("Not even not odd as well! Decimal number");
    }
    else if (isEven)
    {
        Console.WriteLine("Even");
    }
    else
    {
        Console.WriteLine("Odd");
    }
}


bool UserInterface()
{
    Console.WriteLine("Enter number: ");
    bool isNum = double.TryParse(Console.ReadLine(), out double number);

    if (!isNum)
    {
        Console.WriteLine("Enter valid number!");
        return false;
    }
    NumberStats(number);

    Console.WriteLine("Press any key to try again or X to exit!");
    if (Console.ReadLine().ToUpper()=="X")
        return true;

    return false;
}
while (!UserInterface());