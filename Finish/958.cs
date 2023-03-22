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
    public bool IsCompleteTree(TreeNode root)
    {
        Queue<TreeNode?> bfs = new Queue<TreeNode?>();
        bfs.Enqueue(root);
        bool isnull = false;
        while(bfs.Any())
        {
            Queue<TreeNode?> tmp = new Queue<TreeNode?>();
            while (bfs.TryDequeue(out var node))
            {
                if (node == null)
                {
                    isnull = true;
                    continue;
                }
                else
                {
                    if(isnull)
                    {
                        return false;
                    }
                }
                tmp.Enqueue(node.left);
                tmp.Enqueue(node.right);
            }

            bfs = tmp;
        }
        return true;
    }
}