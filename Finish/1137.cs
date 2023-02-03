public class Solution
{
    public int Tribonacci(int n)
    {
        int[] dp = new int[3] { 0, 1, 1 };
        
        for (int index = 3; index <= n; index++)
        {
            dp[index%3] = dp[0]+dp[1]+dp[2];
        }

        return dp[n%3];
    }
}