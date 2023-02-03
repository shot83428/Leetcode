public class Solution {
    public void Flatten(TreeNode root)
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        void PreOrder(TreeNode node)
        {
            queue.Enqueue(node);
            if (node.left != null)
            {
                PreOrder(node.left);
            }
            if (node.right != null)
            {
                PreOrder(node.right);
            }
        }
        if (root != null)
            PreOrder(root);
        queue.TryDequeue(out var bf);
        while (queue.TryDequeue(out var next))
        {
            bf.left = null;
            next.left = null;
            bf.right = next;
            bf = next;
        }
    }
}