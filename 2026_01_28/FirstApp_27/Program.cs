namespace FirstApp_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                Console.Write($"{i} ");
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }

                Console.Write($"{i} ");
            }
        }
    }
}
