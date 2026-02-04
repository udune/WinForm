using System;
using System.Collections.Generic;
using System.Text;

namespace PersonApp1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "이름없음";
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
