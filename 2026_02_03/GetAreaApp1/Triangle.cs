using System;
using System.Collections.Generic;
using System.Text;

namespace GetAreaApp1
{
    internal class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle(double triangleBase, double height)
        {
            Base = triangleBase;
            Height = height;
        }
        public override double GetArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
