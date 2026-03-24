while (true)
{
    Console.WriteLine("Enter number: ");
    bool isParsedNum = int.TryParse(Console.ReadLine(), out int number);

    if (!isParsedNum)
    {
        Console.WriteLine("Enter valid number!");
        continue;
    }
    else
    {
        string newMess = Substrings(number);
        Console.WriteLine(newMess);
        Console.WriteLine("Lenght: " + newMess.Length);
        break;
    }
}
static string Substrings(int number)
{
    string message = "Hello from Avenga Codecademy 2024";

    if (number < 0)
    {
        return "Number cannot be negative!";
    }

    if (number > message.Length)
    {
        number = message.Length;
    }
    string newMessage = message.Substring(0, number);
    return newMessage;
}

