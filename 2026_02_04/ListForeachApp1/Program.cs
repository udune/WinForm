namespace ListForeachApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>()
            {
                "Apple",
                "Banana",
                "Cherry",
                "Date"
            };

            foreach (string fruit in fruits)
            {
                Console.Write($" {fruit} ");
            }
        }
    }
}
