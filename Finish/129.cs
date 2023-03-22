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
public class Solution {
    public int SumNumbers(TreeNode root)
    {
        Queue<TreeNode> bfs = new Queue<TreeNode>() { };
        bfs.Enqueue(root);
        int result = 0;

        while(bfs.TryDequeue(out var item))
        {
            if (item.left == null && item.right == null)
            {
                result += item.val;
                continue;
            }
            if (item.left != null)
            {
                item.left.val += item.val * 10;
                bfs.Enqueue(item.left);
            }
            if (item.right != null)
            {
                item.right.val += item.val * 10;
                bfs.Enqueue(item.right);
            }
        }
        return result;
    }
}