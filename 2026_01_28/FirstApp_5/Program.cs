namespace FirstApp_5
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

            int age = 25;

            if (age > 65)
            {
                Console.WriteLine("노인입니다");
            }
            else if (age <= 65 && age >= 19)
            {
                Console.WriteLine("성인입니다");
            }
            else if (age < 19 && age >= 13)
            {
                Console.WriteLine("청소년");
            }
            else
            {
                Console.WriteLine("어린이입니다");
            }

            Console.ReadLine();
        }
    }
}
