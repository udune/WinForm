namespace FirstApp_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("줄 수를 입력하세요");
            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= lines+i; j++)
                {
                    if (j > lines + 1 - i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
