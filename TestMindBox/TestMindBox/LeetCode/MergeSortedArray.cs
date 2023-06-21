namespace TestMindBox.LeetCode;
public class MergeSortedArray
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        //var arr1 = nums1.Take(m).ToList();
        //arr1.AddRange(nums2.Take(n));

        //var result = arr1.OrderBy(c => c).ToArray();

        //Array.Copy(result, nums1, result.Length);

        Array.Copy(nums2, 0, nums1, m, n);
        Array.Sort(nums1);
    }
}
