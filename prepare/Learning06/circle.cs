
public class Circle : Shape
{
    double _radius;

    public Circle(double radius, string shapeColor) : base (shapeColor)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = _radius * _radius * Math.PI;
        return area;

    }

}
