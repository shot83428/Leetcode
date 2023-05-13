namespace Leetcode.Solutions
{
    public class Solution_9
    {
        public bool IsPalindrome(int x)
        {
            int num = 0, tmp = x;

            while (x != 0)
            {

                try
                {
                    num = checked(num * 10);
                    num = checked(num + x % 10);
                }
                catch (System.OverflowException)
                {
                    return false;
                }

                x /= 10;
            }
            if (tmp < 0) ;
            else if (tmp == num)
                return true;
            return false;
        }
    }
}
