/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
            return null;

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            TreeNode current = stack.Pop();

            // Swap the left and right children
            TreeNode temp = current.left;
            current.left = current.right;
            current.right = temp;

            // Push children to stack if they exist
            if (current.left != null)
                stack.Push(current.left);
            if (current.right != null)
                stack.Push(current.right);
        }

        return root;
    }
}
