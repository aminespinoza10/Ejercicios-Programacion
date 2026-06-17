from typing import Optional

# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def addTwoNumbers(self, l1: Optional["ListNode"], l2: Optional["ListNode"]) -> Optional["ListNode"]:
        s1 = ""
        s2 = ""

        while l1:
            s1 = str(l1.val) + s1
            l1 = l1.next

        while l2:
            s2 = str(l2.val) + s2
            l2 = l2.next

        n1 = int(s1) if s1 else 0
        n2 = int(s2) if s2 else 0
        total = n1 + n2

        # Build result list in reverse order
        dummy = ListNode(0)
        cur = dummy

        if total == 0:
            return ListNode(0)

        for ch in str(total)[::-1]:
            cur.next = ListNode(int(ch))
            cur = cur.next

        return dummy.next