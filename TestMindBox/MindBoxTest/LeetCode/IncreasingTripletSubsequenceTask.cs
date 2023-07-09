using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public sealed class IncreasingTripletSubsequenceTask
{
    private readonly IncreasingTripletSubsequence _worker = new();
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 2, 3, 4, 5, 6 })]
    [InlineData(new int[] { 10, 11, 12})]
    public void SimpleTrue(int[] nums)
    {
        var result = _worker.IncreasingTriplet(nums);

        Assert.True(result);
    }

    [Theory]
    [InlineData(new int[] { 5, 4, 3, 2, 1 })]
    [InlineData(new int[] { 8, 7, 6, 5, 4, 3 })]
    [InlineData(new int[] { 12, 11, 10 })]
    public void SimpleFalse(int[] nums)
    {
        var result = _worker.IncreasingTriplet(nums);

        Assert.False(result);
    }


    [Theory]
    [InlineData(new int[] { 2, 1, 5, 0, 4, 6 })]
    public void HasTripleButMixedArray_True(int[] nums)
    {
        var result = _worker.IncreasingTriplet(nums);

        Assert.True(result);
    }

    [Theory]
    [InlineData(new int[] { 20, 100, 10, 12, 5, 13 })]
    public void MixedTriple_True(int[] nums)
    {
        var result = _worker.IncreasingTriplet(nums);

        Assert.True(result);
    }
    
}
