using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solutions_206
    {
        public class Solution
        {
            public ListNode ReverseList(ListNode head)
            {
                ListNode rev = null, tmp;
                if (head == null) return null;
                while (true)
                {
                    if (rev == null)
                    {
                        rev = head;
                        head = head.next;
                        rev.next = null;
                    }
                    else
                    {
                        tmp = rev;
                        rev = head;
                        head = head.next;
                        rev.next = tmp;
                    }
                    if (head == null) break;
                }
                return rev;

            }
        }
    }
}
