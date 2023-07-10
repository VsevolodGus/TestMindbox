namespace MindBoxTest.LeetCode;

/// <summary>
/// https://leetcode.com/problems/counting-bits/description/
/// </summary>
public sealed class CountingBitsTask
{
    public int[] CountBits(int n)
    {
        var result = new int[n + 1];

        for (int i = 0; i < n + 1; i++)
        {
            var binary = Convert.ToString(i, 2);
            result[i] = binary.Count(c => c == '1');
        }

        return result;
    }
}
