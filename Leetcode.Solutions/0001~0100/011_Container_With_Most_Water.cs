namespace Leetcode.Solutions
{
    public class Solution_11
    {
        public int MaxArea(int[] height)
        {
            var left = 0;
            var right = height.Length - 1;
            var res = 0;
            while (left != right)
            {
                var val = 0;
                if (height[left] < height[right])
                {
                    val = height[left] * (right - left);

                    left++;
                }
                else
                {
                    val = height[right] * (right - left);

                    right--;

                }
                if (val > res)
                {
                    res = val;
                }
            }

            return res;
        }
    }
}
