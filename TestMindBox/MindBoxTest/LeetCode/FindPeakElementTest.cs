using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class FindPeakElementTest
{
    private readonly FindPeakElementTask _worker = new();

    [Theory]
    [InlineData(new int[] { 7, 8, 9 })]
    [InlineData(new int[] { 1, 3, 5, 7, 9 })]
    [InlineData(new int[] { 0, 2, 4, 6, 8 })]
    public void IfOrderArray(int[] nums)
    {
        var result = _worker.FindPeakElement(nums);

        Assert.Equal(nums.Length - 1, result);
    }


    [Theory]
    [InlineData(new int[] { 9, 8, 7 })]
    [InlineData(new int[] { 9, 7, 5, 3, 1 })]
    [InlineData(new int[] { 8, 6, 4, 2, 0 })]
    public void IfOrderDecArray(int[] nums)
    {
        var result = _worker.FindPeakElement(nums);

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 }, 2)]
    [InlineData(new int[] { 1, 2, 1, 3, 5, 6, 4 }, 5)]
    public void MixedArray(int[] nums, int exceptedResult)
    {
        var result = _worker.FindPeakElement(nums);

        Assert.Equal(exceptedResult, result);
    }

    [Theory]
    [InlineData(new int[] { 1 })]
    [InlineData(new int[] { 2 })]
    public void ArrayOfOneElement(int[] nums)
    {
        var result = _worker.FindPeakElement(nums);

        Assert.Equal(0, result);
    }
}
