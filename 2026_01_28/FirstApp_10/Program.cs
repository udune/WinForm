namespace FirstApp_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("요일을 영문으로 입력하세요");

            string dayStr = Console.ReadLine();

            switch (dayStr)
            {
                case "mon":
                    Console.WriteLine("월요일");
                    break;
                case "tue":
                    Console.WriteLine("화요일");
                    break;
                case "wed":
                    Console.WriteLine("수요일");
                    break;
                case "thu":
                    Console.WriteLine("목요일");
                    break;
                case "fri":
                    Console.WriteLine("금요일");
                    break;
                case "sat":
                    Console.WriteLine("토요일");
                    break;
                case "sun":
                    Console.WriteLine("일요일");
                    break;
                default:
                    Console.WriteLine("알 수 없는 요일");
                    break;
            }

            Console.ReadLine();
        }
    }
}
