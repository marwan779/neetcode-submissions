 public class Solution
 {
     public int MaxDepth(TreeNode root)
     {
         if (root == null) return 0;

         int maxDepth = 0;
         Queue<TreeNode> queue = new Queue<TreeNode>();
         TreeNode current = null;
         queue.Enqueue(root);

         while (queue.Count > 0)
         {
             int levelSize = queue.Count;

             for (int i = 0; i < levelSize; i++)
             {
                 current = queue.Dequeue();
                 if (current.left != null)
                     queue.Enqueue(current.left);
                 if (current.right != null)
                     queue.Enqueue(current.right);
             }

             maxDepth++;
             
         }

         return maxDepth;
     }
 }