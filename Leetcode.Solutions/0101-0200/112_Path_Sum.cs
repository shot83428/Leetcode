using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_112
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;
            targetSum -= root.val;
            if (root.right != null && root.left != null)
                return HasPathSum(root.left, targetSum) ||
                HasPathSum(root.right, targetSum);
            else if (root.right == null && root.left != null)
                return HasPathSum(root.left, targetSum);
            else if (root.left == null && root.right != null)
                return HasPathSum(root.right, targetSum);
            else
            {
                if (targetSum == 0)
                    return true;
                else
                    return false;
            }


        }
    }
}
