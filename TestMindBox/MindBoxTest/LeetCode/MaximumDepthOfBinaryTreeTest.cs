using TestMindBox.LeetCode;
using TestMindBox.LeetCode.Models;

namespace MindBoxTest.LeetCode;
public class MaximumDepthOfBinaryTreeTest
{
    private readonly MaximumDepthOfBinaryTree _worker = new();

    [Fact]
    public void Test()
    {
        var node = new TreeNode(1) 
        { 
            right = new TreeNode(2), 
        };

        var result = _worker.MaxDepth(node);

        Assert.Equal(2, result);
    }
}
