using Leetcode.Solutions.Models;

namespace Leetcode.Solutions
{
    public class Solution_160
    {
        private class Stack
        {
            public ListNode Node;
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            Stack[] stackA = null;
            Stack[] stackB = null;

            while (headA != null || headB != null)
            {
                if (headA != null)
                {
                    Stack newStack = new Stack { Node = null };
                    newStack.Node = headA;
                    if (stackA == null)
                        stackA = new Stack[] { newStack };
                    else
                        stackA = stackA.Append(newStack).ToArray();
                    headA = headA.next;
                }

                if (headB != null)
                {
                    Stack newStack = new Stack { Node = null };
                    newStack.Node = headB;
                    if (stackB == null)
                        stackB = new Stack[] { newStack };
                    else
                        stackB = stackB.Append(newStack).ToArray();
                    headB = headB.next;
                }
            }

            ListNode node = null;
            for (int indexA = stackA.Length - 1, indexB = stackB.Length - 1; indexA >= 0 && indexB >= 0; indexA--, indexB--)
            {
                if (stackA[indexA].Node == stackB[indexB].Node)
                    node = stackA[indexA].Node;
            }

            return node;
        }
    }
}
