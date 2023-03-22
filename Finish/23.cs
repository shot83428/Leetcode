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
public class Solution {
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists.Count() == 0)
            return null;
        return MergeKListNodes(lists, 0, lists.Count() - 1);
    }
    public ListNode MergeKListNodes(ListNode[] lists, int start, int end)
    {
        if (start != end)
        {
            var left = MergeKListNodes(lists, start, (end + start) / 2);
            var right = MergeKListNodes(lists, (end + start) / 2 + 1, end);
            ListNode node = null;
            ListNode head = new ListNode(0);
            while (left != null && right != null)
            {
                if (left.val <= right.val)
                {
                    if (head.next == null)
                    {
                        head.next = left;
                        node = head.next;
                    }
                    else
                    {
                        node.next = left;
                        node = node.next;
                    }
                    left = left.next;
                }
                else
                {
                    if (head.next == null)
                    {
                        head.next = right;
                        node = head.next;
                    }
                    else
                    {
                        node.next = right;
                        node = node.next;
                    }
                    right = right.next;
                }
            }
            if (left != null)
            {
                if(node==null)
                    head.next = left;
                else
                node.next = left;
            }
            else if (right != null)
            {
                if (node == null)
                    head.next = right;
                else
                    node.next = right;
            }

            return head.next;
        }
        else
        {
            return lists[start];
        }
    }
}