using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class RemovingStarsFromStringTest
{
    private readonly RemovingStarsFromString _worker = new();
    [Fact]
    public void FirstNormalTes()
    {
        const string input = "leet**cod*e";
        var result = _worker.RemoveStars(input);

        Assert.Equal("lecoe", result);
    }


    [Fact]
    public void StarsInRow()
    {
        const string input = "erase*****";
        var result = _worker.RemoveStars(input);

        Assert.Equal("", result);
    }
}
