using System.Reflection.Metadata;

namespace TestMindBox.Trees;


public class BNode
{
    public BNode(int id) => ID = id;


    public int ID { get; }
    public BNode Left { get; init; }
    public BNode Right { get; init; }
}

public static class BinaryTree
{
    public static bool SearchByID(this BNode node, int id)
    {
        while (true)
        {
            if (node is null)
                return false;

            if (node.ID == id)
                return true;
            else if (id < node.ID)
                node = node.Left;
            else if (id > node.ID)
                node = node.Right;
        }
    }
}
