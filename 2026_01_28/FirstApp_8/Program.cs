namespace FirstApp_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            if (num > 0 && num % 2 == 0)
            {
                Console.WriteLine("양의 짝수입니다.");
            }
            else if (num > 0 && num % 2 != 0)
            {
                Console.WriteLine("양의 홀수입니다.");
            }
            else if (num < 0 && num % 2 == 0)
            {
                Console.WriteLine("음의 짝수입니다.");
            }
            else if (num < 0 && num % 2 != 0)
            {
                Console.WriteLine("음의 홀수입니다.");
            }
            else if (num == 0)
            {
                Console.WriteLine("0입니다.");
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다");
            }

            Console.ReadLine();
        }
    }
}
