namespace FileApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = $"C:\\Work\\testout.txt";
            // File.Create(path);

            File.WriteAllText(path, "Hello World!");

            if (File.Exists(path))
            {
                Console.WriteLine("파일이 존재합니다.");
            }
        }
    }
}
