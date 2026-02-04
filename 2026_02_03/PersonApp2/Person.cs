using System;
using System.Collections.Generic;
using System.Text;

namespace PersonApp2
{
    internal class Person
    {
        public string Name;

        public Person()
        {
            Name = "이름없음";
        }

        public Person(string name)
        {
            Name = name;
        }

        public virtual void SayHello()
        {
            Console.WriteLine($"안녕하세요. 저는 {Name}입니다.");
        }

        public void Greet()
        {
            Console.WriteLine("반갑습니다!");
        }
    }
}
