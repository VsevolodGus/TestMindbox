namespace TestMindBox.LeetCode;
/// <summary>
/// https://leetcode.com/problems/kth-largest-element-in-an-array/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class KthLargestElementInArray
{
    public int FindKthLargest(int[] nums, int k)
    {
        var queue = new PriorityQueue<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            queue.Enqueue(nums[i], nums[i]);

            if(queue.Count > k)
                queue.Dequeue();
        }

        return queue.Dequeue();
    }
}
