public class Solution
{
    public List<int> RightSideView(TreeNode root)
    {
        List<int> result = new List<int>();

        if(root == null) 
            return result;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        TreeNode current = root;
        queue.Enqueue(current);


        while (queue.Count > 0)
        {
            int queueSize = queue.Count;

            for (int i = 0; i < queueSize; i++)
            {
                current = queue.Dequeue();

                if(i ==  queueSize - 1)
                    result.Add(current.val);

                if(current.left != null)
                    queue.Enqueue(current.left);
                if(current.right != null)
                    queue.Enqueue(current.right);
            }
        }

        return result;
    }
}