public class Solution
{
    public List<List<int>> LevelOrder(TreeNode root)
    {
        List<List<int>> result = new List<List<int>>();

        if(root == null) return result;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        TreeNode current = root;

        queue.Enqueue(current);

        while (queue.Count > 0)
        {
            int queueSize = queue.Count;
            List<int> list = new List<int>();

            for (int i = 0; i < queueSize; i++)
            {
                current = queue.Dequeue();
                list.Add(current.val);

                if(current.left != null)
                    queue.Enqueue(current.left);
                if (current.right != null)
                    queue.Enqueue(current.right);
            }

            result.Add(list);   
        }
        return result;


    }
}