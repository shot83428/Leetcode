using Leetcode.Solutions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_024
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
}
