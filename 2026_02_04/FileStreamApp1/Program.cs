namespace FileStreamApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "output.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Hello, World!");
                writer.WriteLine("This is a test file.");
            }

            using (StreamWriter writer2 = new StreamWriter(path))
            {
                writer2.WriteLine("Appending a new line.");
            }

            using (StreamWriter writer3 = new StreamWriter(path, append: true))
            {
                writer3.WriteLine("Appending another line.");
            }
        }
    }
}
