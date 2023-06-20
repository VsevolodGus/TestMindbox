namespace TestMindBox.LeetCode;
public class LengthOfLongestSubstringTask
{
    public int LengthOfLongestSubstring(string s)
    {
        var dic = new Dictionary<char, int>(s.Distinct().Count());

        int left = 0, right = 0;
        int result = 0;

        while (right < s.Length)
        {
            if (dic.ContainsKey(s[right]))
                left = Math.Max(left, dic[s[right]] + 1);

            if (dic.ContainsKey(s[right]))
                dic[s[right]] = right;
            else 
                dic.Add(s[right], right);

            result = Math.Max(result, right -  left + 1);
            right++;
        }

        return result;
    }
}
