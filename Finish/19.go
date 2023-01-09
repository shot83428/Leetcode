package leetcode19

//Definition for singly-linked list.
type ListNode struct {
	Val  int
	Next *ListNode
}

func removeNthFromEnd(head *ListNode, n int) *ListNode {
	if head.Next == nil {
		return nil
	}
	_, head = stackList(head, n)
	return head
}

func stackList(node *ListNode, n int) (int, *ListNode) {
	if node == nil {
		return 0, nil
	}
	var renode *ListNode
	val, renode := stackList(node.Next, n)
	val++
	if val == n {
		return val, node.Next
	} else {
		node.Next = renode
		return val, node
	}

}
