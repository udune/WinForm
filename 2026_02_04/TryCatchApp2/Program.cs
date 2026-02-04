namespace TryCatchApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strInput = "";

            strInput = Console.ReadLine();

            int num = 0;
            try
            {
                num = int.Parse(strInput);
                ValidateNum(num);
                Console.WriteLine($"입력한 숫자는 {num}입니다.");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"숫자 형식이 아닙니다. [{e.Message}]");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"입력 값이 잘못되었습니다. [{e.Message}]");
            }
            catch (Exception e)
            {
                Console.WriteLine($"알수 없는 오류가 발생했습니다. [{e.Message}]");
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }

            Console.WriteLine("여기까지 도착하면 프로그램 정상 종료");
        }

        static public void ValidateNum(int age) 
        {
            if (age <= 0)
            {
                throw new ArgumentException(" 숫자는 0보다 커야 합니다.");
            }
        }
    }
}
