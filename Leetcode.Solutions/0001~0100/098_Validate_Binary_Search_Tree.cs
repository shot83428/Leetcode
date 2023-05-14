using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_098
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsBST(root, long.MaxValue, long.MinValue);
        }
        public bool IsBST(TreeNode root, long max, long min)
        {
            if (root == null)
                return true;
            if (root.val <= min || root.val >= max)
                return false;

            return IsBST(root.left, root.val, min) && IsBST(root.right, max, root.val);
        }
    }
}
