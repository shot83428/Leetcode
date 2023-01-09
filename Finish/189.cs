public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        if (k == 0)
            return;
        k %= nums.Length;

        reverse(nums, 0, nums.Length);
        reverse(nums, 0, k);
        reverse(nums, k, nums.Length);

    }
    public void reverse(int[] nums, int start, int end)
    {
        for (int index = start; index < (start + end) / 2; index++)
        {
            (nums[index], nums[end - 1 - (index - start)]) = (nums[end - 1 - (index - start)], nums[index]);
        }
    }
}