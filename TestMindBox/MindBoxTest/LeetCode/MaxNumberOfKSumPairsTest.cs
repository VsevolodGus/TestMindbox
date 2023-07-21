using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class MaxNumberOfKSumPairsTest
{
    private readonly MaxNumberOfKSumPairs _worker = new();

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, 5, 2)]
    [InlineData(new int[] { 3, 1, 3, 4, 3 }, 6, 1)]
    public void Test(int[] nums, int k, int exceptedResult)
    {
        var result = _worker.MaxOperations(nums, k);

        Assert.Equal(exceptedResult, result);
    }
}
