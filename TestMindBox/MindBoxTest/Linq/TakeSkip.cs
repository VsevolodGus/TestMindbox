
using TestMindBox.linq;

namespace MindBoxTest.Linq;

public class TakeSkip
{
    [Fact]
   
    public void GetLast2Elelments()
    {
        var array = new int[] { 1, 2, 3, 4 };

        var result = array.GetLast(2);

        Assert.Equal(new int[] { 3, 4 }, result.ToArray());
    }

    [Fact]
   
    public void GetLast2Elelments1()
    {
        var array = new int[] { 1, 2, 3, 4 };

        var result = array.TakeLastHelpers(2);

        Assert.Equal(new int[] { 3, 4 }, result.ToArray());
    }

    [Fact]
    public void GetFirs2Elelments()
    {
        var array = new int[] { 1, 2, 3, 4 };

        var asd = array.TakeHelpers(2);

        Assert.Equal(new int[] { 1, 2 }, asd.ToArray());
    }
    [Fact]
    public void GetFirsElelments_Optimized()
    {
        var array = new int[] { 1, 2, 3, 4 };

        var result = array.MyTake(3);

        Assert.Equal(new int[] { 1, 2, 3 }, result.ToArray());
    }

    [Fact]
    public void GetSkipFirst2Elelments()
    {
        var array = new int[] { 1, 2, 3, 4 };
        
        var result = array.SkipHelpers(2);

        Assert.Equal(new int[] { 3, 4 }, result.ToArray());
    }
    
    [Fact]
    public void GetSkipFirst2Elelments_Optimized()
    {
        var array = new int[] { 1, 2, 3, 4 };
        
        var result = array.MySkip(2);

        Assert.Equal(new int[] { 3, 4 }, result.ToArray());
    } 
    [Fact]
    public void GetSkipFirst3Elelments_Optimized()
    {
        var array = new int[] { 1, 2, 3, 4 };
        
        var result = array.MySkip(3);

        Assert.Equal(new int[] { 4 }, result.ToArray());
    }


    [Fact]
    public void GetSkipLast2Elelments()
    {
        var array = new int[] { 1, 2, 3, 4 };

        var result = array.SkipLastHelpers(2);

        Assert.Equal(new int[] { 1, 2 }, result.ToArray());
    }
    [Fact]
    public void GetSkipLast2Elelments_Optimized()
    {
        var array = new int[] { 1, 2, 3, 4 };

        var result = array.MySkipLast(2);

        Assert.Equal(new int[] { 1, 2 }, result.ToArray());
    }
}
