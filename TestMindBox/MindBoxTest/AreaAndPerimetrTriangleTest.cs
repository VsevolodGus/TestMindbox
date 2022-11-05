using TestMindBox;
using TestMindBox.Shapes;

namespace MindBoxTest;

public class AreaAndPerimetrTriangleTest
{
    [Fact]
    public void Triangle1()
    {
        var triangle = new Triangle(3, 4, 5);

        var result = WorkShapes.GetPerimetrAndAreaOfShape(triangle);

        Assert.Equal(6, result.Area);
        Assert.Equal(12, result.Perimetr);
    }


    [Fact]
    public void Triangle2()
    {
        var triangle = new Triangle(6, 8, 10);

        var result = WorkShapes.GetPerimetrAndAreaOfShape(triangle);

        Assert.Equal(24, result.Area);
        Assert.Equal(24, result.Perimetr);
    }

    [Fact]
    public void Triangle3()
    {
        var triangle = new Triangle(6, 7, 9);

        var result = WorkShapes.GetPerimetrAndAreaOfShape(triangle);

        Assert.Equal(Math.Sqrt(11* (11-6) * (11-7) * (11-9)), result.Area);
        Assert.Equal(22, result.Perimetr);
    }

    [Fact]
    public void Triangle_NotExistsTriangle_ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }


    [Fact]
    public void Triangle_SideValueZero_ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0));
    }

    [Fact]
    public void Triangle_WithNegativeSide_ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(10, 6, -8));
    }


}