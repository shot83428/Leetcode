using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_147
    {
        public ListNode InsertionSortList(ListNode head)
        {
            ListNode next = head.next;
            head.next = null;

            while (next != null)
            {
                head = InsertionSort(head, next);
                next = next.next;
            }

            return head;
        }

        public ListNode InsertionSort(ListNode head, ListNode index)
        {
            if (index.val < head.val)
            {
                return new ListNode(index.val) { next = head };
            }
            else
            {
                ListNode tmp = head;
                while (tmp.next != null && tmp.next.val < index.val)
                {
                    tmp = tmp.next;
                }
                ListNode newNode = new ListNode(index.val) { next = index.next };
                newNode.next = tmp.next;
                tmp.next = newNode;
            }

            return head;
        }
    }
}
