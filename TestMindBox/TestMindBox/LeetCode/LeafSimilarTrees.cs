using TestMindBox.LeetCode.Models;

namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/leaf-similar-trees/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class LeafSimilarTrees
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        var leafs1 = GetLeafs(root1);
        var leafs2 = GetLeafs(root2);

        return Enumerable.SequenceEqual(leafs1, leafs2);
    }

    public IEnumerable<int>  GetLeafs(TreeNode root) 
    {
        var list = new List<int>();

        var stack  = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.TryPop(out TreeNode node)) 
        {
            if (node.left is null && node.right is null)
            {
                yield return node.val;
                continue;
            }

            if (node.left is not null)
                stack.Push(node.left);

            if (node.right is not null)
                stack.Push(node.right);
        }

        //return list.ToArray();
    }
}
