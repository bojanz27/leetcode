namespace LeetCode.Problem1.TwoSum
{
    //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //Example:
    //Given nums = [2, 7, 11, 15], target = 9,
    //Because nums[0] + nums[1] = 2 + 7 = 9,
    //return [0, 1].

    public class Solution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int value = target - nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (value == nums[j])
                        return new int[] { i, j };
                }
            }
            return new[] { -1, -1 };
        }
    }

    // time complexity O(n^2)
    // space complexity O(1)
}
