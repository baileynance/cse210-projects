using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 3.6));
        shapes.Add(new Rectangle("blue", 7.4, 4.1));
        shapes.Add(new Circle("yellow", 5.3));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();
        }
    }
}