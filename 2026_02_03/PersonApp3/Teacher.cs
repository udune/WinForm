using System;
using System.Collections.Generic;
using System.Text;

namespace PersonApp3
{
    internal class Teacher : Person
    {
        public string Subject;

        public Teacher()
        {
            Subject = "미정";
        }

        public Teacher(string name, string subject) : base(name)
        {
            Subject = subject;
        }

        public void Teach()
        {
            Console.WriteLine($"{Subject}을(를) 가르칩니다.");
        }

        public override void SayHello()
        {
            base.SayHello();
        }

        public override void Introduce()
        {
            base.Greet();
            Console.WriteLine($"저는 {Subject}을(를) 가르치는 선생님입니다.");
        }

        public override string ToString()
        {
            return $"Teacher: Subject = {Subject}";
        }
    }
}
