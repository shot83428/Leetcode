public class Solution
{
    public int BestTeamScore(int[] scores, int[] ages)
    {
        List<(int, int)> sortMember = new List<(int, int)>();
        for (int index = 0; index < scores.Length; index++)
        {
            sortMember.Add((ages[index], scores[index]));
        }
        sortMember = sortMember.OrderBy(x => x.Item2).OrderBy(x => x.Item1).ToList();

        int max = 0;
        int[] dp = new int[scores.Length];
        for (int index = 0; index < scores.Length; index++)
        {
            dp[index] = sortMember.ElementAt(index).Item2;
            for (int back = 0; back < index; back++)
            {
                if (sortMember.ElementAt(index).Item2 >= sortMember.ElementAt(back).Item2)
                {
                    dp[index] = Math.Max(dp[index], dp[back] + sortMember.ElementAt(index).Item2);
                }
            }
            max = Math.Max(max, dp[index]);
        }

        return max;
    }
}