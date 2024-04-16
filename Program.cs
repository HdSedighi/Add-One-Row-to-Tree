internal class Program  {
   private static void Main(string[] args)
    {
         // Example usage:
        // Create a binary tree
        TreeNode root = new TreeNode(4);
        root.left = new TreeNode(2);
        root.right = new TreeNode(6);
        root.left.left = new TreeNode(3);
        root.left.right = new TreeNode(1);
        root.right.left = new TreeNode(5);

        Solution solution = new Solution();
        TreeNode? newRoot = solution.AddOneRow(root, 1, 2);

        // Display the modified tree
        Console.WriteLine("Modified Tree:");
        PrintTree(newRoot);
    }

    static void PrintTree(TreeNode? node) {
        if (node == null) return;
        Console.Write(node.val + " ");
        PrintTree(node.left);
        PrintTree(node.right);
    }

}