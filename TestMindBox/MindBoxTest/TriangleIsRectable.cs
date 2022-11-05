using TestMindBox.Shapes;

namespace MindBoxTest;

public class TriangleIsRectable
{
    [Fact]
    public void Triangle1()
    {
        var triangle = new Triangle(3, 4, 5);

        Assert.True(triangle.IsRectangular());
    }


    [Fact]
    public void Triangle2()
    {
        var triangle = new Triangle(6, 8, 10);

        Assert.True(triangle.IsRectangular());
    }

    [Fact]
    public void Triangle3()
    {
        var triangle = new Triangle(6, 7, 9);

        Assert.False(triangle.IsRectangular());
    }
}
