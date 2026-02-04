namespace FirstApp_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요");
            int num = int.Parse(Console.ReadLine());

            if (num % 3 == 0 && num % 2 == 0)
            {
                Console.WriteLine($"{num}은 짝수이면서 3의 배수입니다.");
                return;
            }

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num}은(는) 짝수입니다.");
                return;
            }

            if (num % 3 == 0)
            {
                Console.WriteLine($"{num}은(는) 3의 배수입니다.");
                return;
            }

            Console.WriteLine($"{num}은 둘 다 아닙니다.");
        }
    }
}
