// Make a console application called SumOfEven.
// Inside it create an array of 6 integers.
// Get numbers from the input, find and print the sum of the even numbers from the array:
for (; ; )
{
    Console.WriteLine("This will go on forever until you enter X or x!");
    string input = Console.ReadLine();
    if (input == "X" || input == "x") break;

    int[] numbers = new int[0];
    var suma = 0;

    Console.WriteLine("Enter first number: ");
    bool isParsedFirstNum = int.TryParse(Console.ReadLine(), out int num1);

    if (!isParsedFirstNum)
    {
        Console.WriteLine("Enter valid number!");
    }
    else
    {
        Array.Resize(ref numbers, numbers.Length+1);
        numbers[0] = num1;
        Console.WriteLine("Enter second number: ");
        bool isParsedSecondNum = int.TryParse(Console.ReadLine(), out int num2);

        if (!isParsedSecondNum)
        {
            Console.WriteLine("Enter valid number!");
        }
        else
        {
            Array.Resize(ref numbers, numbers.Length+1);
            numbers[1] = num2;
            Console.WriteLine("Enter third number: ");
            bool isParsedThirdNum = int.TryParse(Console.ReadLine(), out int num3);
            if (!isParsedThirdNum)
            {
                Console.WriteLine("Enter valid number!");
            }
            else
            {
                Array.Resize(ref numbers, numbers.Length+1);
                numbers[2] = num3;
                Console.WriteLine("Enter fourth number: ");
                bool isParsedFourthNum = int.TryParse(Console.ReadLine(), out int num4);

                if (!isParsedFourthNum)
                {
                    Console.WriteLine("Enter valid number!");
                }
                else
                {
                    Array.Resize(ref numbers, numbers.Length+1);
                    numbers[3] = num4;
                    Console.WriteLine("Enter fifth number: ");
                    bool isParsedFifthNum = int.TryParse(Console.ReadLine(), out int num5);
                    if (!isParsedFifthNum)
                    {
                        Console.WriteLine("Enter valid number!");
                    }
                    else
                    {
                        Array.Resize(ref numbers, numbers.Length+1);
                        numbers[4] = num5;
                        Console.WriteLine("Enter sixth number: ");
                        bool isParsedSixthNum = int.TryParse(Console.ReadLine(), out int num6);
                        if (!isParsedSixthNum)
                        {
                            Console.WriteLine("Enter valid number!");
                        }
                        else
                        {
                            Array.Resize(ref numbers, numbers.Length+1);
                            numbers[5] = num6;
                        }
                    }
                }
            }
        }
    }

    foreach(int num in numbers)
    {
        if(num%2==0) suma += num;
    }
    Console.WriteLine("The result is: " + suma);
}
