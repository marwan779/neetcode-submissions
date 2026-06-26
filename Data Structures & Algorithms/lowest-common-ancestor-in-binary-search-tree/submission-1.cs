 public class Solution
 {
     public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
     {
         
         TreeNode current = root;

         while (current != null)
         {
             if(p.val < current.val && q.val < current.val)
                 current = current.left;
             else if(p.val > current.val && q.val > current.val)
                 current = current.right;
             else
                 return current;
         }
         
         return new TreeNode(0);
     }
 }