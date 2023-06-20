using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMindBox.LeetCode;

/// <summary>
/// Given an integer array nums
/// return true if any value appears at least twice in the array 
/// return false if every element is distinct.
/// </summary>
internal class ContainsDuplicateTask
{
    public bool ContainsDuplicate(int[] nums)
    {
        var hashSet = new HashSet<int>();
        foreach (int i in nums) 
        {
            if(hashSet.Contains(i))
                return true;
            else
                hashSet.Add(i);
        }

        return false;
    }
}
