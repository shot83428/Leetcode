public class Solution {
    public TreeNode SortedListToBST(ListNode head)
    {
        if (head == null)
            return null;
        if( head.next == null)
            return new TreeNode() { val=head.val ,left=null,right=null};
        ListNode bf = head;
        ListNode tmp = null;
        ListNode af = head.next;
        while (true)
        {
            tmp = bf;
            bf = bf.next;
            int index = 0;
            while(index<2&&af != null)
            {
                af = af.next;
                index++;
            }
            if (af == null)
                break;
        }
        tmp.next = null;

        TreeNode retrunNode = new TreeNode() { val=bf.val,left= SortedListToBST(head), right =SortedListToBST(bf.next) };
        return retrunNode;
    }
}