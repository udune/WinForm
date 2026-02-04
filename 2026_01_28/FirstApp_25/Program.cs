namespace FirstApp_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "사과", "바나나", "포도", "딸기", "복숭아" };
            foreach (string item in fruits)
            {
                Console.WriteLine(item);
            }

            List<int> number = new List<int>() { 1, 2, 3, 4, 5 };
            foreach (int item in number)
            {
                Console.WriteLine(item);
            }
        }
    }
}
