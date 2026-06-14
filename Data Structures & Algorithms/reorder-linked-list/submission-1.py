# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def reorderList(self, head: Optional[ListNode]) -> None:
        def reverse(node):
            prev = None
            while node:
                nextNode = node.next
                node.next = prev
                prev = node
                node = nextNode
            return prev
        
        def getMiddleNode(node):
            slow, fast = node, node.next
            while fast and fast.next:
                slow = slow.next
                fast = fast.next.next
            return slow
        
        if not head or not head.next or not head.next.next:
            return
        
        middle = getMiddleNode(head)
        second = middle.next
        middle.next = None  # split the list
        second = reverse(second)

        first = head
        while second:
            tmp1, tmp2 = first.next, second.next
            first.next = second
            second.next = tmp1
            first, second = tmp1, tmp2
