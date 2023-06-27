namespace TestMindBox.LeetCode;
public class BestTimeToBuyAndSellStock
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock/?envType=study-plan-v2&envId=top-interview-150
    public int MaxProfit(int[] prices)
    {
        if(prices.Length <= 1)
            return 0;

        var max = 0;
        var min = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (min > prices[i])
                min = prices[i];
            else if(prices[i] - min > max)
                max = prices[i] - min;
        }

        return max;
    }

    //TODO
    // https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/?envType=study-plan-v2&envId=top-interview-150
}
