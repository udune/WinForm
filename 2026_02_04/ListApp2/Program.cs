namespace ListApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> scoreList = new List<int>
            { 85, 90, 78, 92, 88 };

            List<int> passList = new List<int>();

            foreach (int score in scoreList)
            {
                if(score >= 80)
                {
                    passList.Add(score);
                }
            }

            Console.WriteLine("Passing Scores:");
            Console.WriteLine($"총 합격자 수 : {passList.Count}");
            foreach (int passScore in passList)
            {
                Console.WriteLine($"{passScore}");
            }
        }
    }
}
