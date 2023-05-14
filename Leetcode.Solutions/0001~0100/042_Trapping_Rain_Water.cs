namespace Leetcode.Solutions
{
    public class Solution_042
    {
        //[0,1,0,2,1,0,1,3,2,1,2,1]
        //6
        public int Trap(int[] height)
        {
            int[] dp = new int[height.Length];
            int[] ints = new int[height.Length];
            ints[0] = height[0];
            int result = 0;

            for (int index = 1; index < height.Length; index++)
            {
                if (height[index] < ints[index - 1])
                {
                    dp[index] = ints[index - 1] - height[index];
                    ints[index] = ints[index - 1];
                }
                else
                {
                    ints[index] = height[index];
                }
            }

            ints = new int[height.Length];
            ints[ints.Length - 1] = height.Last();
            dp[dp.Length - 1] = 0;
            for (int index = height.Length - 2; index >= 0; index--)
            {
                if (height[index] < ints[index + 1])
                {
                    dp[index] = Math.Min(ints[index + 1] - height[index], dp[index]);
                    ints[index] = ints[index + 1];
                }
                else
                {
                    ints[index] = height[index];
                    dp[index] = 0;
                }
            }

            foreach (var val in dp)
            {
                result += val;
            }

            return result;
        }
    }
}
