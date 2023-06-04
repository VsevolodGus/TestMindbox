using TestMindBox;
using TestMindBox.linq;

namespace MindBoxTest;

public class TestYarikTestLinq
{
    [Fact]
    public void Take_3_Result_From_1_To_3()
    {
        var array = new int[] { 1, 2, 3, 4 };

        var result = array.CustomTake(3);

        Assert.Equal(new int[] { 1, 2, 3 }, result.ToArray());
    }

    [Fact]
    public void Take_5_Result_From_1_To_5()
    {
        var array = new int[] { 1, 2, 3, 4, 5 };

        var result = array.MyTake(3);

        Assert.Equal(new int[] { 1, 2, 3 }, result.ToArray());
    }
}
