namespace FirstApp_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            char reset = 'n';
            int score = 0;

            do
            {
                int dice = rnd.Next(1, 7);
                score += dice;
                Console.WriteLine($"결과는 {dice}이고 현재 점수는 {score}입니다.");

                if (score == 30)
                {
                    Console.WriteLine("30점! 클리어!");
                    break;
                }
                else if (score > 30)
                {
                    Console.WriteLine("30점 초과! 다시 시작합니다.");
                    score = 0;
                }
                
                Console.Write("다시 굴릴까요? (y/n): ");
                reset = char.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (reset == 'y');

            Console.WriteLine($"최종 점수는 {score}입니다");
        }
    }
}
