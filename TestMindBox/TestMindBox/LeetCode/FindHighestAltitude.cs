namespace TestMindBox.LeetCode;
public class FindHighestAltitude
{
    public int LargestAltitude(int[] gain)
    {
        var result = 0;
        var currentAltitude = 0;

        foreach (var a in gain) 
        {
            currentAltitude += a;
            if(result < currentAltitude) 
                result = currentAltitude;
        }

        return result;
    }

}
