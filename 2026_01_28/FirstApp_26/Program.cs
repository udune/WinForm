namespace FirstApp_26
{
    internal class Program
    {
        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int Score { get; set; }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Name = "홍길동", Age = 20, Score = 85 },
                new Student() { Name = "김철수", Age = 22, Score = 90 },
                new Student() { Name = "이영희", Age = 19, Score = 95 }
            };

            var pass = from student in students
                       where student.Score >= 90
                       orderby student.Age
                       descending select student.Name;

            var pass2 = students
                        .Where(student => student.Score >= 90)
                        .OrderBy(student => student.Age)
                        .Select(student => student.Name);

            foreach (var name in pass)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            foreach (var name in pass2)
            {
                Console.WriteLine(name);
            }
        }
    }
}
