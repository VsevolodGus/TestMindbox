namespace TestMindBox.LeetCode;
/// <summary>
/// https://leetcode.com/problems/maximum-average-subarray-i/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class MaximumAverageSubarrayTask
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double result = double.MinValue;
        double sumKElements = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sumKElements += nums[i];

            if (i < k - 1)
                continue;

            var avgValue = sumKElements / k;
            if (avgValue > result)
                result = avgValue;

            sumKElements -= nums[i + 1 -k];
        }

        return result;
    }
}
