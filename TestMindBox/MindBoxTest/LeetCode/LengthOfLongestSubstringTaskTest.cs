using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class LengthOfLongestSubstringTaskTest
{
    private readonly LengthOfLongestSubstringTask worker = new();
    
    [Fact]
    public void FirstSymbols()
    {
        const string s = "abcabcbb";
        var result = worker.LengthOfLongestSubstring(s);
        Assert.Equal(3, result);
    }

    [Fact]
    public void StringOfOneSymbols()
    {
        const string s = "bbbbb";
        var result = worker.LengthOfLongestSubstring(s);
        Assert.Equal(1, result);
    }

    [Fact]
    public void InMiddle()
    {
        const string s = "pwwkew";
        var result = worker.LengthOfLongestSubstring(s);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Last()
    {
        const string s = "dvdf";
        var result = worker.LengthOfLongestSubstring(s);
        Assert.Equal(3, result);
    }

    [Fact]
    public void RepeatSymbolInMiddleLastString()
    {
        const string s = "wpwkew";
        var result = worker.LengthOfLongestSubstring(s);
        Assert.Equal(4, result);
    }
}
