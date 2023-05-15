using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_1721
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            ListNode node = null;
            ListNode end = null;
            Queue<ListNode> queue = new Queue<ListNode>();
            var tmp = head;
            int index = 1;
            while (tmp != null)
            {
                queue.Enqueue(tmp);
                if (index == k)
                {
                    node = tmp;
                }
                if (queue.Count > k)
                {
                    queue.Dequeue();
                }
                tmp = tmp.next;
                index++;
            }
            end = queue.Dequeue();
            if (node != null && end != null)
                (node.val, end.val) = (end.val, node.val);

            return head;
        }
    }
}
