namespace Task01
{
    public static class PrintInConsole
    {

        public static void Print<T>(T item)
        {
            Console.WriteLine($"{item}");
        }


        public static void PrintCollection<T>(List<T> items)
        {
            foreach(T item in items)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
