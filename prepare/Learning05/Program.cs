using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 4);
        
        Rectangle rectangle = new Rectangle("green", 4, 3);

        Circle circle = new Circle("red", 10);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes){
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"the {color} shape has an area of {area}.");
        }
    }
}