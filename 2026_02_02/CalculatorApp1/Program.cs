namespace CalculatorApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate cc = new Calculate();

            int add = cc.Add(10, 5);
            int sub = cc.Subtract(10, 5);
            int mul = cc.Multiply(10, 5);
            int div = cc.Divide(10, 3, out int rem);

            Console.WriteLine($"Addition: {add}");
            Console.WriteLine($"Subtraction: {sub}");
            Console.WriteLine($"Multiplication: {mul}");
            Console.WriteLine($"Division: {div}, Remainder: {rem}");
        }
    }
}
