public class Solution {
     public TreeNode? AddOneRow(TreeNode? root, int val, int depth,int currentDepth=1) {

         if(depth==1)
        {
            TreeNode newRoot = new TreeNode(val);
            newRoot.left=root;
            return newRoot;
        }
        if(root == null) return root;

        //check if its the targetted row
        if(currentDepth== (depth-1))
        {
            TreeNode newLeftRoot = new TreeNode(val);
            newLeftRoot.left=root.left;
            root.left = newLeftRoot;

            TreeNode newRightRoot = new TreeNode(val);
            newRightRoot.right=root.right;
            root.right = newRightRoot;
            
        }
        else{
            AddOneRow(root.left, val, depth,currentDepth + 1);
            AddOneRow(root.right, val, depth,currentDepth + 1);
        }

        return root;
    }
}

