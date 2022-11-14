
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
    public void GetSkipFirst2Elelments()
    {
        var array = new int[] { 1, 2, 3, 4 };
        
        var result = array.SkipHelpers(2);

        Assert.Equal(new int[] { 3, 4 }, result.ToArray());
    }


    [Fact]
    public void GetSkipLast2Elelments()
    {
        var array = new int[] { 1, 2, 3, 4 };

        var result = array.SkipLastHelpers(2);

        Assert.Equal(new int[] { 3, 4 }, result.ToArray());
    }
}
