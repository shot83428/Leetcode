namespace Leetcode.Solutions
{
    public class Solution_4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int len_nums1 = nums1.Length, len_nums2 = nums2.Length;
            int len = len_nums1 + len_nums2;
            int count = 0, num1_i = 0, num2_i = 0;
            int[] merge_ar = new int[len];

            while (count < len)
            {
                if ((num2_i >= len_nums2) || ((num1_i < len_nums1) && (nums1[num1_i] < nums2[num2_i])))
                {
                    merge_ar[count] = nums1[num1_i];
                    num1_i++;
                }
                else
                {
                    merge_ar[count] = nums2[num2_i];
                    num2_i++;
                }
                count++;
            }

            if ((len % 2) == 0)
            {
                Console.WriteLine(merge_ar[len / 2]);
                return (merge_ar[len / 2] + merge_ar[len / 2 - 1]) * 1.0 / 2;

            }
            else
                return merge_ar[len / 2];
        }
    }
}
