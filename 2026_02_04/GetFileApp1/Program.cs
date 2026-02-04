namespace GetFileApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test_file_path = $"C:\\Work\\testout.txt";

            string file_name = Path.GetFileName(test_file_path);
            string file_extname = Path.GetExtension(test_file_path);
            string file_dirname = Path.GetDirectoryName(test_file_path);

            Console.WriteLine($"파일 이름: {file_name}");
            Console.WriteLine($"파일 확장자: {file_extname}");
            Console.WriteLine($"파일 경로: {file_dirname}");
        }
    }
}
