
public class Square : Shape
{
    double _side;

    public Square(double side, string shapeColor) : base(shapeColor)
    {
        _side = side;
    }
    public override double GetArea()
    {
        double area = _side*_side;
        return area;
    }
}