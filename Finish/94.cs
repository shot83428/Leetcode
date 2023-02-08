public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> output = new List<int>();
        if(root==null)
            return output;
        output.Add(root.val);
        if(root.left!=null)
            output.InsertRange(0,InorderTraversal(root.left));
       
        if(root.right!=null)
            output.AddRange(InorderTraversal(root.right));
        return output;
    }
}