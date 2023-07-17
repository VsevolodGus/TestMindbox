using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class GreatestCommonDivisorOfStringsTest
{
    private readonly GreatestCommonDivisorOfStrings _worker = new();

    [Theory]
    [InlineData("LEET", "CODE")]
    [InlineData("123", "321")]
    [InlineData("ABCDEF", "ABC")]
    [InlineData("ASDFGHJK", "ZXCVBNMQWERTYU")]
    public void WithEmptyResult(string str1, string str2)
    {
        var result = _worker.GcdOfStrings(str1, str2);

        Assert.Equal(string.Empty, result);
    }

    [Theory]
    [InlineData("ABCABC", "ABC", "ABC")]
    [InlineData("ABABAB", "ABAB", "AB")]
    [InlineData("QWEQWEQWE", "QWEQWE", "QWE")]
    public void HasCommonDivision(string str1, string str2, string exepcedResult)
    {
        var result = _worker.GcdOfStrings(str1, str2);

        Assert.Equal(exepcedResult, result);
    }
}
