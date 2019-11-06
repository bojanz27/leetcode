using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem2.AddTwoNumbers
{
    public class ListNode
    {
        public ListNode(int x)
        {
            val = x;
        }

        public int val { get; }
        public ListNode next { get; set; }
    }
}
