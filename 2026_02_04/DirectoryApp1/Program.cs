namespace DirectoryApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dirPath = $"C:\\Work\\MyDirectory";
            Directory.CreateDirectory(dirPath);

            if (Directory.Exists(dirPath))
            {
                Console.WriteLine("디렉토리가 존재합니다.");
            }
            else
            {
                Console.WriteLine("디렉토리가 존재하지 않습니다.");
            }

            Directory.Delete(dirPath);
        }
    }
}
