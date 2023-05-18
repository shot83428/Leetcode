using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_129
    {
        public int SumNumbers(TreeNode root)
        {
            Queue<TreeNode> bfs = new Queue<TreeNode>() { };
            bfs.Enqueue(root);
            int result = 0;

            while (bfs.TryDequeue(out var item))
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
}
