using TestMindBox.LeetCode.Models;

namespace TestMindBox.LeetCode;

/// <summary>
/// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class LowestCommonAncestorOfBinaryTreeTask
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        var parentsP = new List<TreeNode>();
        FindNodeRec(root, p, parentsP);

        var parentsQ = new List<TreeNode>();
        FindNodeRec(root, q, parentsQ);
        
        return parentsP.Intersect(parentsQ).LastOrDefault();
    }

    /// <summary>
    /// Рекурсивный поиск с получением ветки до этого узла
    /// </summary>
    /// <param name="root">корневой узел</param>
    /// <param name="p">узел который ищем</param>
    /// <param name="parents">Ветка от коренвой до искомого узла</param>
    /// <returns>найден узел или нет</returns>
    private bool FindNodeRec(TreeNode root, TreeNode p, List<TreeNode> parents)
    {
        parents.Add(root);

        if (root.Equals(p))
            return true;

        if (root.left is not null && FindNodeRec(root.left, p, parents))
            return true;

        if (root.right is not null && FindNodeRec(root.right, p, parents))
            return true;

        parents.Remove(root);
        return false;
    }
}
