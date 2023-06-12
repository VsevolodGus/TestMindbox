using System.Security.Cryptography.X509Certificates;

namespace TestMindBox.Trees;

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

public static class ExtentionsNode
{
    public static List<int> IterateTreeInWidth(this Node root)
    {
        var result = new List<int>
        {
            root.ID
        };

        var nodes = new Queue<Node>(root.Children);

        while (nodes.TryDequeue(out root))
        {
            result.Add(root.ID);

            foreach (var item in root.Children)
                nodes.Enqueue(item);
        }

        return result;
    }


    public static List<int> IterateTreeInDepthRightToLeft(this Node root)
    {
        var result = new List<int>();

        var stack = new Stack<Node>();
        stack.Push(root);

        while (stack.TryPop(out root))
        {
            result.Add(root.ID);

            foreach(var item in root.Children)
                stack.Push(item);
        }

        
        return result;
    }


    public static List<int> IterateTreeInDepthLeftToRight(this Node n)
    {
        var root = new Node(n);
        var result = new List<int>();

        var stack = new Stack<Node>();
        stack.Push(root);

        while (stack.TryPop(out root))
        {
            result.Add(root.ID);

            foreach (var item in root.Children.Reverse())
                stack.Push(item);
        }


        return result;
    }

}