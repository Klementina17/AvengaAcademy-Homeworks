Console.WriteLine("Enter First number");
bool isParsedFirstNum = int.TryParse(Console.ReadLine(), out int num1);

Console.WriteLine("Enter Second number");
bool isParsedSecondNum = int.TryParse(Console.ReadLine(), out int num2);

if(!isParsedFirstNum || !isParsedSecondNum)
{
    Console.WriteLine("Enter valid number");
    return;
}

int temp;

temp = num1;
num1 = num2;
num2 = temp;

//the other way
//(num1, num2) = (num2, num1);

Console.WriteLine("First number: " + num1);
Console.WriteLine("Second number: " + num2);

