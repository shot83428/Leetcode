using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_026
    {
        public int RemoveDuplicates(int[] nums)
        {
            int len = nums.Length;

            if (len == 0) return 0;

            int i = 0;

            for (int j = 1; j < len; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
    }
}
