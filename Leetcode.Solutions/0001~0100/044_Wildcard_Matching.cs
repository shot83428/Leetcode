namespace Leetcode.Solutions
{
    public class Solution_044
    {
        public bool IsMatch(string s, string p)
        {
            bool[,] dp = new bool[s.Length + 1, p.Length + 1];
            s = "+" + s;
            p = "+" + p;
            dp[0, 0] = true;

            for (int index = 1; index < p.Length; index++)
            {
                if (p[index] != '*') break;
                dp[0, index] = true;
            }

            for (int x = 1; x < s.Length; x++)
            {
                for (int y = 1; y < p.Length; y++)
                {
                    if (p[y] == '?')
                        dp[x, y] = dp[x - 1, y - 1];
                    else if (p[y] == '*')
                    {
                        dp[x, y] = dp[x, y - 1] || dp[x - 1, y];
                    }
                    else if (s[x] == p[y])
                    {
                        dp[x, y] = dp[x - 1, y - 1];
                    }
                }
            }
            return dp[s.Length - 1, p.Length - 1];
        }
    }
}
