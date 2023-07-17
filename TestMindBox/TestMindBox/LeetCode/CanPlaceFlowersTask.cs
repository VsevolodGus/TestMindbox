namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/can-place-flowers/description/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class CanPlaceFlowersTask
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        for(int i = 0; i < flowerbed.Length; i++) 
        {
            var isPrev = (i == 0 || flowerbed[i - 1] == 0) && flowerbed[i] != 1;
            var isNext = (i + 1 == flowerbed.Length || flowerbed[i + 1] == 0) && flowerbed[i] != 1;

            if (isPrev && isNext)
            {
                flowerbed[i] = 1;
                n--;
            }

            if (n <= 0)
                return true;
        }

        return false;
    }
}
