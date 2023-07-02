using System.Text;

namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/studyplan/leetcode-75/
/// </summary>
public class MergeStringsAlternately
{

    public string MergeAlternately(string word1, string word2)
    {
        #region Мое решение, через массив
        //var result = new char[word1.Length + word2.Length];

        //var minLenght = Math.Min(word1.Length, word2.Length);

        //for (int i = 0; i < minLenght; i++) 
        //    result[i*2] = word1[i];

        //for (int i = 0; i < minLenght; i++)
        //    result[(i*2)+1] = word2[i];

        //if(word1.Length == word2.Length)
        //    return new string(result.ToArray());


        //var str = word1.Length == minLenght ? word2 : word1;

        //for (int i = 0; i < str.Length - minLenght; i++)
        //    result[minLenght * 2 + i] = str[minLenght + i];

        //return new string(result.ToArray());
        #endregion

        var result = new StringBuilder(word1.Length + word2.Length);
        int indexFirstWord = 0;
        int indexSecondWord = 0;

        while (indexFirstWord < word1.Length && indexSecondWord < word2.Length)
        {
            result.Append(word1[indexFirstWord])
                  .Append(word2[indexSecondWord]);

            indexFirstWord++;
            indexSecondWord++;
        }

        while (indexFirstWord < word1.Length)
        {
            result.Append(word1[indexFirstWord]);
            indexFirstWord++;
        }

        while (indexSecondWord < word2.Length)
        {
            result.Append(word2[indexSecondWord]);
            indexSecondWord++;
        }

        return result.ToString();
    }
}
