namespace Leetcode.Solutions
{
    public class Solution_032
    {
        public int LongestValidParentheses(string s)
        {
            int max = 0;
            int[] checks = new int[s.Length];
            for (int index = 0; index < s.Length; index++)
            {
                checks[index] = -1;
            }
            Stack<int> sta = new Stack<int>();
            for (int index = 0; index < s.Length; index++)
            {
                if (s[index] == '(')
                {
                    sta.Push(index);
                }
                else
                {
                    if (sta.Count > 0)
                    {
                        int font = sta.Peek();
                        while (font - 1 >= 0 && checks[font - 1] >= 0)
                        {
                            font = checks[font - 1];
                        }

                        if (max < index - font + 1)
                        {
                            max = index - font + 1;
                        }
                        checks[index] = font;
                        sta.Pop();
                    }
                }
            }

            return max;
        }
    }
}
