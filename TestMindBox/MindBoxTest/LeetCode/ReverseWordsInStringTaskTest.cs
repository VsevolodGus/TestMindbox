using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class ReverseWordsInStringTaskTest
{

    private readonly ReverseWordsInStringTask _worker = new();

    [Theory]
    [InlineData("the sky is blue", "blue is sky the")]
    [InlineData("  hello world  ", "world hello")]
    [InlineData("a good   example", "example good a")]
    public void Test(string input, string exeptedResult)
    {
        var result = _worker.ReverseWords(input);

        Assert.Equal(exeptedResult, result);
    }
}
