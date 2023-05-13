using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_2466
    {
        public int CountGoodStrings(int low, int high, int zero, int one)
        {
            int[] dp = new int[high];

            dp[zero - 1]++;
            dp[one - 1]++;

            for (int index = 0; index < high; index++)
            {
                if (index - zero >= 0)
                {
                    dp[index] += dp[index - zero];
                }
                if (index - one >= 0)
                {
                    dp[index] += dp[index - one];
                }
                dp[index] %= 1000000007;
            }

            var result = 0;
            for (int index = low - 1; index < high; index++)
            {
                result += dp[index];
                result %= 1000000007;
            }

            return result;
        }
    }
}
