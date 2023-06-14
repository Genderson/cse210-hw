using System;
using Learning05;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add( new Square("Blue", 5));
        shapes.Add( new Rectangle("Green", 7, 8));
        shapes.Add( new Circle("Purple", 4));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} - Area {shape.GetArea()}");
        }
    }
}