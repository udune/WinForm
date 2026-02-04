namespace FirstApp_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("이번 달 1일의 요일을 숫자로 입력하세요. (1=일요일, 2=월요일, ... 7=토요일)");
            int numDay = int.Parse(Console.ReadLine());

            Console.WriteLine("오늘의 일자를 입력하세요");
            int date = int.Parse(Console.ReadLine());

            int totalDays = numDay + (date - 1);
            int weekDay = totalDays % 7;
            string dayName = "";

            switch (weekDay)
            {
                case 1:
                    dayName = "일요일";
                    break;
                case 2:
                    dayName = "월요일";
                    break;
                case 3:
                    dayName = "화요일";
                    break;
                case 4:
                    dayName = "수요일";
                    break;
                case 5:
                    dayName = "목요일";
                    break;
                case 6:
                    dayName = "금요일";
                    break;
                case 0:
                    dayName = "토요일";
                    break;
            }

            Console.WriteLine($"오늘은 {dayName}입니다.");
        }
    }
}
