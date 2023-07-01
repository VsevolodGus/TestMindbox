using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class PalindromeNumberTaskTest
{
    private readonly PalindromeNumberTask _worker = new();

    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void Test(int x, bool result)
    {
        var actualResult = _worker.IsPalindrome(x);

        Assert.Equal(result, actualResult);
    }

}
