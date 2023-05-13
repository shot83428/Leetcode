namespace Leetcode.Solutions
{
    public class Solution_6
    {
        public string Convert(string s, int numRows)
        {
            char[][] ans = new char[numRows][];

            for(int i = 0; i < numRows; i++)
            {
                ans[i] = new char[s.Length];
            }

            int x = 0, y = 0;
            string str = string.Empty;
            bool index = true;
            if (numRows == 1)
                return s;
            for (int i = 0; i < s.Length; i++)
            {
                ans[x][y] = s[i];

                if (x < (numRows - 1) && index)
                {
                    x++;
                }
                else if (x == (numRows - 1))
                {
                    x--;
                    y++;
                    if (x == 0)
                        index = true;
                    else
                        index = false;
                }
                else if (index == false)
                {
                    x--;
                    y++;
                    if (x == 0)
                        index = true;
                }
            }
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < s.Length; j++)
                    if (ans[i][j] == 0)
                        continue;
                    else
                        str += ans[i][j];
            }

            return str;
        }
    }
}
