using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_095
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            var arr = Enumerable.Range(1, n).ToList();
            return Solve(arr);
        }

        private IList<TreeNode> Solve(List<int> arr)
        {
            var ret = new List<TreeNode>();
            if (arr.Count == 0)
            {
                ret.Add(null);
                return ret;
            }
            if (arr.Count == 1)
            {
                ret.Add(new TreeNode(arr[0]));
                return ret;
            }
            foreach (var i in arr)
            {
                var left = new List<int>();
                var right = new List<int>();
                foreach (var j in arr)
                {
                    if (j < i) left.Add(j);
                    else if (j > i) right.Add(j);
                }
                foreach (var lef in Solve(left))
                {
                    foreach (var rit in Solve(right))
                    {
                        var root = new TreeNode(i);
                        root.left = lef;
                        root.right = rit;
                        ret.Add(root);
                    }
                }
            }
            return ret;
        }
    }
}
