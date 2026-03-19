
string[] names = new string[]
{ "Klementina","Kirila","Tadej","Kalina","Buli"};

double[] decimalNumbers = new double[]
{  0.22, 1.25, 3.33, 5.75, 5.57 };

char[] characters = new char[]
{ 'K','D','M','V','B'};

bool[] flags = new bool[] { true, false, false, true, true };

int[][] matrix = new int [][]{ new int[] {1,2}, new int[] {3,5}};

Console.WriteLine("Arrayy of Strings");
foreach(string name in names){
    Console.WriteLine(name);
}
Console.ReadLine();
Console.WriteLine("Arrayy of Decimal Numbers");
foreach (double decimalNum in decimalNumbers)
{
    Console.WriteLine(decimalNum);
}
Console.ReadLine();
Console.WriteLine("Arrayy of Characters");
foreach (char character in characters)
{
    Console.WriteLine(character);
}
Console.ReadLine();
Console.WriteLine("Arrayy of True/Flase Values");
foreach (bool flag in flags)
{
    Console.WriteLine(flag);
}
Console.ReadLine();
Console.WriteLine("Matrix");
for(int i = 0; i < matrix.Length; i++)
{
    for(int j = 0; j < matrix[i].Length; j++)
    {
        Console.Write(matrix[i][j] + " ");
    }
    Console.WriteLine();
}

