using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_145
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> output = new List<int>();
            if (root == null)
                return output;
            output.Add(root.val);
            if (root.right != null)
                output.InsertRange(0, PostorderTraversal(root.right));
            if (root.left != null)
                output.InsertRange(0, PostorderTraversal(root.left));

            return output;
        }
    }
}
