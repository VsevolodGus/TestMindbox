using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class TribonacciNumberTest
{
    private readonly TribonacciNumber _worker = new();

    /// <summary>
    /// n > 2
    /// </summary>
    /// <param name="n"></param>
    /// <param name="exceptedResult"></param>
    [Theory]
    [InlineData(3, 2)]
    [InlineData(4, 4)]
    [InlineData(7, 24)]
    [InlineData(25, 1389537)]
    public void NMore2(int n, int exceptedResult)
    {
        var result = _worker.Tribonacci(n);

        Assert.Equal(exceptedResult, result);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void N1Or2(int n)
    {
        var result = _worker.Tribonacci(n);

        Assert.Equal(1, result);
    }

    [Theory]
    [InlineData(0)]
    public void NZero(int n)
    {
        var result = _worker.Tribonacci(n);

        Assert.Equal(0, result);
    }
}
