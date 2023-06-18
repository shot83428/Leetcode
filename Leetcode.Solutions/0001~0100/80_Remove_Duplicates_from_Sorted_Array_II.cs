namespace Leetcode.Solutions
{
    public class Solution_80
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 2)
            {
                return nums.Length;
            }
            int first = 0, second = 1;
            for (int index = 2; index < nums.Length; index++)
            {
                if (nums[index] == nums[second] && nums[first] == nums[second])
                    continue;
                first = second;
                nums[second + 1] = nums[index];
                second++;

            }
            return second + 1;
        }
    }
}
