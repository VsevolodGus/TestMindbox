namespace TestMindBox.LeetCode;
/// <summary>
/// https://leetcode.com/problems/move-zeroes/description/
/// </summary>
public class MoveZeroesTask
{
    /// <summary>
    /// Решение нужно прописывать руками чтобы понять
    /// </summary>
    /// <param name="nums"></param>
    public void MoveZeroes(int[] nums)
    {
        var firstPosZero = 0;

        for(int i = 0; i< nums.Length; i++) 
        {
            if (nums[i] == 0)
                continue;

            (nums[i], nums[firstPosZero]) = (nums[firstPosZero], nums[i]);
            firstPosZero++;
        }
    }
}
