namespace Leetcode.Solutions
{
    public class Solution_075
    {
        public void SortColors(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                if (nums[left] != 2)
                {
                    left++;
                }
                else if (nums[right] == 2)
                {
                    right--;
                }
                else
                {
                    (nums[left], nums[right]) = (nums[right], nums[left]);
                }
            }
            left = 0;
            while (left <= right)
            {
                if (nums[left] != 1)
                {
                    left++;
                }
                else if (nums[right] == 1)
                {
                    right--;
                }
                else
                {
                    (nums[left], nums[right]) = (nums[right], nums[left]);
                }
            }
        }
    }
}
