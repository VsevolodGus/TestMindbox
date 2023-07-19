namespace TestMindBox.LeetCode;
public class StringCompression
{
    public int Compress(char[] chars)
    {
        var result = new List<char>();

        int countSymbol = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            countSymbol++;

            if (countSymbol == 9
                || chars[i] != chars[i+1])
            {
                result.Add(chars[i]);
                if(countSymbol != 1)
                    result.Add((char)('0' + countSymbol));

                countSymbol = 0;
            }
        }

        chars = result.ToArray();
        return result.Count;
    }
}
