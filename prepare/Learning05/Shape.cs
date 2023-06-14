using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning05
{
    public abstract class Shape
    {
        private string _color;

        public Shape(string color) => _color = color;
        
        public string GetColor() => _color;
        public void SetColor(string color) => _color = color;
        public abstract double GetArea();
    }
}