namespace Leetcode.Solutions
{
    public class Solution_139
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {            
            bool[] dp = new bool[s.Length + 1];            
            dp[0] = true;
            
            HashSet<string> set = new HashSet<string>(wordDict);

            for (int i = 1; i < dp.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dp[j] && set.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[s.Length];
        }
    }
}
