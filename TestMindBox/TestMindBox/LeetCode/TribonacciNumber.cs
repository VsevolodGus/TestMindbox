namespace TestMindBox.LeetCode;
public class TribonacciNumber
{
    public int Tribonacci(int n)
    {
        var list = new List<int>(n)
        {
            0, 1, 1
        };
        
        if(n <= 2)
            return list[n];

        for (int i = 3; i <= n; i++)
            list.Add(list[i-1]+ list[i - 2]+ list[i - 3]);
        

        return list.Last();
    }
}
