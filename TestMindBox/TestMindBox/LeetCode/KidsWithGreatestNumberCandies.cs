namespace TestMindBox.LeetCode;

public class KidsWithGreatestNumberCandies
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var result = new bool[candies.Length];

        for(int i = 0; i< candies.Length; i++) 
        {
            candies[i] += extraCandies;

            var max = candies.Max();
            result[i] = candies[i] == max;

            candies[i] -= extraCandies;
        }

        return result;
    }
}
