namespace StreamReaderApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                string line;
                while (true)
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    Console.WriteLine($"콘솔 출력으로 나온 결과물: {line}");
                }
            }

            string content = File.ReadAllText("input.txt");
            Console.WriteLine(content);

            string[] lines = File.ReadAllLines("input.txt");
            int count = 0;
            foreach (string line in lines)
            {
                count++;
                Console.WriteLine($"{count}. {line}");
            }
        }
    }
}
