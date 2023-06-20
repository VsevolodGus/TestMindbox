namespace TestMindBox.Shapes;

public class WorkShapes
{
    public static DataShape GetPerimetrAndAreaOfShape(IShape shape)
    {
        return new DataShape()
        {
            Area = shape.GetArea(),
            Perimetr = shape.GetPerimetr(),
        };
    }
}