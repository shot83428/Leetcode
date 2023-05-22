namespace Leetcode.Solutions
{
    public class Solution_191
    {
        public int HammingWeight(uint num)
        {
            int count = 0;
            for (int val = 0; val < 32; val++)
            {
                if (((num >> val) & 1) == 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
