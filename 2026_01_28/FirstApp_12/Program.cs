namespace FirstApp_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 a를 입력하세요");
            string a = Console.ReadLine();

            Console.WriteLine("숫자 b를 입력하세요");
            string b = Console.ReadLine();

            int intA = int.Parse(a);
            int intB = int.Parse(b);

            if (intA > intB)
            {
                Console.WriteLine("a가 b보다 큽니다.");
            }
            else if (intA < intB)
            {
                Console.WriteLine("a가 b보다 작습니다.");
            }
            else
            {
                Console.WriteLine("a와 b는 같습니다.");
            }

            Console.ReadLine();
        }
    }
}
