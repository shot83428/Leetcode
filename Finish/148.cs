public class Solution {
    public ListNode SortList(ListNode head)
    {
        if(head==null)
            return head;
        List<ListNode> list = new List<ListNode>();
        while (head is not null)
        {
            list.Add(head);
            head = head.next;
        }

        list = list.OrderBy(o => o.val).ToList();
        for (int index = 1; index < list.Count(); index++)
        {
            list[index-1].next=list[index];
            list[index].next=null;
        }

        return list[0];
    }
}