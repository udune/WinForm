namespace FirstApp_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _id = "admin";
            string _pw = "1234";

            Console.WriteLine("아이디를 입력하세요.");
            string id = Console.ReadLine();

            Console.WriteLine("비밀번호를 입력하세요.");
            string pw = Console.ReadLine();

            if (id != _id)
            {
                Console.WriteLine("아이디가 틀렸습니다.");
                return;
            }
            
            if (pw != _pw)
            {
                Console.WriteLine("비밀번호가 틀렸습니다.");
                return;
            }

            if (id == _id && pw == _pw)
            {
                Console.WriteLine("로그인 성공");
            }
            else
            {
                Console.WriteLine("로그인 실패");
            }

            Console.ReadLine();
        }
    }
}
