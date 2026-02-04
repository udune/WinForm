namespace FirstApp_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = "admin";
            string password = "1234";

            if (user == "admin")
            {
                if (password == "1234")
                {
                    Console.WriteLine("로그인 성공");
                }
                else
                {
                    Console.WriteLine("로그인 실패");
                }
            }
            else
            {
                Console.WriteLine("로그인 실패");
            }

            Console.WriteLine("엔터키를 누르면 종료합니다");
            Console.ReadLine();
        }
    }
}
