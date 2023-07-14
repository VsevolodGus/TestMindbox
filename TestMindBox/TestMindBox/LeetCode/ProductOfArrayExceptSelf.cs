namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/product-of-array-except-self/description/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class ProductOfArrayExceptSelf
{
    /// <summary>
    /// Рассматриваю три случая
    /// 1) если больше 1 нуля, то все значения 0
    /// 2) если есть 
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];

        if (nums.Count(c => c == 0) == 1)
        {
            int indexZero = 0;
            int a = 1;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != 0)
                    a *= nums[i];
                else
                    indexZero = i;

            result[indexZero] = a;
        }
        else if(nums.All(c => c != 0))
        {
            int a = 1;
            foreach (int i in nums)
                    a *= i;

            for (int i = 0; i < nums.Length; i++)
                result[i] = a / nums[i];
        }

        return result;
        
    }
}
