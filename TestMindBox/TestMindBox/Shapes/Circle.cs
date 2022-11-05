namespace TestMindBox.Shapes;

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius < 0)
            throw new ArgumentException("Задали неверно радиус");

        Radius = radius;
    }

    public double GetArea()
    {
        return Math.Pow(Radius, 2) * Math.PI;
    }

    public double GetPerimetr()
    {
        return 2 * Radius * Math.PI;
    }
}
