public class Solution {
    public TreeNode InvertTree(TreeNode root)
    {
        if (root != null)
        {
            (root.right, root.left) = ( root.left,root.right);
            InvertTree(root.right);
            InvertTree(root.left);
        }
        return root;
    }

}