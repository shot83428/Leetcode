public class Solution {
    public int MaxResult(int[] nums, int k)
    {
        //Queue<int> indexs = new Queue<int>();
        List<int> indexs = new List<int>();
        indexs.Add(0);
        int count = 0;
        for (int index = 1; index < nums.Length; index++)
        {
            if (nums[index] >= 0)
            {
                nums[index] += nums[indexs.First()];
                indexs.Clear();
                indexs.Add(index);
            }
            else
            {
                nums[index] += nums[indexs.First()];
                for (int i = indexs.Count - 1; i > 0; i--)
                {
                    if (nums[index] > nums[indexs.Last()])
                    {
                        indexs.RemoveAt(i);
                    }
                    else
                    {
                        break;
                    }
                }

                indexs.Add(index);
            }
            while(indexs.Any())
            {
                if (index-indexs[0]>=k)
                {
                    indexs.RemoveAt(0);
                }
                else
                {
                    break;
                }
            }
        }

        return nums.Last();
    }


}