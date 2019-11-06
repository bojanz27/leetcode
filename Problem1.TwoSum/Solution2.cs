using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Problem1.TwoSum
{
    public class Solution2
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // this is O(n) as it has to touch every element and put into dictionary
            Dictionary<int, int> values = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            { 
                values.TryAdd(nums[i], i); // O(1)
            }
            
            // this is another O(n) traversal
            for (int i = 0; i < nums.Length; i++)
            {
                var value = target - nums[i];
                if (value != nums[i] && values.TryGetValue(value, out int j)) //O(1)
                    return new[] { i, j };
            }

            return new[] { -1, -1 };
        }
    }

    // time complexity is O(n)
    // space complexity O(n)
}
