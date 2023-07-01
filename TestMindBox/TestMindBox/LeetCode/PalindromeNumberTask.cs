namespace TestMindBox.LeetCode;
public class PalindromeNumberTask
{
    public bool IsPalindrome(int x)
    {
        if(x < 0)
            return false;

        #region FirstSolution
        //var strX =  x.ToString();
        //var asd = strX.ToCharArray();
        //Array.Reverse(asd);
        //var reversX = new string(asd);

        //return strX.Equals(reversX);
        #endregion

        #region SecondSolution
        var strX = x.ToString();

        for (int i = 0; i < strX.Length; i++)
        {
            if (strX[i] != strX[strX.Length - 1 - i])
                return false;
        }


        return true;
        #endregion
    }
}
