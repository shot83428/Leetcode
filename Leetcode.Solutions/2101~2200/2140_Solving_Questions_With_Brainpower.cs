namespace Leetcode.Solutions
{
    public class Solition_2140
    {
        //Test Case:
        //[[3,2],[4,3],[4,4],[2,5]]
        //[[1,1],[2,2],[3,3],[4,4],[5,5]]
        //[[21,5],[92,3],[74,2],[39,4],[58,2],[5,5],[49,4],[65,3]]
        public long MostPoints(int[][] questions)
        {
            long[] dp = new long[questions.Length];
            long max = 0;
            for (int index = 0; index < questions.Length; index++)
            {
                long val = questions[index][0];
                if (index > 0)
                {
                    val += dp[index - 1];
                }

                if (index + questions[index][1] < dp.Length)
                {
                    dp[index + questions[index][1]] = Math.Max(val, dp[index + questions[index][1]]);
                }

                if (index > 0)
                    dp[index] = Math.Max(dp[index - 1], dp[index]);

                max = Math.Max(val, max);
            }
            return max;
        }
    }
}
