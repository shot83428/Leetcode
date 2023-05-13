namespace Leetcode.Solutions
{
    public class Solution_8
    {
        public int MyAtoi(string s)
        {
            int max = int.MaxValue, min = int.MinValue;
            int ans = 0;
            bool whitespace = true;
            bool index_plus = true;
            bool index = true, index_used = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    if (whitespace)
                        continue;
                    else
                        break;
                }
                else if (s[i] == '-' && index && index_plus)
                {
                    index = false;
                    index_used = true;
                }
                else if (s[i] == '+' && index_plus && index)
                {
                    index_plus = false;
                    whitespace = false;
                }
                else if (s[i] <= '9' && s[i] >= '0')
                {
                    whitespace = false;
                    index = false;
                    if (ans > int.MaxValue / 10)
                    {
                        if (index_used)
                            return min;
                        else
                            return max;
                    }
                    if (ans == int.MaxValue / 10)
                    {
                        if (index_used && s[i] >= '8')
                        {
                            return min;
                        }
                        else if (!index_used && s[i] >= '7')
                        {

                            return max;
                        }
                    }
                    ans = ans * 10+( s[i] - '0');


                }
                else
                    break;

            }
            if (index_used)
                ans *= -1;

            return ans;
        }
    }
}
