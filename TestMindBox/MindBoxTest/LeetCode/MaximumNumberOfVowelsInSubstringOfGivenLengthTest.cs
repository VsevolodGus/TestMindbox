using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class MaximumNumberOfVowelsInSubstringOfGivenLengthTest
{
    private readonly MaximumNumberOfVowelsInSubstringOfGivenLength _worker = new();

    [Theory]
    [InlineData("aeiou", 2)]
    public void IfFullVolwes(string s, int k)
    {
        var result = _worker.MaxVowels(s, k);

        Assert.Equal(2, result);
    }

    [Theory]
    [InlineData("qwrtpsdfghjklxcvbnm", 2)]
    public void IfFullNotVolwes(string s, int k)
    {
        var result = _worker.MaxVowels(s, k);

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("abciiidef", 3, 3)]
    [InlineData("leetcode", 3, 2)]
    [InlineData("weallloveyou", 7, 4)]
    [InlineData("rhythms", 0, 0)]
    [InlineData("tryhard", 4, 1)]
    public void MixString(string s, int k, int exceptedResult)
    {
        var result = _worker.MaxVowels(s, k);

        Assert.Equal(exceptedResult, result);
    }
}
