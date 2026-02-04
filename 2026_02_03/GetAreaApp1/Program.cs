namespace GetAreaApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);
            Shape triangle = new Triangle(3, 4);

            Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");
            Console.WriteLine($"Triangle Area: {triangle.GetArea():F2}");
        }
    }
}
