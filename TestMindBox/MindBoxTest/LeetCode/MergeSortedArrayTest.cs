using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class MergeSortedArrayTest
{
    private readonly MergeSortedArray _worker = new();

    [Fact]
    public void FirstTest()
    {
        var nums1 = new int[] {1,2,3,0,0,0};
        var m = 3;
        
        var nums2 = new int[] {2,5,6};
        var n = 3;

        _worker.Merge(nums1, m, nums2, n);

        Assert.Equal(new int[] { 1, 2, 2, 3, 5, 6 }, nums1);
    }
}
