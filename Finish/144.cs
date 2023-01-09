public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> output = new List<int>();
        if(root==null)
            return output;
        output.Add(root.val);
        if(root.left!=null)
            output.AddRange(PreorderTraversal(root.left));
        if(root.right!=null)
            output.AddRange(PreorderTraversal(root.right));
        return output;
    }
}