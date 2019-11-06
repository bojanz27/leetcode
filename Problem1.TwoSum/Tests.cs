using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Problem1.TwoSum
{
    public class Tests
    {
        [Theory]
        [InlineData(new int[] {2, 7, 11, 15}, 9, new[] {0, 1})]
        [InlineData(new int[] {2, 7, 11, 15}, 18, new[] { 1, 2 })]
        [InlineData(new int[] {2, 7, 11, 15}, 26, new[] { 2, 3 })]
        [InlineData(new int[] {2, 7, 11, 15}, 17, new[] { 0, 3 })]
        [InlineData(new int[] {2, 7, 11, 15}, 22, new[] { 1, 3 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 14, new[] { -1, -1 })]
        public void Solution1_Tests(int[] nums, int target, int[] expected)
        {
            Solution1 solution = new Solution1();
            var actual = solution.TwoSum(nums, target);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 18, new[] { 1, 2 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 26, new[] { 2, 3 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 17, new[] { 0, 3 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 22, new[] { 1, 3 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 14, new[] { -1, -1 })]
        public void Solution2_Tests(int[] nums, int target, int[] expected)
        {
            Solution2 solution = new Solution2();
            var actual = solution.TwoSum(nums, target);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 18, new[] { 1, 2 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 26, new[] { 2, 3 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 17, new[] { 0, 3 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 22, new[] { 1, 3 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 14, new[] { -1, -1 })]
        public void Solution3_Tests(int[] nums, int target, int[] expected)
        {
            Solution3 solution = new Solution3();
            var actual = solution.TwoSum(nums, target);
            Assert.Equal(expected, actual);
        }
    }
}
