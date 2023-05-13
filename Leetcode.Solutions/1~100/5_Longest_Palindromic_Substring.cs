namespace Leetcode.Solutions
{
    public class Solution_5
    {
        public string LongestPalindrome(string s)
        {
            var result = string.Empty;


            for (int index = 0; index < s.Length; index++)
            {
                for (int shift = 0; index - shift >= 0 && index + shift < s.Length; shift++)
                {
                    if (s[index + shift] == s[index - shift])
                    {
                        if (result.Length < shift * 2 + 1)
                        {
                            result = s.Substring(index - shift, index + shift + 1 - (index - shift));

                        }
                    }
                    else
                    {
                        break;

                    }
                }
                for (int shift = 0; index - shift - 1 >= 0 && index + shift < s.Length; shift++)
                {
                    if (s[index + shift] == s[index - 1 - shift])
                    {
                        if (result.Length < shift * 2 + 2)
                        {
                            result = s.Substring(index - shift - 1, index + shift + 1 - (index - shift - 1));
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return result;
        }
    }
}
