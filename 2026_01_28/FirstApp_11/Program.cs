namespace FirstApp_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 4620;
            int a = m / 1000;
            int b = (m % 1000) / 500;
            int c = (m % 500) / 100;
            int d = (m % 100) / 10;

            Console.WriteLine($"1000원의 개수 : {a}");
            Console.WriteLine($"500원의 개수 : {b}");
            Console.WriteLine($"100원의 개수 : {c}");
            Console.WriteLine($"10원의 개수 : {d}");

            Console.ReadLine();
        }
    }
}
