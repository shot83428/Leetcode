public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int low = 0, high = -1;
        int[] dp = new int[prices.Length];

        for (int index = 1; index < dp.Length; index++)
        {
            if (prices[index] > prices[index - 1])
            {
                dp[index] = prices[index] - prices[low];
            }
            else
            {
                low = index;
            }
        }
        
    }
}