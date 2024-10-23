using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square1 = new Square(3, "green");
        Rectangle rectangle1 = new Rectangle(4,5, "red");
        Circle circle1 = new Circle(6, "yellow");

        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);
        
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine ($"The {color} shape has an area of {area}.");
        }
    }
}