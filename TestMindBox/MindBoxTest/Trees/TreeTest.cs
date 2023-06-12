using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMindBox.Trees;

namespace MindBoxTest.Trees;

public class TreeTest
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
    public void DeepCrawlRightToLeft()
    {
        var result = _node.IterateTreeInDepthRightToLeft();

        Assert.Equal(new int[] { 1, 3, 7, 6, 2, 5, 4 }, result);
    }
    
    [Fact]
    public void DeepCrawlLeftToRight()
    {
        var result = _node.IterateTreeInDepthLeftToRight();

        Assert.Equal(new int[] { 1, 2, 4, 5, 3, 6, 7 }, result);
    }
}
