using TestMindBox.Trees;

namespace MindBoxTest.Trees;

public class BinaryTreeTest
{
    //     1
    //   8  12
    //7 9     11 13
    private readonly BNode _root = new BNode(10)
    {
        Left = new BNode(8)
        {
            Left = new BNode(7),
            Right = new BNode(9)
        }, 
        Right = new BNode(12)
        {
            Left = new BNode(11),
            Right = new BNode(13)
        }
    };

    [Fact]
    public void SearchEixistsNode_11()
    {
        var result = _root.SearchByID(11);

        Assert.True(result);
    }

    [Fact]
    public void SearchEixistsNode_9()
    {
        var result = _root.SearchByID(9);

        Assert.True(result);
    }

    [Fact]
    public void SearchNotEixistsNode()
    {
        var result = _root.SearchByID(1);

        Assert.False(result);
    }
}
