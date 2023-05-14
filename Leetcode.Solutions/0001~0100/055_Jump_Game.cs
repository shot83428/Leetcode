using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_055
    {
        public static bool CanJump(int[] nums)
        {
            int[] dp = new int[nums.Length + 1];

            for (int index = 1; index <= nums.Length; index++)
            {
                if (index == 1)
                {
                    dp[index] = 1;
                }
                if (dp[index] == 1)
                {
                    for (int walk = index + 1; walk <= index + nums[index - 1] && walk <= nums.Length; walk++)
                    {
                        dp[walk] = 1;
                    }
                }
                if (dp[nums.Length] != 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
