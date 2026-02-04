namespace FirstApp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("나이를 입력하세요:");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            Console.WriteLine($"입력한 나이: {age}");

            Console.WriteLine("엔터 키를 누르면 종료됩니다...");
            Console.ReadLine();
        }
    }
}
