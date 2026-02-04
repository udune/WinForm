namespace FirstApp_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                default:
                    Console.WriteLine("알 수 없는 요일");
                    break;
            }

            Console.ReadLine();
        }
    }
}
