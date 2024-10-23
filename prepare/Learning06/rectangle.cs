
public class Rectangle : Shape
{
    double _length;
    double _width;

    public Rectangle (double length, double width, string shapeColor): base(shapeColor)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        double area = _length * _width;
        return area;

    }
}