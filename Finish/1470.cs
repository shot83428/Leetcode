public class Solution {
    public int[] Shuffle(int[] nums, int n)
    {
        Queue<int> xQueue = new Queue<int>();

        for(int i = 1; i < nums.Length; i++)
        {
            xQueue.Enqueue(nums[i]);
            if (i % 2 == 1)
            {
                nums[i] = nums[n + i/2];
            }
            else
            {
                nums[i]=xQueue.Dequeue();
            }
        }

        return nums;
    }
}