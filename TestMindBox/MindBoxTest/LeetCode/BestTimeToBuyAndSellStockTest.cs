using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class BestTimeToBuyAndSellStockTest
{
    private readonly BestTimeToBuyAndSellStock _worker = new();

    [Fact]
    public void FirstTask()
    {
        var prices= new int[] { 7, 1, 5, 3, 6, 4 };

        var result = _worker.MaxProfit(prices);

        Assert.Equal(5, result);
    }


    [Fact]
    public void SecondTask()
    {
        var prices = new int[] { 7, 6, 4, 3, 1 };

        var result = _worker.MaxProfit(prices);

        Assert.Equal(0, result);
    }

    [Fact]
    public void ThirdTask()
    {
        var prices = new int[] { 1, 2 };

        var result = _worker.MaxProfit(prices);

        Assert.Equal(1, result);
    }
}
