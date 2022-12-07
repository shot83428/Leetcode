public class Solution {
    public ListNode OddEvenList(ListNode head)
    {
        if (head != null)
            OEList(head, head.next, false);
        return head;
    }
    public void OEList(ListNode node, ListNode? head, bool isOdd)
    {
        if (node == null)
            return;
        ListNode next = node.next;
        if (node.next != null)
        {
            node.next = node.next.next;
        }

        if (!isOdd)
        {
            if (node.next == null)
            {
                node.next = head;
                return;
            }
        }
        OEList(next, head, !isOdd);
    }
}