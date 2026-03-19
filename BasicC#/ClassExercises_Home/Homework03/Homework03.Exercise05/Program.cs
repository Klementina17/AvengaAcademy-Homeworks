
string[] names=new string[0];

for(; ; )
{
    Console.WriteLine("Enter name:");
    string name = Console.ReadLine();

    Array.Resize(ref names, names.Length+1);

    names[names.Length - 1] = name;

    Console.WriteLine("Do you want to enter another name(y/n): ");
    string input=Console.ReadLine();
    if(input=="n" || input == "N")
    {
        break;
    }
}

Console.WriteLine("All names: ");
foreach(string name in names)
{
    Console.WriteLine(name);
}

