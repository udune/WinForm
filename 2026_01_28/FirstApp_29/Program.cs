namespace FirstApp_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요: ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 2; i <= num; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write($"{i} ");
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"총 소수 개수: {count}");
        }

        static bool IsPrime(int num) 
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
