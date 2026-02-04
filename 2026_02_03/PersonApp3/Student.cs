using System;
using System.Collections.Generic;
using System.Text;

namespace PersonApp3
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

        public override void Introduce()
        {
            base.Greet();
            Console.WriteLine($"저는 {School}에 다니는 학생입니다.");
        }

        public override void SayHello()
        {
            base.SayHello();
        }

        public override string ToString()
        {
            return $"Student: School = {School}";
        }
    }
}
