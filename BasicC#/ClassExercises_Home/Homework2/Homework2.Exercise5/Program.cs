//Create two variables and initialize them
//Determine which number is larger
//Determine whether the larger number is even or odd

Console.WriteLine("Enter first number: ");
bool isParsedNumber1 = int.TryParse(Console.ReadLine(), out int firstNumber);
Console.WriteLine("Enter second number: ");
bool isParsedNumber2 = int.TryParse(Console.ReadLine(), out int secondNumber);

if(!isParsedNumber1 || !isParsedNumber2)
{
    Console.WriteLine("Please enter valid numbers!");
    return;
}

if (firstNumber == secondNumber)
{
    Console.WriteLine("Numbers are equal");
    if (firstNumber % 2 == 0)
    {
        Console.WriteLine("And the numbers are even. ");
    }
    else
    {
        Console.WriteLine("And the numbers are odd.");
    }
}
else if (firstNumber > secondNumber)
{
    Console.WriteLine("The larger number from the two is: " + firstNumber);
    if (firstNumber % 2 == 0)
    {
        Console.WriteLine("And the number is even.");
    }
    else
    {
        Console.WriteLine("And the number is odd.");
    }
}
else
{
    Console.WriteLine("The larger number from the two is: " + secondNumber);
    if (secondNumber % 2 == 0)
    {
        Console.WriteLine("And the number is even.");
    }
    else
    {
        Console.WriteLine("And the number is odd.");
    }
}



