using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem3.LongestStringWithoutRepeatingCharacters
{
    public class Solution1
    {
        //tmmzuxt
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            if (s == " ") return 1;

            Dictionary<char, int> charMap = new Dictionary<char, int>(s.Length);

            int start = 0;
            int current = 0;
            int longest = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!charMap.ContainsKey(s[i]))
                {
                    charMap.Add(s[i], i);
                    current++;
                }
                else 
                {
                    int lastIdx = charMap[s[i]];
                    if (lastIdx >= start) // is in the sliding-window?
                    {
                        start = lastIdx + 1;
                        longest = Math.Max(current, longest);
                        current = i - lastIdx;
                    }
                    else
                    {
                        current++;
                    }

                    charMap[s[i]] = i;
                }
            }
            return Math.Max(current, longest);
        }

        //time complexity O(n)
        //space complexity O(n) 
    }
}
