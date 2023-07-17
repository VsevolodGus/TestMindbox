namespace TestMindBox.LeetCode;
/// <summary>
/// https://leetcode.com/problems/greatest-common-divisor-of-strings/description/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class GreatestCommonDivisorOfStrings
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1)
            return string.Empty;

        var minLenght = Math.Min(str1.Length, str2.Length);
        for (int i = minLenght; i >= 0; i--)
        {
            if (IsValid(str1, str2, i))
                return str1[..i];
        }

        return string.Empty;
    }

    public bool IsValid(string str1, string str2, int index)
    {
        if(str1.Length % index != 0 && str2.Length % index != 0)
            return false;

        var substring = str1[..index];
        
        return str1.Replace(substring, string.Empty) == string.Empty
                && str2.Replace(substring, string.Empty) == string.Empty;
    }
}
