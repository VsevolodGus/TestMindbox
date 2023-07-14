namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/container-with-most-water/description/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        var result = int.MinValue;
        int leftIndex = 0;
        int rightIndex = height.Length - 1;

        while(leftIndex < rightIndex) 
        {
            int currentArea;
            if (height[leftIndex] < height[rightIndex])
            {
                currentArea = height[leftIndex] * (rightIndex - leftIndex);
                leftIndex++;
            }
            else
            {
                currentArea = height[rightIndex] * (rightIndex - leftIndex);
                rightIndex--;
            }

            if(currentArea > result)
                result = currentArea;
        }

        return result;
    }
}
