namespace Leetcode.Solutions
{
    public class Solution_015
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();
            Array.Sort(nums);
            int[][] counting = new int[2][];
            if (nums[nums.Length - 1] >= 0)
            {
                counting[0] = new int[100001];
            }
            if (nums[0] < 0)
            {
                counting[1] = new int[100001];
            }

            for (int index = 0; index < nums.Length; index++)
            {
                if (nums[index] < 0)
                {
                    counting[1][-1 * nums[index]]++;
                }
                else
                {
                    counting[0][nums[index]]++;
                }
            }

            for (int left = 0, right = nums.Length - 1; left < nums.Length - 2; right--)
            {
                if (nums[left] > 0)
                {
                    break;
                }

                if (left == right - 1 || nums[right] < 0)
                {
                    left++;
                    right = nums.Length;
                    continue;
                }
                if (left > 0 && nums[left - 1] == nums[left])
                {
                    left++;
                    right = nums.Length;
                    continue;
                }
                if (right < nums.Length - 1 && nums[right] == nums[right + 1])
                {
                    continue;
                }

                if (nums[left] == 0)
                {
                    counting[0][0]--;
                }
                else
                {
                    counting[1][-1 * nums[left]]--;
                }
                counting[0][nums[right]]--;

                int index = nums[left] + nums[right];
                if (-1 * index >= nums[left] && -1 * index <= nums[right])
                {
                    if (index > 0 && counting[1][index] > 0)
                    {
                        List<int> tmp = new List<int>() { nums[left], -1 * index, nums[right] };
                        res.Add(tmp);
                    }
                    else if (index <= 0 && counting[0][index * -1] > 0)
                    {
                        List<int> tmp = new List<int>() { nums[left], -1 * index, nums[right] };
                        res.Add(tmp);
                    }
                }

                if (nums[left] == 0)
                {
                    counting[0][0]++;
                }
                else
                {
                    counting[1][-1 * nums[left]]++;
                }
                counting[0][nums[right]]++;
            }

            return res;
        }
    }
}
