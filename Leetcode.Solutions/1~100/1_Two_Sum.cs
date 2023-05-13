namespace Leetcode.Solutions
{
    public class Solution_1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int nums_sit = 0, nums_Length = nums.Length;
            for (int i = 1; i < nums_Length; i++)
            {
                if (nums[nums_sit] + nums[i] == target)
                    return new int[] { nums_sit, i };
                else if (nums_sit < nums_Length && (i + 1) == nums_Length)
                {
                    nums_sit++;
                    i = nums_sit;
                }
            }
            return null;
        }
    }
}
