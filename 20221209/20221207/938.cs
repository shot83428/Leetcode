public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        if (root == null)
            return 0;
        var left = RangeSumBST(root.left, low, high);
        var right = RangeSumBST(root.right, low, high);
        if (root.val >= low && root.val <= high)
        {
            return left + right + root.val;
        }
        return left + right;
    }
}