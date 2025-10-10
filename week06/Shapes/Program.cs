using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square("blue", 3.2);
        Rectangle r = new Rectangle("red", 22.3, 33.2);
        Circle c = new Circle("purple", 3);

        // Console.WriteLine($"color {s.GetColor()} area of square {s.GetArea()}");
        // Console.WriteLine($"color {r.GetColor()} area of rectangle {r.GetArea()}");
        // Console.WriteLine($"color {c.GetColor()} area of circle {c.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"color: {shape.GetColor()} area of shape: {shape.GetArea()}");
        }
    }
}