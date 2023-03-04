public class Solution {
    public int MinDiffInBST(TreeNode root)
    {
        List<int> list = ParseBST(root);
        list.Sort();
        int result = 200000;
        for(int index=0;index<list.Count-1;index++)
        {
            result = Math.Min(list[index+1] - list[index], result);
        }
        return result;
    }
    public List<int> ParseBST(TreeNode node)
    {
        var list = new List<int>();
        if (node.left != null)
            list.AddRange(ParseBST(node.left));
        if (node.right != null)
            list.AddRange(ParseBST(node.right));
        list.Add(node.val);
        return list;
    }


}