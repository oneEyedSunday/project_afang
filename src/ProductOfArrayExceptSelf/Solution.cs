using System;

namespace ProductOfArrayExceptSelf
{
    public class Solution
    {
        public Solution()
        {
        }

        public int[] ProductExceptSelf(int[] nums)
        {
            int[] solution = new int[nums.Length];

            if (nums.Length == 0)
                return Array.Empty<int>();

            solution[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                solution[i] = solution[i - 1] * nums[i - 1];
            }
            int right = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                solution[i] *= right;
                right *= nums[i];
            }

            return solution;
        }
    }
}