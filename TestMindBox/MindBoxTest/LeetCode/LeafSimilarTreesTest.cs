using TestMindBox.LeetCode;
using TestMindBox.LeetCode.Models;

namespace MindBoxTest.LeetCode;
public class LeafSimilarTreesTest
{
    private readonly LeafSimilarTrees _worker = new();

    [Fact]
    public void Test()
    {
        var root1 = new TreeNode(3) 
        {
            left = new TreeNode(5)
            {
                left = new TreeNode(6),
                right = new TreeNode(2)
                {
                    left = new TreeNode(7),
                    right = new TreeNode(4)
                },
            },
            right = new TreeNode(1) 
            {
                left = new TreeNode(9),
                right = new TreeNode(8),
            },
        };

        var root2 = new TreeNode(3)
        {
            left = new TreeNode(5)
            {
                left = new TreeNode(6),
                right = new TreeNode(7),
            },
            right = new TreeNode(1)
            {
                left = new TreeNode(4),
                right = new TreeNode(2) 
                {
                    left = new TreeNode(9),
                    right = new TreeNode(8)
                },
            },
        };

        var result = _worker.LeafSimilar(root1, root2);

        Assert.True(result);
    }
}
