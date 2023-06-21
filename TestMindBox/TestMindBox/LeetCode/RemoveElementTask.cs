namespace TestMindBox.LeetCode;
public class RemoveElementTask
{
    public int RemoveElement(int[] nums, int val)
    {
        var currrent = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
                continue;

            nums[currrent] = nums[i];
            currrent++;
        }

       return currrent;

        //    var result = nums.OrderBy(c=> c == val).ToArray();
        //    Array.Copy(result, nums, result.Length);
        //    return nums.Count(c=> c != val);
    }
}
