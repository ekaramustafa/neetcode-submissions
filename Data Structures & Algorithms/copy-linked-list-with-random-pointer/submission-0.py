"""
# Definition for a Node.
class Node:
    def __init__(self, x: int, next: 'Node' = None, random: 'Node' = None):
        self.val = int(x)
        self.next = next
        self.random = random
"""

class Solution:
    def copyRandomList(self, head: 'Optional[Node]') -> 'Optional[Node]':
        if not head: 
            return None
        res = ptr = res2 = Node(0)
        memo = {}
        orgHead = head
        while head:
            res.val = head.val
            if head not in memo and head:
                memo[head] = res
            if head.next:
                res.next = Node(0)
            res = res.next
            head = head.next
        
        while orgHead:
            if orgHead.random:
                newRef = memo[orgHead.random]
                ptr.random = newRef
            else:
                ptr.random = None
            
            orgHead = orgHead.next
            ptr = ptr.next
        
        return res2


