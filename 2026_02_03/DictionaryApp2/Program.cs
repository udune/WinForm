namespace DictionaryApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> candyBasket = new Dictionary<string, int>()
            {
                { "Snickers", 5 },
                { "Twix", 3 },
                { "M&Ms", 10 }
            };

            candyBasket.Add("KitKat", 7);

            candyBasket["Twix"] += 4;

            foreach (var candy in candyBasket)
            {
                Console.WriteLine($"{candy.Key}: {candy.Value}");
            }
        }
    }
}
