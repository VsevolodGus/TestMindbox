using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class FindPivotIndexTest
{
    private readonly FindPivotIndex _worker = new();

    [Theory]
    [InlineData(new int[] { 1, 5, 1 }, 1)]
    [InlineData(new int[] { 1, 7, 3, 6, 5, 6 }, 3)]
    [InlineData(new int[] { 1, 7, 3, 2, 5, 1 }, 2)]
    public void HasIndexInMiddle(int[] nums, int exceptedResult)
    {
        var result = _worker.PivotIndex(nums);

        Assert.Equal(exceptedResult, result);
    }

    [Theory]
    [InlineData(new int[] { 6, 8 ,4})]
    [InlineData(new int[] { 1, 2, 3 })]
    public void HasNotPivotIndex(int[] nums)
    {
        var result = _worker.PivotIndex(nums);

        Assert.Equal(-1, result);
    }

    [Theory]
    [InlineData(new int[] { 2, 1, -1 })]
    [InlineData(new int[] { 5, -2, 2 })]
    public void HasPivotIndexOnBeginEdge(int[] nums)
    {
        var result = _worker.PivotIndex(nums);

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(new int[] { -1, 1, 2 })]
    [InlineData(new int[] { 2, -2, 5 })]
    public void HasPivotIndexOnEndEdge(int[] nums)
    {
        var result = _worker.PivotIndex(nums);

        Assert.Equal(nums.Length - 1, result);
    }
}
