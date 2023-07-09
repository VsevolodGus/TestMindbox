namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/increasing-triplet-subsequence/description/
/// </summary>
public class IncreasingTripletSubsequence
{
    public bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length < 3)
            return false;

        int firstSmallestValue = int.MaxValue;
        int secondSmallestValue = int.MaxValue;

        for (int i = 0; i < nums.Length; i++) 
        {
            if (nums[i] <= firstSmallestValue)
                firstSmallestValue = nums[i];
            else if (nums[i] <= secondSmallestValue)
                secondSmallestValue = nums[i];
            else
                return true;
        }

        return false;
    }
}
