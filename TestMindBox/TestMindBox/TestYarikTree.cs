using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMindBox.Trees;

namespace TestMindBox;

public class Node
{
    public Node(Node node)
    {
        ID = node.ID;
        Children = (Node[])node.Children.Clone();
    }
    public Node()
    {
    }

    public int ID { get; init; }
    public Node[] Children { get; init; } = Array.Empty<Node>();
}


public static class TestYarikTree
{

    public static List<int> IterateTreeInWidth(this Node root)
    {
        var result = new List<int>();
        var parents = new Queue<Node>();
        parents.Enqueue(root);

        while (parents.TryDequeue(out Node node))
        {
            result.Add(node.ID);

            foreach (var child in node.Children)
                parents.Enqueue(child);
        }

        return result;

        int i = 1;
        Console.WriteLine("i = {0}", ++i);
    }

    
    public static List<int> IterateTreeInDepth(this Node root)
    {
        var result = new List<int>();
        var parents = new Stack<Node>();
        parents.Push(root);

        
        while (parents.TryPop(out Node node))
        {
            result.Add(node.ID);

            foreach (var child in node.Children.Reverse())
                parents.Push(child);
        }

        return result;
    }
}
