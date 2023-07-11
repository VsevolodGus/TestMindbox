using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class DecodeStringTaskTest
{
    private readonly DecodeStringTask _worker = new();

    [Theory]
    [InlineData("asd","asd")]
    [InlineData("qwe", "qwe")]
    [InlineData("zxc","zxc")]
    public void SimpleTest(string input, string exceptedResult)
    {
        var result = _worker.DecodeString(input);

        Assert.Equal(exceptedResult, result);
    }

    [Theory]
    [InlineData("2[a]", "aa")]
    [InlineData("3[s]", "sss")]
    [InlineData("1[z]", "z")]
    public void WithRepeatElementsTest(string input, string exceptedResult)
    {
        var result = _worker.DecodeString(input);

        Assert.Equal(exceptedResult, result);
    }


    [Theory]
    [InlineData("2[a2[q]]", "aqqaqq")]
    [InlineData("3[s3[z]]", "szzzszzzszzz")]
    [InlineData("1[z1[q]", "zq")]
    public void WithNestedRepeats(string input, string exceptedResult)
    {
        var result = _worker.DecodeString(input);

        Assert.Equal(exceptedResult, result);
    }
}
