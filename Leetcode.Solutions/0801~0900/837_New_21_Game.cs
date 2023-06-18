using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_837
    {
        public double New21Game(int n, int k, int maxPts)
        {
            if (k == 0 || n >= k + maxPts)
                return 1.0;

            double sum = 1.0;
            double probability = 0.0;

            double[] dp = new double[n + 1];
            dp[0] = 1.0;

            for (int i = 1; i <= n; i++)
            {
                dp[i] = sum / maxPts;

                if (i < k)
                {
                    sum += dp[i];
                }
                else
                {
                    probability += dp[i];
                }

                if (i >= maxPts)
                {
                    sum -= dp[i - maxPts];
                }
            }

            return probability;
        }
    }
}
