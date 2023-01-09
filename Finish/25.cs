using System.Collections.Generic;
public class Solution
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        Stack<ListNode> stack = new Stack<ListNode>();
        int index = 0;
        ListNode result = null;
        ListNode bef = null;

        while (head != null)        
        {
            stack.Push(head);
            index++;
            head = head.next;
            if (index % k == 0)
            {
                var reversHead = stack.Pop();
                var tmp = reversHead;
                if (result == null)
                {
                    result = reversHead;
                }
                while (stack.Count > 0)
                {
                    var node = stack.Pop();
                    reversHead.next = node;
                    reversHead = node;
                }
                if (bef != null)
                {
                    bef.next = tmp;
                }
                bef = reversHead;
                bef.next=null;
                index = 0;
            }
        }
        
        ListNode last=null;
        while(stack.Count>0){
            last=stack.Pop();
        }
        bef.next=last;
        return result;
    }
}