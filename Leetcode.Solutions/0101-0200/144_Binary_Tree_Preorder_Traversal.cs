using Leetcode.Solutions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_144
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> output = new List<int>();
            if (root == null)
                return output;
            output.Add(root.val);
            if (root.left != null)
                output.AddRange(PreorderTraversal(root.left));
            if (root.right != null)
                output.AddRange(PreorderTraversal(root.right));
            return output;
        }
    }
}
