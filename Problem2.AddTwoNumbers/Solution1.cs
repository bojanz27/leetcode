using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem2.AddTwoNumbers
{
    class Solution1
    {
        /*
         * Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
         * Output: 7 -> 0 -> 8
         * Explanation: 342 + 465 = 807.
         */

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode start = new ListNode(0);
            ListNode current = start;
            int carry = 0;
            while (l1 != null || l2 != null || carry > 0)
            {
                int val1 = l1?.val ?? 0;   
                int val2 = l2?.val ?? 0;

                int sum = val1 + val2 + carry;
                int val = sum % 10;
                carry = sum / 10;

                current.next = new ListNode(val);
                current = current.next;

                l1 = l1?.next;
                l2 = l2?.next;
            }
            return start.next;
        }

        // Time complexity O(n) where n = max(l1.length, l2.lenght)
        // space complexity O(n) where n = max(l1.length, l2.lenght)
    }
}
