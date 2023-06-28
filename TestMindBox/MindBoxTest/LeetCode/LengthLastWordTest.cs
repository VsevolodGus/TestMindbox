using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class LengthLastWordTest
{
    private readonly LengthLastWordTask _worker = new();

    [Fact]
    public void SimpleTest()
    {
        const string s = "Hello World";

        var result = _worker.LengthOfLastWord(s);

        Assert.Equal(5, result);
    }

    [Fact]
    public void WithSeveralWordsTest()
    {
        const string s = "luffy is still joyboy";

        var result = _worker.LengthOfLastWord(s);

        Assert.Equal(6, result);
    }

    [Fact]
    public void WithSpaceInEndTest()
    {
        const string s = "   fly me   to   the moon  ";

        var result = _worker.LengthOfLastWord(s);

        Assert.Equal(4, result);
    }

}
