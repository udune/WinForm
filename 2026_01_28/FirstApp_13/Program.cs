namespace FirstApp_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 a를 입력하세요");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("숫자 b를 입력하세요");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("연산자를 입력하세요");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine($"결과: {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"결과: {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"결과: {a * b}");
                    break;
                case "/":
                    Console.WriteLine($"결과: {a / b}");
                    break;
                default:
                    Console.WriteLine("알 수 없는 연산자입니다.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
