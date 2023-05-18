using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_142
    {
        public ListNode DetectCycle(ListNode head)
        {
            HashSet<ListNode> listNodes = new HashSet<ListNode>();

            while (head != null)
            {
                if (listNodes.Contains(head))
                {
                    return head;
                }

                listNodes.Add(head);
                head = head.next;
            }
            return null;
        }
    }
}
