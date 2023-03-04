public class Solution {
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        int max = 0;
        max = Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        return max + 1;
    }
}