using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem1.TwoSum
{
    public class Solution3
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int value = target - nums[i];
                if (values.TryGetValue(value, out int j)) // O(1)
                    return new[] { j, i }; // reversed because j occured first in the array
                values.TryAdd(nums[i], i); // O(1)
            }
            return new[] { -1, -1 };
        }
    }

    // time complexity O(n)
    // space complexity O(n)
}
