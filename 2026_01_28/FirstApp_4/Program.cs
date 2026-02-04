namespace FirstApp_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            if (number > 0)
            {
                Console.WriteLine("양수입니다.");
            }
            else if (number < 0)
            {
                Console.WriteLine("음수입니다.");
            }
            else
            {
                Console.WriteLine("0입니다.");
            }

            Console.ReadLine();
        }
    }
}