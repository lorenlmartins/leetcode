﻿//https://leetcode.com/problems/add-two-numbers/

namespace LeetCode.AddTwoNumbers
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int val=0, ListNode next=null) {
     *         this.val = val;
     *         this.next = next;
     *     }
     * }
     */
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p1 = l1, p2 = l2, curr = dummyHead;
            int carry = 0;

            while (p1 != null || p2 != null)
            {
                int x = (p1 != null) ? p1.val : 0;
                int y = (p2 != null) ? p2.val : 0;
                int sum = x + y + carry;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p1 != null) p1 = p1.next;
                if (p2 != null) p2 = p2.next;
            }

            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }

            return dummyHead.next;
        }
    }
}
