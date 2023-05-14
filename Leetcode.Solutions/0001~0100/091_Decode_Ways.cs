namespace Leetcode.Solutions
{
    public class Solution_091
    {
        public int NumDecodings(string s)
        {
            int[] dp = new int[s.Length];

            if (s[0] != '0')
            {
                dp[0] = 1;
            }

            if (s.Length > 1)
            {
                int i = int.Parse(s.Substring(0, 2));
                if (s[1] == '0')
                {
                    if (i > 26)
                    {
                        return 0;
                    }
                    dp[1] = dp[0];
                }
                else if (i <= 26 && i > 10)
                {
                    dp[1] = 2;
                }
                else
                {
                    dp[1] = dp[0];
                }
            }

            for (int i = 2; i < s.Length; i++)
            {
                int num = int.Parse(s.Substring(i - 1, 2));
                if (num == 0 || (s.Length == i + 1 && s[i] == '0' && num > 26))
                {
                    return 0;
                }

                if (s[i] == '0')
                {
                    if (num > 26)
                    {
                        return 0;
                    }
                    dp[i] = dp[i - 2];
                }
                else if (s[i - 1] == '0')
                {
                    dp[i] = dp[i - 1];
                }
                else
                {
                    if (num > 26)
                    {
                        dp[i] = dp[i - 1];
                    }
                    else
                    {
                        dp[i] = dp[i - 1] + dp[i - 2];
                    }
                }
            }

            return dp[s.Length - 1];
        }

    }
}
