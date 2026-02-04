using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp1
{
    public class Calculate
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b, out int remainder)
        {
            remainder = a % b;
            return a / b;
        }
    }
}
