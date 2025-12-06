
public class Rectangle: Shapes
{
    private double _length;
    private double _width;



    public Rectangle(string color, double length, double witdh) : base(color)
    {
        _length = length;
        _width = witdh;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}