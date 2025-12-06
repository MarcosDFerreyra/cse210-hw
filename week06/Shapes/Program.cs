using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> _shape = new List<Shapes>();

        Square square = new Square("red", 5);
        _shape.Add(square);

        Rectangle rectangle = new Rectangle("orange", 3, 5);
        _shape.Add(rectangle);
       
        Circle circle = new Circle("blue", 7);
        _shape.Add(circle);

        foreach (Shapes Shape in _shape)
        {
            Console.WriteLine($" the color {Shape.GetColor()} shape has an area of {Shape.GetArea()}");

        }


    }
}
