namespace ListApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");

            Console.WriteLine($"총 인원수 : {names.Count}");
            Console.WriteLine();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
