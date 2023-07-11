using System.Text;

namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/decode-string/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class DecodeStringTask
{
    public string DecodeString(string s)
    {
        var result = new StringBuilder();

        #region Решение которое подсмотрел
        //var stack = new Stack<(int Start, int CountRepeat)>(s.Count(c=> c == '['));
        //var coutRepeats = 0;

        //foreach (var symbol in s)
        //{
        //    if (char.IsDigit(symbol))
        //        coutRepeats = coutRepeats * 10 + symbol - '0';
        //    else if (symbol == '[')
        //    {
        //        stack.Push((result.Length, coutRepeats));
        //        coutRepeats = 0;
        //    }
        //    else if (symbol == ']')
        //    {
        //        (var start, var currentCountRepeat) = stack.Pop();

        //        var repeatStirng = result.ToString().Substring(start);

        //        result.Append(string.Concat(Enumerable.Repeat(repeatStirng, currentCountRepeat - 1)));
        //    }
        //    else
        //        result.Append(symbol);

        //}
        #endregion

        return result.ToString();
    }
}
