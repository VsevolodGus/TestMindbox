namespace TestMindBox.LeetCode;

public class KidsWithGreatestNumberCandies
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var result = new bool[candies.Length];

        var max = candies.Max();

        for(int i = 0; i< candies.Length; i++)
            result[i] = candies[i] + extraCandies >= max;

        return result;
    }
}
