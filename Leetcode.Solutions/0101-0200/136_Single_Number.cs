namespace Leetcode.Solutions
{
    public class Solution_136
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0, len = nums.Length;
            while (len > 0)
            {
                len--;
                result ^= nums[len];
            }
            return result;
        }
    }
}
