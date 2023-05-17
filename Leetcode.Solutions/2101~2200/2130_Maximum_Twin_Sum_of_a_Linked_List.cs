using Leetcode.Solutions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_2130
    {
        public int PairSum(ListNode head)
        {
            var start = head;
            ListNode next = head.next;
            var end = head.next;
            while (end.next != null)
            {   
                end = end.next.next;
                (start, next, next.next) = (next, next.next, start);
            }

            int result = 0;
            while (next != null)
            {
                result = Math.Max(result, next.val+start.val);
                next = next.next;
                start = start.next;
            }
            return result;
        }
    }
}
