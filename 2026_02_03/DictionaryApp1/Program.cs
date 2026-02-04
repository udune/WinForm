namespace DictionaryApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            phonebook.Add("Alice", "010-1234-5678");
            phonebook.Add("Bob", "010-2345-6789");

            Console.WriteLine($"총 인원수 : {phonebook.Count}");
            Console.WriteLine();
            foreach (var entry in phonebook)
            {
                Console.WriteLine($"이름: {entry.Key}, 전화번호: {entry.Value}");
            }

            foreach (string key in phonebook.Keys)
            {
                Console.WriteLine($"이름: {key}");
            }

            foreach (string value in phonebook.Values)
            {
                Console.WriteLine($"전화번호: {value}");
            }

            foreach (KeyValuePair<string, string> entry in phonebook)
            {
                Console.WriteLine($"이름: {entry.Key}, 전화번호: {entry.Value}");
            }
        }
    }
}
