using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 4),
            new Rectangle("Blue", 5, 3),
            new Circle("Green", 2.5)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetType().Name}, Color: {shape.Color}, Area: {shape.GetArea():F2}");
        }
    }
}