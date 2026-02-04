namespace TryCatchApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            try
            {
                int divnum = 0;
                result = 10 / divnum;
            } catch (DivideByZeroException e)
            {
                Console.WriteLine($"0으로 나눌수 없습니다 [{e.Message}]");
            }
            finally
            {
                Console.WriteLine(result);
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
