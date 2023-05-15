namespace Leetcode.Solutions
{
    public class Solution_031
    {
        public void NextPermutation(int[] nums)
        {        
            int[] count = new int[101];
            int index = nums.Length - 1;
            int index_bef = -1;
            while (index > 0)
            {
                count[nums[index]]++;
                if (nums[index] > nums[index - 1])
                {
                    index--;
                    index_bef = nums[index];
                    break;
                }
                index--;
            }
            if (index_bef != -1)
            {
                for (int index_c = index_bef + 1; index_c < 101; index_c++)
                {
                    if (count[index_c] != 0)
                    {
                        count[index_bef]++;
                        count[index_c]--;
                        nums[index] = index_c;
                        index++;
                        break;
                    }
                }
            }
            else
            {
                count[nums[0]]++;
            }
            for (int index_c = 0; index_c < 101; index_c++)
            {
                while (index < nums.Length)
                {
                    if (count[index_c] > 0)
                    {
                        nums[index] = index_c;
                        count[index_c]--;
                    }
                    else
                    {
                        break;
                    }
                    index++;
                }
            }
        }

    }
}
