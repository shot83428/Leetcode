/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if(root!=null)
            return LRsymm(root.left,root.right);
        else
            return true;
    }
    
    public bool LRsymm(TreeNode left,TreeNode right) {
        if(left==null||right==null)
            return left==right;
        else if(left.val == right.val)
            return LRsymm(left.left,right.right) && LRsymm(left.right,right.left);
        
        return false;
    } 
}