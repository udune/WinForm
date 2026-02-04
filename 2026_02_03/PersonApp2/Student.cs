using System;
using System.Collections.Generic;
using System.Text;

namespace PersonApp2
{
    internal class Student : Person
    {
        public string School;

        public Student()
        {
            School = "무명고등학교";
        }

        public Student(string name, string school) : base(name)
        {
            School = school;
        }

        public void Study()
        {
            Console.WriteLine($"{School}에서 공부합니다.");
        }

        public void Introduce()
        {
            base.Greet();
            Console.WriteLine($"저는 {Name}이고, {School}에 다니고 있습니다.");
        }

        public override void SayHello()
        {
            Console.WriteLine($"안녕하세요. 저는 {School}에 다니는 {Name}입니다.");
        }
    }
}
