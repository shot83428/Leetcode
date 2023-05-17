namespace Leetcode.Solutions
{
    public class Solution_122
    {
        public int MaxProfit(int[] prices)
        {
            int total = 0;
            int index = prices[0];
            for (int count = 1; count < prices.Length; count++)
            {
                if (prices[count - 1] > prices[count])
                {
                    total = total + prices[count - 1] - index;
                    index = prices[count];
                }
            }
            if (prices[prices.Length - 1] > index)
                total = total + prices[prices.Length - 1] - index;
            return total;
        }
    }
}
