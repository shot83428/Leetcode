namespace Leetcode.Solutions
{
    public class Solution_053
    {
        public int MaxSubArray(int[] nums)
        {
            int L = nums.Length;
            if (L == 1)
            {
                return nums[0];
            }

            return MaxIndex(nums, 0, L / 2 - 1, L - 1);
        }

        public int MaxIndex(int[] nums, int start, int index, int end)
        {
            if (start == end)
            {
                return nums[start];
            }
            int right = nums[index + 1], left = nums[index];
            int tmp = nums[index];
            for (int val = index - 1; val >= start; val--)
            {
                tmp += nums[val];
                if (left < tmp)
                {
                    left = tmp;
                }
            }
            tmp = nums[index + 1];
            for (int val = index + 2; val <= end; val++)
            {
                tmp += nums[val];
                if (right < tmp)
                {
                    right = tmp;
                }
            }
            int res = right + left;
            left = MaxIndex(nums, start, (start + index) / 2, index);
            right = MaxIndex(nums, index + 1, (index + end + 1) / 2, end);
            if (left > right)
            {
                if (left > res)
                {
                    return left;
                }
            }
            else
            {
                if (right > res)
                {
                    return right;
                }
            }
            return res;
        }
    }
}
