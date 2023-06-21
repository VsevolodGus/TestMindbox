using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class RemoveDuplicatesSortedArrayTest
{
    private readonly RemoveDuplicatesSortedArray _worker = new();

    [Fact]
    public void FirstTest()
    {
        var nums = new int[] { 1,1,2};
        var result = _worker.RemoveDuplicates(nums);

        Assert.Equal(2, result);
    }

    [Fact]
    public void SecondTest()
    {
        var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        var result = _worker.RemoveDuplicates(nums);

        Assert.Equal(5, result);
    }
}
