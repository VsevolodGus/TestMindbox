using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class KthLargestElementInArrayTest
{
    private readonly KthLargestElementInArray _worker = new();

    [Theory]
    [InlineData(new int[] { 3, 2, 1, 5, 6, 4 }, 2, 5)]
    [InlineData(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4, 4)]
    public void Test(int[] nums,int k, int exepcedResult)
    {
        var result = _worker.FindKthLargest(nums, k);

        Assert.Equal(exepcedResult, result);
    }

}
