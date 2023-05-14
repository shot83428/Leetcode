namespace Leetcode.Solutions
{
    internal class Solution_088
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] nums = new int[m];
            Array.Copy(nums1, 0, nums, 0, m);
            Array.Sort(nums);
            Array.Sort(nums2);

            int index = 0, index1 = 0, index2 = 0;
            while (index1 < m && index2 < n)
            {
                if (nums[index1] < nums2[index2])
                {
                    nums1[index++] = nums[index1++];
                }
                else
                {
                    nums1[index++] = nums2[index2++];
                }
            }

            while (index1 < m)
            {
                nums1[index++] = nums[index1++];
            }

            while (index2 < n)
            {
                nums1[index++] = nums2[index2++];
            }
        }

    }
}
