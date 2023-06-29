using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class FindIndexFirstOccurrenceInStringTest
{
    private readonly FindIndexFirstOccurrenceInString _worker = new();

    [Fact]
    public void HasNeedle()
    {
        const string haystack = "sadbutsad";
        const string needle = "sad";

        var result = _worker.StrStr(haystack, needle);
        
        Assert.Equal(0, result);
    }

    [Fact]
    public void NoHasNeedle()
    {
        const string haystack = "leetcode";
        const string needle = "leeto";

        var result = _worker.StrStr(haystack, needle);

        Assert.Equal(-1, result);
    }

    [Fact]
    public void HasOneSymbol()
    {
        const string haystack = "a";
        const string needle = "a";

        var result = _worker.StrStr(haystack, needle);

        Assert.Equal(0, result);
    }
}
