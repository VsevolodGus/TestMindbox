﻿namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/reverse-words-in-a-string/?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class ReverseWordsInStringTask
{
    public string ReverseWords(string s)
    {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        //TODO можно ускорить с помощью stringBuilder в цикле, чтобы реверсить через индексы, а не весь массив
        return string.Join(' ', words.Reverse());

        #region Это решение лучше по памяти, но хуже по времени и не читаемо
        // Решение не мое

        //bool previousGap = false;
        //var result = new StringBuilder();

        //int j = s.Length - 1;
        //int i = s.Length - 1;

        //while (i <= j && i >= 0)
        //{
        //    if (s[i] == ' ')
        //    {
        //        if (j - i > 0)
        //        {
        //            if (previousGap) 
        //                result.Append(' ');

        //            result.Append(s.AsSpan(i + 1, j - i));
        //            previousGap = true;
        //        }
        //        j = i - 1;
        //    }
        //    i--;
        //}

        //if (j - i > 0)
        //{
        //    if (previousGap) 
        //        result.Append(' ');

        //    result.Append(s.AsSpan(i + 1, j - i));
        //}
        //return result.ToString();
        #endregion
    }
}