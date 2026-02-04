namespace ClassConsoleApp
{
    public class Person
    {
        public string Name { get; set; }
        private int age;
        public int Age {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            } 
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"안녕 내 이름은 {Name}이고 나는 {Age}살이야.");
        }

        public int Add(int age, int addAge = 0)
        {
            this.age = age;
            this.age += addAge;
            return this.age;
        }

        public int Div(int age, int divNum, out int retOut)
        {
            int retResult = age / divNum;
            retOut = age % divNum;

            return retResult;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("철수", 20);
            person.Name = "민수";
            person.Age = 21;
            int retAge = person.Add(21, 5);
            int retOut;
            int retAge2 = person.Div(26, 4, out retOut);
            Console.WriteLine($"나이를 새로 입력한 값은 {retAge}");
            Console.WriteLine($"나이를 나눈 값은 {retAge2}이고, 나머지는 {retOut}이야.");
            person.Introduce();

            Person person2 = new Person("영희", 18);
            person2.Name = "수지";
            person2.Age = 19;
            person2.Introduce();
        }
    }
}
