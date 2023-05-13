using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next == null)
            {
                return null;
            }
            (int val, ListNode node) = StackList(head, n);
            return node;
        }

        public (int, ListNode) StackList(ListNode node, int n)
        {
            if (node == null)
            {
                return (0, null);
            }
            ListNode renode;
            (int val, ListNode tempNode) = StackList(node.next, n);
            val++;
            if (val == n)
            {
                renode = node.next;
                return (val, renode);
            }
            else
            {
                node.next = tempNode;
                return (val, node);
            }
        }
    }
}
