//https://leetcode.com/problems/two-sum/

namespace LeetCode.TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (dict.TryGetValue(diff, out int value))
                {
                    return new int[] { value, i };
                }
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
