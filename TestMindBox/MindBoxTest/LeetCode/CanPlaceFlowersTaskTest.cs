using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class CanPlaceFlowersTaskTest
{
    private readonly CanPlaceFlowersTask _worker = new();

    [Theory]
    [InlineData(new int[] { 1, 0, 0, 0, 1 }, 1)]
    [InlineData(new int[] { 1, 0, 0, 0, 0, 0, 1 }, 2)]
    public void CanViolating(int[] flowers, int n)
    {
        var result = _worker.CanPlaceFlowers(flowers, n);

        Assert.True(result);
    }


    [Theory]
    [InlineData(new int[] { 1, 0 }, 1)]
    [InlineData(new int[] { 1, 0, 0, 0, 1 }, 2)]
    [InlineData(new int[] { 1, 0, 0, 0, 0, 0, 1 }, 3)]
    public void CanNotViolating(int[] flowers, int n)
    {
        var result = _worker.CanPlaceFlowers(flowers, n);

        Assert.False(result);
    }
}
