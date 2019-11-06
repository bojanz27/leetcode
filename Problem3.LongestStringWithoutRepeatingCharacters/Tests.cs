using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Problem3.LongestStringWithoutRepeatingCharacters
{
    public class Tests
    {

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("dvdf", 3)]
        [InlineData(" ", 1)]
        [InlineData("s fer", 5)]
        [InlineData("abba", 2)]
        [InlineData("tmmzuxt", 5)]
        public void Solution1_FindsTheLongestSubstring(string s, int expected)
        {
            Solution1 solution = new Solution1();
            int actual = solution.LengthOfLongestSubstring(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("dvdf", 3)]
        [InlineData(" ", 1)]
        [InlineData("s fer", 5)]
        [InlineData("tmmzuxt", 5)]
        public void Solution2_FindsTheLongestSubstring(string s, int expected)
        {
            Solution2 solution = new Solution2();
            int actual = solution.LengthOfLongestSubstring(s);
            Assert.Equal(expected, actual);
        }
    }
}
