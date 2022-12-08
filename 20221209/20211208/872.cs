public class Solution
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        List<int> root1Lists = new List<int>();
        List<int> root2Lists = new List<int>();
        Leaf(root1, ref root1Lists);
        Leaf(root2, ref root2Lists);
        if (root1Lists.Count != root2Lists.Count)
            return false;
        for (int index = 0; index < root1Lists.Count; index++)
        {
            if (root1Lists[index] != root2Lists[index])
                return false;
        }
        return true;
    }
    public void Leaf(TreeNode node, ref List<int> lists)
    {
        if (node.left == null && node.right == null)
        {
            lists.Add(node.val);
            return;
        }
        if (node.left != null)
        {
            Leaf(node.left, ref lists);
        }
        if (node.right != null)
        {
            Leaf(node.right, ref lists);
        }
    }
}