using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_101
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root != null)
                return LRsymm(root.left, root.right);
            else
                return true;
        }

        public bool LRsymm(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
                return left == right;
            else if (left.val == right.val)
                return LRsymm(left.left, right.right) && LRsymm(left.right, right.left);

            return false;
        }
    }
}
