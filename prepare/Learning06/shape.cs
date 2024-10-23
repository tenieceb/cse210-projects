public abstract class Shape
{
    string _color;
    public Shape (string shapeColor)
    {
        _color = shapeColor;
    }
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string shapeColor)
    {
        _color = shapeColor;
    }

    public abstract double GetArea();
  
}