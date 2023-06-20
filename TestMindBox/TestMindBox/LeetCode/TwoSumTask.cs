using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TestMindBox.LeetCode;
/// <summary>
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
/// </summary>
public class TwoSumTask
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var result = new List<int>();

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] != target)
                    continue;

                result.Add(i);
                result.Add(j);
            }
        }

        return result.ToArray();
    }
}
