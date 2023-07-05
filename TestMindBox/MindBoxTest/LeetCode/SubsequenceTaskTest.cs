using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class SubsequenceTaskTest
{
    private readonly SubsequenceTask _worker = new();

    [Fact]
    public void IsSubsequence()
    {
        const string s = "abc";
        const string t = "ahbgdc";

        var result = _worker.IsSubsequence(s, t);
        
        Assert.True(result);
    }

    [Fact]
    public void IsNotSubsequence()
    {
        const string s = "axc";
        const string t = "ahbgdc";

        var result = _worker.IsSubsequence(s, t);

        Assert.False(result);
    }

    [Fact]
    public void S_IsEmpty()
    {
        const string s = "";
        const string t = "ahbgdc";

        var result = _worker.IsSubsequence(s, t);

        Assert.True(result);
    }


    [Fact]
    public void IfSEndInMiddeleT()
    {
        const string s = "b";
        const string t = "abc";

        var result = _worker.IsSubsequence(s, t);

        Assert.True(result);
    }
}
