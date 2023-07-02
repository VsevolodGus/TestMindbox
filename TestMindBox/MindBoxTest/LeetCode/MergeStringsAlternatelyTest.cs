using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class MergeStringsAlternatelyTest
{
    private readonly MergeStringsAlternately _worker = new();


    [Fact]
    public void LenghtWordsEqueal()
    {
        var result = _worker.MergeAlternately("abc", "pqr");

        Assert.Equal("apbqcr", result);
    }

    [Fact]
    public void SecondMoreLenght()
    {
        var result = _worker.MergeAlternately("ab", "pqrs");

        Assert.Equal("apbqrs", result);
    }

    [Fact]
    public void FirstMoreLenght()
    {
        var result = _worker.MergeAlternately("abcd", "pq");

        Assert.Equal("apbqcd", result);
    }
}
