namespace Leetcode.Solutions
{
    public class Solution_041
    {
        public int FirstMissingPositive(int[] nums)
        {
            int len = nums.Count();
            int[] counting = new int[len + 1];
            int result = 1;

            for (int index = 0; index < nums.Count(); index++)
            {
                if (nums[index] > 0 && nums[index] <= len)
                {
                    counting[nums[index]] = 1;
                }
                while (result <= len && counting[result] != 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
