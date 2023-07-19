namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/single-number/description/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class SingleNumberTask
{
    public int SingleNumber(int[] nums)
    {
        var result = 0;
        foreach (var x in nums) 
        {
            result ^= x;
        }

        return result;
    }
}

