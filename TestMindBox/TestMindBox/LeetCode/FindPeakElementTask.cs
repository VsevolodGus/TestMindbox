﻿namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/find-peak-element/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class FindPeakElementTask
{
    public int FindPeakElement(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left + 1 < right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] < nums[mid + 1])
                left = mid;
            else
                right = mid;
        }

        return nums[left] > nums[right] ? left : right;
    }
}
