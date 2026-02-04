namespace DictionaryExApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ages = new Dictionary<string, int>()
            {
                {"Alice", 30 },
                {"Bob", 25 },
                {"Charlie", 35 }
            };

            foreach (string key in ages.Keys)
            {
                Console.WriteLine($"Name: {key}");
            }

            foreach (int value in ages.Values)
            {
                Console.WriteLine($"Age: {value}");
            }

            foreach (KeyValuePair<string, int> entry in ages)
            {
                Console.WriteLine($"Name: {entry.Key}, Age: {entry.Value}");
            }
        }
    }
}
