public class Solution {
    public int SearchInsert(int[] nums, int target)
    {
        int index = nums.Length / 2;
        int start = 0, end = nums.Length;
        while (start != end && end != index)
        {
            if (nums[index] < target)
            {
                start = index;
                index = (index + 1 + end) / 2;
            }
            else if (nums[index] > target)
            {
                end = index;
                index = (start + index) / 2;
            }
            else
            {
                break;
            }
        }
        return index;
    }

}