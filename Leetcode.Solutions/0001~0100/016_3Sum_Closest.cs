namespace Leetcode.Solutions
{
    public class Solution_016
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int ans = nums[0] + nums[1] + nums[2];
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    int diff = Math.Abs(sum - target);
                    if (Math.Abs(ans - target) > diff)
                    {
                        ans = sum;
                    }
                    if (sum == target)
                    {
                        return target;
                    }

                    if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return ans;
        }
    }
}
