namespace FirstApp_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            for (int i = 1, j = 0; i <= 10; i++, j++)
            {
                Console.WriteLine($"{i}, {j}");
            }
        }
    }
}
