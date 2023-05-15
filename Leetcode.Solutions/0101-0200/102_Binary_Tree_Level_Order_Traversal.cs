using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_102
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;

            List<IList<int>> right_result = new List<IList<int>>();
            List<int> resultChild = new List<int>();
            resultChild.Add(root.val);
            result.Add(resultChild);

            if (root.left != null)
                result.AddRange(LevelOrder(root.left));
            if (root.right != null)
                right_result.AddRange(LevelOrder(root.right));

            int count = 1;

            foreach (var re in right_result)
            {
                if (result.Count > count)
                    ((List<int>)result[count]).AddRange(re);
                else
                    result.Add(re);
                count++;
            }

            return result;
        }
    }
}
