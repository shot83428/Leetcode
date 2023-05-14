using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_099
    {
        public void RecoverTree(TreeNode root)
        {
            RecoverTreeLeft(root, root);
            RecoverTreeRight(root, root);
        }

        private void RecoverTreeLeft(TreeNode root, TreeNode sub)
        {
            if (sub == null)
            {
                return;
            }
            if (root.val < sub.val)
            {
                int temp = root.val;
                root.val = sub.val;
                sub.val = temp;
            }

            RecoverTreeLeft(root, sub.left);
            RecoverTreeLeft(sub, sub.left);
            RecoverTreeLeft(root, sub.right);
            RecoverTreeRight(sub, sub.right);
        }

        private void RecoverTreeRight(TreeNode root, TreeNode sub)
        {
            if (sub == null)
            {
                return;
            }
            if (root.val > sub.val)
            {
                int temp = root.val;
                root.val = sub.val;
                sub.val = temp;
            }
            RecoverTreeRight(root, sub.right);
            RecoverTreeRight(sub, sub.right);
            RecoverTreeRight(root, sub.left);
            RecoverTreeLeft(sub, sub.left);
        }

    }
}
