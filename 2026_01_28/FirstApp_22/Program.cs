namespace FirstApp_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ~ 100 사이의 숫자를 맞춰보세요!");
            Random rnd = new Random();
            int secret = rnd.Next(1, 101);

            int answer = 0;
            int count = 0;

            while (answer != secret)
            {
                Console.Write("숫자 입력: ");
                answer = int.Parse(Console.ReadLine());
                count++;

                if (answer < secret)
                {
                    Console.WriteLine("UP");
                }
                else if (answer > secret)
                {
                    Console.WriteLine("DOWN");
                }
                else
                {
                    Console.WriteLine($"정답! {count}번 만에 맞췄습니다.");
                }
            }
        }
    }
}
