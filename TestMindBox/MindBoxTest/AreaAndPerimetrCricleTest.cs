using TestMindBox.Shapes;
using TestMindBox;

namespace MindBoxTest;

public class AreaAndPerimetrCricleTest
{
    private double GetPerimetr(double radius) => 2 * radius * Math.PI;
    private double GetArea(double radius) => Math.Pow(radius, 2) * Math.PI;
    [Fact]
    public void Circle_Radius3()
    {
        var radius = 3;

        var result = WorkShapes.GetPerimetrAndAreaOfShape(new Circle(radius));

        Assert.Equal(GetArea(radius), result.Area);
        Assert.Equal(GetPerimetr(radius), result.Perimetr);
    }


    [Fact]
    public void Circle_Radius4()
    {
        var radius = 4;

        var result = WorkShapes.GetPerimetrAndAreaOfShape(new Circle(radius));

        Assert.Equal(GetArea(radius), result.Area);
        Assert.Equal(GetPerimetr(radius), result.Perimetr);
    }

    [Fact]
    public void Circle_Radius5()
    {
        var radius = 5;

        var result = WorkShapes.GetPerimetrAndAreaOfShape(new Circle(radius));

        Assert.Equal(GetArea(radius), result.Area);
        Assert.Equal(GetPerimetr(radius), result.Perimetr);
    }

    [Fact]
    public void Cicrle_NegativeRadius_ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
}
