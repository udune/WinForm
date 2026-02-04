namespace PersonApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];
            people[0] = new Person { Name = "Alice" };
            people[1] = new Teacher { Name = "Bob", Subject = "수학" };
            people[2] = new Student { Name = "Charlie", School = "무명고등학교" };

            foreach (var person in people)
            {
                person.SayHello();
                person.Introduce();

                Console.WriteLine();
            }

        }
    }
}
