namespace TestMindBox.LeetCode;
public class FindPivotIndex
{

    public int PivotIndex(int[] nums)
    {
        var leftSum = 0;
        var rightSum = nums.Sum() - nums.FirstOrDefault();

        if(leftSum == rightSum) 
            return 0;
        
        for(int i = 1; i < nums.Length; i++) 
        {
            leftSum += nums[i - 1];
            rightSum -= nums[i];

            if(leftSum == rightSum)
                return i;
        }

        return -1;
    }
}
