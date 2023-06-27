using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class MajorityElementTaskTest
{
    private readonly MajorityElementTask _worker = new();
    [Fact]
    public void FirstTest()
    {
        var nums = new int[] { 3, 2, 3 };

        var result = _worker.MajorityElement(nums);

        Assert.Equal(3, result);
    }

    [Fact]
    public void SecondTest()
    {
        var nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };

        var result = _worker.MajorityElement(nums);

        Assert.Equal(2, result);
    }
}
