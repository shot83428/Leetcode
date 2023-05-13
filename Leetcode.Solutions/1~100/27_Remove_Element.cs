using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int index = nums.Length - 1;
            for (int j = 0; j < index; j++)
            {
                if (nums[j] == val)
                {
                    (nums[j], nums[index]) = (nums[index], nums[j]);
                    j--;
                    index--;
                }
            }
            if (nums.Length != 0 && nums[index] == val)
            {
                return index;
            }
            return index + 1;
        }
    }
}
