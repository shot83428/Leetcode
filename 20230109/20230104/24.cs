/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        return SwapConnect(head);
    }
    public ListNode SwapConnect(ListNode node)
    {
        if (node == null || node.next == null)
            return node;
        var newhead = node.next;
        (node.next, node.next.next) = (node.next.next, node);
        node.next = SwapConnect(node.next);
        return newhead;
    }
}