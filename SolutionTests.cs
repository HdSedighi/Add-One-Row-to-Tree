using NUnit.Framework;
using NUnit.Framework.Legacy;


[TestFixture]

public class SolutionTests
{
    [Test]
    public void TestAddOneRow()
    {
        // Arrange
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        int val = 5;
        int depth = 2;

        // Act
        Solution solution = new Solution();
        TreeNode? result = solution.AddOneRow(root, val, depth);

        // Assert
        ClassicAssert.AreEqual(val, result?.left?.val);
        ClassicAssert.AreEqual(val, result?.right?.val);
        ClassicAssert.AreEqual(2, result?.left?.left?.val);
        ClassicAssert.AreEqual(3, result?.right?.right?.val);
    }
}