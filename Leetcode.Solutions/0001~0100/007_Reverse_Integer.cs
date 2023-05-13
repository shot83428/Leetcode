namespace Leetcode.Solutions
{
    public class Solution_7
    {
        public int Reverse(int x)
        {
            int num = 0;
            while (x != 0)
            {

                try
                {
                    num = checked(num * 10);
                    num = checked(num + x % 10);
                }
                catch (System.OverflowException)
                {
                    return 0;
                }

                x /= 10;
            }
            return num;
        }
    }
}
