namespace FirstApp_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("수학 점수를 입력하세요");
            int math = int.Parse(Console.ReadLine());

            Console.WriteLine("영어 점수를 입력하세요");
            int eng = int.Parse(Console.ReadLine());

            Console.WriteLine("과학 점수를 입력하세요");
            int sci = int.Parse(Console.ReadLine());

            double avg = (math + eng + sci) / 3.0;

            if (avg >= 60 && math >= 40 && eng >= 40 && sci >= 40)
            {
                Console.WriteLine($"합격입니다. 평균 점수: {avg}");
            }
            else
            {
                Console.WriteLine($"불합격입니다. 평균 점수: {avg}");
            }

            Console.ReadLine();
        }
    }
}
