public class Solution {
    public int MaxProfit(int[] prices)
    {
        int result = 0;

        int min = prices[0];

        for(int index = 1; index < prices.Length; index++)
        {
            min = Math.Min(min, prices[index]);
            result = Math.Max(result, prices[index] - min);
        }
        return result;
    }
}