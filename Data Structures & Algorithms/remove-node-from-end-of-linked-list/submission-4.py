# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        if not head or not head.next:
            return None
        ptr = s = f = head

        while n > 0:
            f = f.next
            n-=1
        # [1,2,3,4] 1,1 -> 1,2 1 -> 1,3 0 
        # [1,2,3,4] 1,2 -> 2,4 -> 
        while f and f.next:
            s = s.next
            f = f.next
        
        s.next = s.next.next
        return ptr