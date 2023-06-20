using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class TwoSumTaskTest
{
    [Fact]
    public void FirstTestWithNumberBiggerTarget()
    {
        var nums = new int[] { 2, 7, 11, 15 };
        const int target = 9;
        var result = TwoSumTask.TwoSum(nums, target);
        Assert.Equal(new int[] {0, 1}, result);
    }

    [Fact]
    public void SecondTest()
    {
        var nums = new int[] { 3,2,4 };
        const int target = 6;
        var result = TwoSumTask.TwoSum(nums, target);
        Assert.Equal(new int[] { 1, 2 }, result);
    }

    [Fact]
    public void ThirdTest()
    {
        var nums = new int[] { 3, 3 };
        const int target = 6;
        var result = TwoSumTask.TwoSum(nums, target);
        Assert.Equal(new int[] { 0, 1 }, result);
    }


    [Fact]
    public void TestWith_NumsHasSeveralZero_TargeetIsZero()
    {
        var nums = new int[] { 0,4,3,0 };
        const int target = 0;
        var result = TwoSumTask.TwoSum(nums, target);
        Assert.Equal(new int[] { 0, 3 }, result);
    }
}
