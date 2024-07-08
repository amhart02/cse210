using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square(1.4, "red");
        shapes.Add(square); 

        Rectangle rectangle = new Rectangle(4, 6, "yellow");
        shapes.Add(rectangle);

        Circle circle = new Circle(4, "blue");
        shapes.Add(circle);
    
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Color: {color}, Area: {area}");
        }
    }
}