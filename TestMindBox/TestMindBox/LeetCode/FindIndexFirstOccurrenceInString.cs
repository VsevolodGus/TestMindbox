namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/?envType=study-plan-v2
/// </summary>&envId=top-interview-150
public class FindIndexFirstOccurrenceInString
{
    public int StrStr(string haystack, string needle)
    {
        #region MySolution
        //var result = -1;
        //for(int i = 0; i< haystack.Length - needle.Length + 1; i++)
        //{
        //    var sub =  haystack.Substring(i, needle.Length);
        //    if (!needle.Equals(sub))
        //        continue;

        //    result = i;
        //    break;
        //}

        //return result;
        #endregion

        var count = -1;

        for (int i = 0; i < haystack.Length; i++)
        {
            count++;
            if (haystack[i] == needle[count] && count == needle.Length - 1)
                return i - count;
            else if (haystack[i] != needle[count])
            { 
                i -= count;
                count = -1;
            }
        }

        return count;
    }
}
