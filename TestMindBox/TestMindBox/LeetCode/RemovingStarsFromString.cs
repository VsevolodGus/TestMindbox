using System.Text;

namespace TestMindBox.LeetCode;
public class RemovingStarsFromString
{
    public string RemoveStars(string s)
    {
        var result = new StringBuilder(s.Length);

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '*')
            {
                result = result.Remove(result.Length - 1, 1);
                continue;
            }


            result.Append(s[i]);
        }

        return result.ToString();


        #region MyFirstSolution
        //var result = new StringBuilder(s.Length);
        //var stack = new Stack<char>(s.Length);

        //for (int i = s.Length - 1; i >= 0; i--)
        //    stack.Push(s[i]);

        //while (stack.TryPop(out char current))
        //{
        //    if (current == '*')
        //    {
        //        result = result.Remove(result.Length-1, 1);
        //        continue;
        //    }


        //    result.Append(current);
        //}


        //return result.ToString();
        #endregion
    }
}
