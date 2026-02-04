namespace PersonApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("홍길동");
            person.Name = "임꺽정";
            person.SayHello();

            Console.WriteLine();

            Student student = new Student("이몽룡", "서울고등학교");
            student.Name = "성춘향";
            student.School = "부산고등학교";

            Console.WriteLine();

            student.SayHello();
            student.Study();
            student.Introduce();

            Console.WriteLine();

            Student student2 = new Student("장보고", "목포고등학교");
            student2.SayHello();

            Console.WriteLine();

            Person person2 = new Student("강감찬", "개성고등학교");
            person2.SayHello();
        }
    }
}
