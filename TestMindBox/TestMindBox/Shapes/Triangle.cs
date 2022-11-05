namespace TestMindBox.Shapes;

public class Triangle : IShape
{
    public double A { get; init; }
    public double B { get; init; }
    public double C { get; init; }

    private double _p => A + B + C;

    public double GetArea()
    {
        var p = _p / 2;

        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public double GetPerimetr()
    {
        return _p;
    }
}
