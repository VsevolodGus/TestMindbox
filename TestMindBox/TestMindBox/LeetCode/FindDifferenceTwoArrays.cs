namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/find-the-difference-of-two-arrays/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class FindDifferenceTwoArrays
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        HashSet<int> numsFirst = new HashSet<int>(nums1);
        HashSet<int> numsSecond = new HashSet<int>(nums2);

        return new int[][]
        { 
            numsFirst.Where(c => !numsSecond.Contains(c)).ToArray(),
            numsSecond.Where(c => !numsFirst.Contains(c)).ToArray(),
        };
    }
}
