using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class RotateArrayTaskTest
{
    private readonly RotateArrayTask _worker = new();


    [Fact]
    public void FirstTask()
    {
        var nums = new[] { 1, 2, 3, 4, 5, 6, 7 };
        const int k = 3;

        _worker.Rotate(nums, k);

        Assert.Equal(new int[] { 5, 6, 7, 1, 2, 3, 4 }, nums);
    }

    [Fact]
    public void SecondTask()
    {
        var nums = new[] { -1, -100, 3, 99 };
        const int k = 2;

        _worker.Rotate(nums, k);

        Assert.Equal(new int[] { 3, 99, -1, -100 }, nums);
    }
}
