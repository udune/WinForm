namespace FirstApp_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("나이를 입력하세요:");
            string input = Console.ReadLine();
            int age = 0;

            if (int.TryParse(input, out age))
            {
                Console.WriteLine($"입력한 나이: {age}");
            }
            else {
                Console.WriteLine($"입력값이 숫자가 아닙니다. [{input}]");
            }

            Console.ReadLine();
        }
    }
}
