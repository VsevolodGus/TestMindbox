using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;


public class ContainerWithMostWaterTest
{
    private readonly ContainerWithMostWater _worker = new();

    [Theory]
    [InlineData(new int[] { 1,1 }, 1)]
    [InlineData(new int[] { 1,2 }, 1)]
    [InlineData(new int[] { 3,2 }, 2)]
    public void SimpleTest(int[] heights, int exceptedResult)
    {
        var result = _worker.MaxArea(heights);

        Assert.Equal(exceptedResult, result);
    }


    [Theory]
    [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    public void Test(int[] heights, int exceptedResult)
    {
        var result = _worker.MaxArea(heights);

        Assert.Equal(exceptedResult, result);
    }
}
