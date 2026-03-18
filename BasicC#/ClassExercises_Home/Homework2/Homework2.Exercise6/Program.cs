//Ask the user to enter a number from 1 to 3:
//1 → “You got a new car!”
//2 → “You got a new plane!”
//3 → “You got a new bike!”
//Any other input → error message

Console.WriteLine("Enter the number from 1-3: ");
bool isParsedNumber = int.TryParse(Console.ReadLine(), out int number);

if (!isParsedNumber)
{
    Console.WriteLine("Please enter valid number. ");
    return;
}

if(number>0 && number < 4)
{
    if (number == 1)
    {
        Console.WriteLine("You got a new car!");
    }
    else if (number == 2)
    {
        Console.WriteLine("You got a new plane!");
    }
    else
    {
        Console.WriteLine("You got a new bike!");
    }
}
else
{
    Console.WriteLine("Enter number in this range 1-3! ");
}

