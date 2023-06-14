using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning05
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(string color, double radius) : base(color) =>_radius = radius;

        public override double GetArea() => _radius * _radius * 3.1416;
    }
}