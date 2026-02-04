using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }

        public abstract string GetInfo();
    }
}
