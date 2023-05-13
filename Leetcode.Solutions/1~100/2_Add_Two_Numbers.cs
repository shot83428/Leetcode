using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{

    public class Solution_2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            ListNode new_list = new ListNode(0);
            ListNode result = new_list;
            int sum = 0;

            while (l1 != null || l2 != null || sum > 0)
            {

                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                new_list.next = new ListNode(sum % 10);
                sum /= 10;
                new_list = new_list.next;
            }

            return result.next;
        }
    }
}
