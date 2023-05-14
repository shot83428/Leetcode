namespace Leetcode.Solutions
{
    public class Solution_069
    {
        public int MySqrt(int x)
        {
            int val = 1;
            while (val * val <= x)
            {
                val++;
            }
            return val - 1;
        }

    }
}
