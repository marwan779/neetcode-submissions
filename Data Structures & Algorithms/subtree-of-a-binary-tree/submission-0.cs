  public class Solution
  {
      public bool Helper(TreeNode root, TreeNode subRoot)
      {
          if (root == null && subRoot == null) return true;
          if (root == null || subRoot == null) return false;
          if(root.val != subRoot.val) return false;

          
          return Helper(root.left, subRoot.left) && Helper(root.right, subRoot.right);
      }
      public bool IsSubtree(TreeNode root, TreeNode subRoot)
      {
          if (root == null && subRoot == null) return true;
          if (root == null || subRoot == null) return false;

          Queue<TreeNode> queue = new Queue<TreeNode>();
          TreeNode current = root;

          queue.Enqueue(current);

          while (queue.Count > 0)
          {
              int queueSize = queue.Count;

              for (int i = 0; i < queueSize; i++)
              {
                  current = queue.Dequeue();

                  if (Helper(current, subRoot))
                      return true;

                      if (current.left != null)
                          queue.Enqueue(current.left);
                  if (current.right != null)
                      queue.Enqueue(current.right);


              }
          }

          return false;
      }
  }
