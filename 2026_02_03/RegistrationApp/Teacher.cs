using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp
{
    internal class Teacher : Person
    {
        public override string GetInfo()
        {
            return $"이름: {Name}, 나이: {Age}, 전공: {Major}";
        }
    }
}
