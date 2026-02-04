namespace PersonApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("철수", 20);
            Person person2 = new Person("영희", 25);
            Console.WriteLine($"이름: {person1.Name}, 나이: {person1.Age}");
            Console.WriteLine($"이름: {person2.Name}, 나이: {person2.Age}");
        }
    }
}
