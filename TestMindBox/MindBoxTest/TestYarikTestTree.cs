using TestMindBox;

namespace MindBoxTest;
/// <summary>
///              1
///         2         3
///       4   5     6   7
/// </summary>
public class TestYarikTestTree
{
    private readonly Node _node = new Node()
    {
        ID = 1,
        Children = new Node[]
        {
            new Node()
            {
                ID = 2,
                Children = new Node[]
                {
                    new Node()
                    {
                        ID = 4,
                        Children = Array.Empty<Node>()
                    },
                    new Node()
                    {
                        ID = 5,
                        Children = Array.Empty<Node>()
                    },
                }
            },
            new Node()
            {
                ID = 3,
                Children = new Node[]
                {
                    new Node()
                    {
                        ID = 6,
                        Children = Array.Empty<Node>()
                    },
                    new Node()
                    {
                        ID = 7,
                        Children = Array.Empty<Node>()
                    },
                }
            }
        }
    };

    [Fact]
    public void WidthTraversal()
    {
        var result = _node.IterateTreeInWidth();

        Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7 }, result);
    }

    [Fact]
    public void DeepCrawlLeftToRight()
    {
        var result = _node.IterateTreeInDepth();

        Assert.Equal(new int[] { 1, 2, 4, 5, 3, 6, 7 }, result);
    }
}
