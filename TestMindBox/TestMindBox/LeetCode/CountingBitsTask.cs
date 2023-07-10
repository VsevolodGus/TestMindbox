namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/counting-bits/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class CountingBitsTask
{
    public int[] CountBits(int n)
    {
        var result = new int[n+1];

        for(int i = 0; i < n+1; i++) 
        {
            var binary = Convert.ToString(i, 2);
            result[i] = binary.Count(c=> c == '1');
        }

        return result;
    }
}
