public class Solution {
    public int SingleNonDuplicate(int[] nums)
    {
        int start = 0;
        int end = nums.Length - 1;
        int index = end / 2;
        while (start != end)
        {
            if (index > 0 && nums[index - 1] == nums[index])
            {
                if (index % 2 == 1)
                {
                    start = index;
                    index = (start + end + 1) / 2;
                }
                else
                {
                    end = index;
                    index = (start + end) / 2;
                }
            }
            else if (index < nums.Length - 1 && nums[index + 1] == nums[index])
            {
                if (index % 2 == 1)
                {
                    end = index;
                    index = (start + end -1) / 2;
                }
                else
                {
                    start = index;
                    index = (start + end) / 2;
                }
            }
            else
            {
                break;
            }
        }
        return nums[index];
    }
}