namespace Leetcode.Solutions
{
    public class Solution_703
    {
        public class KthLargest
        {
            private int k;
            private int[] nums;

            public KthLargest(int k, int[] nums)
            {
                int[] counts = new int[20001];
                foreach (int val in nums)
                {
                    counts[val + 10000]++;
                }
                this.k = k;
                this.nums = counts;
            }

            public int Add(int val)
            {
                this.nums[val + 10000]++;
                int count = 0;
                for (int index = 20000; index > -1; index--)
                {
                    count += this.nums[index];
                    if (count >= this.k)
                    {
                        count = index - 10000;
                        break;
                    }
                }
                return count;
            }
        }
    }
}
