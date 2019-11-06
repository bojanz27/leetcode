using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Problem2.AddTwoNumbers
{
    public class Tests
    {
        [Fact]
        public void Solution1_CalculatesResult_NoCarry()
        {
            ListNode list1 = MakeList(2, 4, 3);
            ListNode list2 = MakeList(5, 6, 4);

            Solution1 solution = new Solution1();
            ListNode result = solution.AddTwoNumbers(list1, list2);

            // 7 -> 0 -> 8

            AssertEqual(result, 7, 0, 8);
        }

        [Fact]
        public void Solution1_CalculatesResult_WithCarry_On_InnerPosition()
        {
            ListNode list1 = MakeList(5, 4, 3);
            ListNode list2 = MakeList(5, 6, 4);

            Solution1 solution = new Solution1();
            ListNode result = solution.AddTwoNumbers(list1, list2);

            AssertEqual(result, 0, 1, 8);
        }

        [Fact]
        public void Solution1_CalculatesResult_WithCarry_From_TopPosition()
        {
            ListNode list1 = MakeList(5, 4, 3);
            ListNode list2 = MakeList(9, 6, 7);

            Solution1 solution = new Solution1();
            ListNode result = solution.AddTwoNumbers(list1, list2);

            AssertEqual(result, 4, 1, 1, 1);
        }

        private ListNode MakeList(params int[] elements)
        {
            ListNode start = new ListNode(elements[0]);
            ListNode current = start;
            for (int i = 1; i < elements.Length; i++)
            {
                current.next = new ListNode(elements[i]);
                current = current.next;
            }
            return start;
        }

        private void AssertEqual(ListNode list, params int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                Assert.NotNull(list);
                Assert.Equal(list.val, elements[i]);
                list = list.next;
            }
        }
    }
}
