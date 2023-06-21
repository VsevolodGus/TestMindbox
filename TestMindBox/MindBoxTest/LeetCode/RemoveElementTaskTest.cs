using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;

public class RemoveElementTaskTest
{
    private readonly RemoveElementTask _worker = new();
    
    [Fact]
    public void FirstTest()
    {
        var nums = new int[] { 3,2,2,3};
        const int val = 3;
        var result =  _worker.RemoveElement(nums, val);
        Assert.Equal(2, result);
    }
       
}
