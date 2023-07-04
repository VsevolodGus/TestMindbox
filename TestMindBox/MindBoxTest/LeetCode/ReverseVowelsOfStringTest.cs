using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class ReverseVowelsOfStringTest
{
    private readonly ReverseVowelsOfString _worker = new();


    [Theory]
    [InlineData("hello", "holle")]
    [InlineData("leetcode", "leotcede")]
    public void Test(string input, string excepted)
    {
        var result = _worker.ReverseVowels(input);

        Assert.Equal(excepted, result);
    }
}
