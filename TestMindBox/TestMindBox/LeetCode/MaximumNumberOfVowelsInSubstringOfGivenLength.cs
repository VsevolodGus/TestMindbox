namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class MaximumNumberOfVowelsInSubstringOfGivenLength
{
    private readonly HashSet<char>_vowels = new(new char[] { 'a', 'e', 'i', 'o', 'u' });

    public int MaxVowels(string s, int k)
    {
        if (k == 0)
            return 0;

        var count = s[..k].Count(_vowels.Contains);
        var maxCountVowels = count;
        for (int i = k; i < s.Length; i++)
        {
            var asd = s.Substring(i - k, k);

            count -= _vowels.Contains(s[i - k]) ? 1 : 0;
            count += _vowels.Contains(s[i]) ? 1 : 0;

            if (count > maxCountVowels)
                maxCountVowels = count;
        }

        return maxCountVowels;
    }
}
