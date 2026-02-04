namespace FirstApp_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int j = 1; j <= 9; j++)
            {
                
                for (int i = 2; i <= 9; i++)
                {
                    Console.Write($"{i}x{j}={i * i, 2}  ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("단을 입력해주세요.");
            int dan = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{dan} x {i} = {dan * i}");
            }
        }
    }
}
