using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestMindBox;

public sealed class Node
{

    public Node(char id)
    {
        ID = id;
    }
    public char ID { get; init; }

    public IEnumerable<Node> Children { get; init; }
}

public sealed class BNode
{
    public IEnumerable<Node> Children { get; init; }
}


public static class NodeExtentions
{
    public static IEnumerable<char>? GetAllNodes(this Node root)
    {
        var result = new Queue<char>();
        result.Enqueue(root.ID);
        

        var nodes = new Queue<Node>(root.Children);

        while (nodes.TryDequeue(out Node workRoot))
        {
            result.Enqueue(workRoot.ID);
            
            if (workRoot.Children is null)
                continue;

            foreach (var item in workRoot.Children)
                nodes.Enqueue(item);
        }

        return result;
    }
}