using TestMindBox.LeetCode.Models;

namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/maximum-depth-of-binary-tree/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class MaximumDepthOfBinaryTree
{
    public int MaxDepth(TreeNode root)
    {
        return MaxDepth(root, 0);
    }

    private int MaxDepth(TreeNode root, int depth) 
    {
        depth++;
        if(root.left is null && root.right is null)
            return depth;

        var leftDepth = root.left is not null ? MaxDepth(root.left, depth) : depth - 1;
        var rightDepth = root.right is not null ? MaxDepth(root.right, depth) : depth - 1;


        return Math.Max(leftDepth, rightDepth);
    }
}
