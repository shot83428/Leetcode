public class Solution {
    public long ZeroFilledSubarray(int[] nums)
    {
        long count = 0;
        long ans = 0;
        for(int index = 0; index < nums.Length; index++)
        {
            if (nums[index] == 0)
            {
                count++;
                ans += count;
            }
            else
            {
                count = 0;
            }
        }
        return ans;
    }
}