namespace TestMindBox.Shapes;

public class Circle : IShape
{
    public double Radius { get; init; }

    public double GetArea()
    {
        return Math.Pow(Radius, 2) * Math.PI;
    }

    public double GetPerimetr()
    {
        return 2 * Radius * Math.PI;
    }
}
