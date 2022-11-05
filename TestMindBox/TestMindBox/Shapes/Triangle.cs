namespace TestMindBox.Shapes;

public class Triangle : IShape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    public Triangle(double a, double b, double c)
    {
        if (a + b < c || a + c < b || c + b < a)
            throw new ArgumentException("Стороны треугольника заданы неверно");

        A = a;
        B = b;
        C = c;
    }

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

    public bool IsRectangular()
    {
        var aSquare = Math.Pow(A, 2);
        var bSquare = Math.Pow(B, 2);
        var cSquare = Math.Pow(C, 2);

        return aSquare == bSquare + cSquare
                || bSquare == aSquare + cSquare
                || cSquare == bSquare + aSquare;
    }
}
