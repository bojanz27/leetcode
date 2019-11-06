using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem3.LongestStringWithoutRepeatingCharacters
{
    public class Solution2
    {
        public int LengthOfLongestSubstring(string s)
        {
            int start = 0;
            int longest = 0;
            int current = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int previousPos = GetPreviousPosition(s, start, i, s[i]);
                if (previousPos == -1)
                    current++;
                else 
                {
                    if (current > longest)
                    {
                        longest = current;
                    }
                    start = previousPos + 1;
                    current = i - start + 1;
                }
            }
            if (current > longest)
                longest = current;
            return longest;
        }

        private int GetPreviousPosition(string s, int start, int end, char c)
        {
            for (int i = start; i < end; i++)
            {
                if (s[i] == c)
                    return i;
            }
            return -1;
        }

        // time complexity O(n^2) ?
        // space complexity O(1)
    }
}
