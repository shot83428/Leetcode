using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_141
    {
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> listNodes = new HashSet<ListNode>();

            while (head != null)
            {
                if (listNodes.Contains(head))
                {
                    return true;
                }

                listNodes.Add(head);
                head = head.next;
            }
            return false;
        }
    }
}
