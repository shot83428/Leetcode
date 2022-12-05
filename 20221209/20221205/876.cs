public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        List<ListNode> lists = new List<ListNode>();
        for (var node = head; node != null; node = node.next)
        {
            lists.Add(node);
        }
        return lists[lists.Count() / 2];
    }
}