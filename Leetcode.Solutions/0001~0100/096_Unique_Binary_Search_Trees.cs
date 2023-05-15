namespace Leetcode.Solutions
{
    public class Solution_096
    {
        public int NumTrees(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;
            for (int index = 2; index <= n; index++)
            {
                for (int i = index - 1, j = 0; i >= 0; i--, j++)
                {
                    dp[index] += dp[i] * dp[j];
                }
            }
            return dp[n];
        }
    }
}
