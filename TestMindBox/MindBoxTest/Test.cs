using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMindBox;

namespace MindBoxTest;

public class Test
{
    private readonly Node _root = new Node('a')
    {
        Children = new Node[] 
        {
            new Node('b')
            {
                Children = new Node[]
                {
                    new Node('d'),
                    new Node('e'),
                    new Node('f')
                },
            },
            new Node('c')
            {
                 Children = new Node[]
                {
                    new Node('g'),
                    new Node('h'),
                },
            }
        }
    };

    
    private readonly BNode asd = new BNode()
    {

    };

    //private 
    //[Fact]
    public void test()
    {
        var result = _root.GetAllNodes();
        var excepted = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
        Assert.Equal(excepted, result);
    }

    //[Fact]
    //public void tasdest()
    //{
    //    var result = asd.GetAllNodes();
    //    var excepted = new char[] { asd, asd.Children[0] };
    //    Assert.Equal(excepted, result);
    //}
}
