public class Solution {
    public int SplitArray(int[] nums, int k)
    {
        int left = 1;
        int right = 0;
        foreach (var num in nums)
        {
            right += num;
        }

        int result = int.MaxValue;

        while (left < right - 1)
        {
            var curr = (left + right + 1) / 2;
            if (isFeat(nums, curr, k))
            {
                right = curr;
                result = Math.Min(result, curr);
            }
            else
            {
                left = curr;
            }
        }
        return right;
    }
    
    private bool isFeat(int[] nums,int total,int k)
    {
        int w = 0;
        foreach(var num in nums)
        {
            if (w > total)
                return false;
            if (w + num <= total)
            {
                w += num;
            }
            else
            {
                w = num;
                if (w > total)
                    return false;
                k--;
            }
        }
        if (k > 0)
            return true;
        else return false;
    }
}