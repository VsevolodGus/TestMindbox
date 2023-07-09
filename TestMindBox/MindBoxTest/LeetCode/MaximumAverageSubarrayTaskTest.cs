using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public sealed class MaximumAverageSubarrayTaskTest
{
    private readonly MaximumAverageSubarrayTask _worker = new();

    [Theory]
    [InlineData(new int[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75000)]
    [InlineData(new int[] { 5 }, 1, 5.00000)]
    [InlineData(new int[] { 0, 1, 1, 3, 3 }, 4, 2.00000)]
    public void FirstTest(int[] nums, int k, double exceptedResult)
    {
        var result = _worker.FindMaxAverage(nums, k);

        Assert.Equal(exceptedResult, result);
    }
}
