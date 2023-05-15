using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_117
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return root;
            }

            if (root.left != null && root.right != null)
            {
                root.left.next = root.right;
            }

            Connect(root.left);
            Connect(root.right);

            BetweenConnect(root.left, root.right);

            return root;
        }

        private void BetweenConnect(Node left, Node right)
        {
            if (left == null || right == null)
            {
                return;
            }

            if (left.next == null)
            {
                left.next = right;
            }

            BetweenConnect(left.right, right.left);
            BetweenConnect(left.right, right.right);
            BetweenConnect(left.left, right.left);
            BetweenConnect(left.left, right.right);
        }
    }
}
