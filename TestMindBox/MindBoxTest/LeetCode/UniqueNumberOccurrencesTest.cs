using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class UniqueNumberOccurrencesTest
{
    private readonly UniqueNumberOccurrences _worker = new();
    
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 1, 1, 3 })]
    [InlineData(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 })]
    public void True(int[] arr)
    {
        var result = _worker.UniqueOccurrences(arr);

        Assert.True(result);
    }

    [Theory]
    [InlineData(new int[] { 1, 2 })]
    public void False(int[] arr)
    {
        var result = _worker.UniqueOccurrences(arr);

        Assert.False(result);
    }
}
