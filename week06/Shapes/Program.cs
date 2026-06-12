using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test individual objects
        Square square = new Square("Red", 5);
        Console.WriteLine($"Color: {square.GetColor()}");
        Console.WriteLine($"Area: {square.GetArea()}");

        Console.WriteLine();

        // Create a list of shapes
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Blue", 4));
        shapes.Add(new Rectangle("Green", 6, 3));
        shapes.Add(new Circle("Yellow", 2.5));

        // Demonstrate polymorphism
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():F2}");
            Console.WriteLine();
        }
    }
}