using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class ProductOfArrayExceptSelfTest
{
    private readonly ProductOfArrayExceptSelf _worker = new();

    [Theory]
    [InlineData(new int[] { 1, 0, 0, 1 })]
    [InlineData(new int[] { 1, 0, 1, 1, 22, 345, 0 })]
    [InlineData(new int[] { 1, 0, 1, 0, 22, 345, 0 })]
    public void IfContainsMoreTwoZero(int[] nums)
    {
        var result = _worker.ProductExceptSelf(nums);

        Assert.Equal(Enumerable.Repeat(0, nums.Length), result);
    }

    [Theory]
    [InlineData(new int[] { 1, 0, 3, 4 }, new int[] { 0, 12, 0, 0 })]
    [InlineData(new int[] { 1, 2, 3, 0 }, new int[] { 0, 0, 0, 6 })]
    public void HasOneZero(int[] nums, int[] exceptedResult)
    {
        var result = _worker.ProductExceptSelf(nums);

        Assert.Equal(exceptedResult, result);
    }


    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
    public void HasNotZero(int[] nums, int[] exceptedResult)
    {
        var result = _worker.ProductExceptSelf(nums);

        Assert.Equal(exceptedResult, result);
    }
}
