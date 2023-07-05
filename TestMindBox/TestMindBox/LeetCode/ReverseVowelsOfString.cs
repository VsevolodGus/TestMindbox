using System.Text;

namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/reverse-vowels-of-a-string/description/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class ReverseVowelsOfString
{
    private readonly char[] vowelsLow = new char[] { 'a', 'e', 'i', 'o', 'u' };
    private readonly char[] vowelsUp = new char[] { 'A', 'E', 'I', 'O', 'U' };
    public string ReverseVowels(string s)
    {
        var str = new StringBuilder(s);

        var stack = new Stack<char>();
        for (int i = 0; i < str.Length; i++)
        {
            if (IsVowels(str[i]))
                stack.Push(str[i]);
        }

        for (int i = 0; i < str.Length; i++)
        {
            if (IsVowels(str[i]))
                str[i] = stack.Pop();
        }

        return str.ToString();
    }

    private bool IsVowels(char c)
    {
        return  vowelsLow.Contains(c) || vowelsUp.Contains(c);
    }
}
