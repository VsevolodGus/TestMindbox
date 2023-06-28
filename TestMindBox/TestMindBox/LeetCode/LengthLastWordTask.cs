namespace TestMindBox.LeetCode;
public class LengthLastWordTask
{
    public int LengthOfLastWord(string s)
    {
        #region Simple solutin
        //var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //return words.Last().Length;
        #endregion


        var result = 0;
        #region My optimized solution
        //var startWord = false;
        //for (int i = 0; i < s.Length; i++)
        //{
        //    if (!startWord)
        //    {
        //        if (s[s.Length - 1 - i] != ' ')
        //        {
        //            result++;
        //            startWord = true;
        //        }

        //        continue;
        //    }

        //    if (s[s.Length - 1 - i] == ' ')
        //        break;

        //    result++;
        //}
        #endregion

        #region Optimized solution
        for (int i = 0; i < s.Length; i++)
        {
            if (s[s.Length - 1 - i] == ' ')
            {
                if (result == 0)
                    continue;
                else
                    break;
            }

            result++;
        }
        #endregion

        return result;
    }
}
