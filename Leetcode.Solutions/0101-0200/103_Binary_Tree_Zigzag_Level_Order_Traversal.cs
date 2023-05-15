using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_103
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            bool flag = true;
            IList<IList<int>> result = new List<IList<int>>();
            List<TreeNode> bfs = new List<TreeNode>() { };
            if (root != null)
                bfs.Add(root);

            while (bfs.Any())
            {
                List<TreeNode> tmp = new List<TreeNode>();
                List<int> buffer = new List<int>();
                foreach (var item in bfs)
                {
                    if (item.left != null)
                    {
                        tmp.Add(item.left);
                    }

                    if (item.right != null)
                    {
                        tmp.Add(item.right);
                    }

                    if (flag)
                    {
                        buffer.Add(item.val);
                    }
                    else
                    {
                        buffer.Insert(0, item.val);
                    }
                }
                result.Add(buffer);
                flag = !flag;
                bfs = tmp;
            }

            return result;
        }
    }
}
