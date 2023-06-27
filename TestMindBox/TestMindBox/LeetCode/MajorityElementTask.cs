namespace TestMindBox.LeetCode;
public class MajorityElementTask
{
    public int MajorityElement(int[] nums)
    {
        var count = 0;
        var candidateValue = 0;

        foreach (var item in nums)
        {
            if(count == 0) 
                candidateValue = item;

            count += (candidateValue == item) ? 1 :-1;
        }

        return candidateValue;
    }
}
