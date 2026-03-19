
Console.WriteLine("Enter First number: ");
bool isParsedFirstNum = int.TryParse(Console.ReadLine(), out int num1);
Console.WriteLine("Enter Second number: ");
bool isParsedSecondNum = int.TryParse(Console.ReadLine(), out int num2);

Console.WriteLine("Enter the Operation (+,-,*,/): ");
string operation = Console.ReadLine();

if (!isParsedFirstNum || !isParsedSecondNum)
{
    Console.WriteLine("Enter valid number.");
    return;
}

switch (operation)
{
    case "+":
        int suma = num1 + num2;
        Console.WriteLine(suma);
        break;
    case "-":
        int substraction = num1 - num2;
        Console.WriteLine(substraction);
        break;
    case "*":
        int multiply = num1 * num2;
        Console.WriteLine(multiply);
        break;
    case "/":
        if (num2 == 0)
        {
            Console.WriteLine("We can't divide with zero.");
        }
        else
        {
            double dividion = Convert.ToDouble(num1)/num2;
            Console.WriteLine(dividion); 
        }
        break;

    default:
        Console.WriteLine("Enter valid operation.");
        break;

}
