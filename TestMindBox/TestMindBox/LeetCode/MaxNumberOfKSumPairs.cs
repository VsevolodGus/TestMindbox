namespace TestMindBox.LeetCode;
public class MaxNumberOfKSumPairs
{
    public int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);
        var result = 0;

        int leftIndex = 0;
        int rightIndex = nums.Length - 1;

        while (leftIndex < rightIndex)
        {
            int sum = nums[leftIndex] + nums[rightIndex];

            if (sum == k)
            {
                result++;
                rightIndex--;
                leftIndex++;
            }
            else if(sum < k)
                leftIndex++;
            else
                rightIndex--;
        }


        return result;
    }
}
