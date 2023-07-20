using TestMindBox.LeetCode;

namespace MindBoxTest.LeetCode;
public class LowestCommonAncestorOfBinaryTreeTest
{
    private readonly LowestCommonAncestorOfBinaryTreeTask _worker = new();
    [Fact]
    public void FirstTest()
    {
        var s = new TreeNode(4);

        var p = new TreeNode(5) 
        {
            right = new TreeNode(2) 
            {
                right = s,
                left = new TreeNode(7),
            },
            left = new TreeNode(6),
        };

        var q = new TreeNode(1)
        {
            right = new TreeNode(8),
            left = new TreeNode(0),
        };

        var root = new TreeNode(3) 
        {
            right = q,
            left = p,
        };

        var result = _worker.LowestCommonAncestor(root, p, q);

        Assert.Equal(root, result);
    }

    [Fact]
    public void Find()
    {
        var p = new TreeNode(5)
        {
            right = new TreeNode(2)
            {
                right = new TreeNode(4),
                left = new TreeNode(7),
            },
            left = new TreeNode(6),
        };

        var q = new TreeNode(1)
        {
            right = new TreeNode(8),
            left = new TreeNode(0),
        };

        var root = new TreeNode(3)
        {
            right = q,
            left = p,
        };
        var parents = new List<TreeNode>();
        var result = FindNodeRec(root, q, parents);

        Assert.True(result);
    }

    private bool FindNode(TreeNode root, TreeNode p)
    {
        var result = new List<TreeNode>();

        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.TryPop(out TreeNode node))
        {
            result.Add(node);
            if (node.Equals(p))
                return true;


            if (node.right is not null)
                stack.Push(node.right);

            if (node.left is not null)
                stack.Push(node.left);
        }


        return false;
    }

    private bool FindNodeRec(TreeNode root, TreeNode p, List<TreeNode> parents)
    {
        parents.Add(root);

        if (root.Equals(p))
            return true;

        if(root.left is not null && FindNodeRec(root.left, p, parents))
            return true;

        if (root.right is not null && FindNodeRec(root.right, p, parents))
            return true;

        parents.Remove(root);
        return false;
    }
}
