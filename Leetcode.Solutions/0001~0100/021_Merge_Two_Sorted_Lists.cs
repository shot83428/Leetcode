using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_021
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode tmp;
            ListNode new_list = new ListNode(0);
            tmp = new_list;
            while (true)
            {

                if (l1 == null)
                {
                    new_list.next = l2;
                    break;
                }
                else if (l2 == null)
                {
                    new_list.next = l1;
                    break;
                }
                else if (l1.val < l2.val)
                {
                    new_list.next = l1;
                    l1 = l1.next;
                    new_list = new_list.next;
                    new_list.next = null;
                }
                else
                {
                    new_list.next = l2;
                    l2 = l2.next;
                    new_list = new_list.next;
                    new_list.next = null;
                }
            }

            return tmp.next;
        }
    }
}
