    Console.WriteLine("Enter the First number");
    bool isParsedFirstNum = int.TryParse(Console.ReadLine(), out int num1);

    Console.WriteLine("Enter the Second number");
    bool isParsedSecondNum = int.TryParse(Console.ReadLine(), out int num2);

    Console.WriteLine("Enter the Third number");
    bool isParsedThirdNum = int.TryParse(Console.ReadLine(), out int num3);

    Console.WriteLine("Enter the Fourth number");
    bool isParsedFourthNum = int.TryParse(Console.ReadLine(), out int num4);

    if (!isParsedFirstNum || !isParsedSecondNum || !isParsedThirdNum || !isParsedFourthNum)
    {
        Console.WriteLine("Enter valid number.");
        return;
    }

    var average = ((double)num1 + num2 + num3 + num4)/4;
    Console.WriteLine("The average of " + num1 + "," + num2 + ","+ num3 + "," + " and " + num4 + " is " + average);


