// Make a new console application called StudentGroup
// Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
// Get a number from the console between 1 and 2 and print the students from that group in the console.
// Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
string []  studentsG1=new string[]{
    "Klementina",
    "Kirila",
    "Adriana",
    "Dimitar",
    "Mario"
};
string[] studentsG2 = new string[]
{
    "Edon",
    "Ognen",
    "Damjan",
    "Teodora",
    "David"
};

while (true)
{
    Console.WriteLine("Enter student group (1 or 2): ");
    bool isParsedNum = int.TryParse(Console.ReadLine(), out int number);

    if (!isParsedNum)
    {
        Console.WriteLine("Enter valid number");
        continue;
    }
     if (number == 1)
    {
        Console.WriteLine("The Students in G1 are:");
        foreach (string student in studentsG1)
        {
            Console.WriteLine(student);
        }
        break;
    }
    else if (number == 2)
    {
        Console.WriteLine("The Students in G2 are:");
        foreach (string student in studentsG2)
        {
            Console.WriteLine(student);
        }
        break;
    }
    else
    {
        Console.WriteLine("Enter number between 1 and 2.");
        continue;
    }

}
