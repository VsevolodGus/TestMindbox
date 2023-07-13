using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;

public class FindHighestAltitudeTest
{
    private readonly FindHighestAltitude _worker = new();
    
    [Fact]
    public void FirstTest()
    {
        var gain = new int[] { -5, 1, 5, 0, -7 };

        var result = _worker.LargestAltitude(gain);

        Assert.Equal(1, result);
    }

    [Fact]
    public void SecondTest()
    {
        var gain = new int[] { -4, -3, -2, -1, 4, 3, 2 };

        var result = _worker.LargestAltitude(gain);

        Assert.Equal(0, result);
    }
}
