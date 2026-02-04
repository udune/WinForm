using System;
using System.Collections.Generic;
using System.Text;

namespace GetAreaApp1
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
