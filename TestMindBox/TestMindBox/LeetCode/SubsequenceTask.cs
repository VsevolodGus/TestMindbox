namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/is-subsequence/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class SubsequenceTask
{
    public bool IsSubsequence(string s, string t)
    {
        if (string.IsNullOrEmpty(s))
            return true;

        int indexForS = 0;

        for (int i = 0; i < t.Length; i++) 
        {
            if(indexForS == s.Length)
                break;

            if (s[indexForS] == t[i])
                indexForS++;
        }

        return indexForS == s.Length;
    }
}
