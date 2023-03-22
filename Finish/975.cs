public class Solution {
    public int OddEvenJumps(int[] arr)
    {
        int[,] dp = new int[arr.Length, 2];
        int ans = 1;
        dp[arr.Length - 1, 0] = 1;
        dp[arr.Length - 1, 1] = 1;

        List<int> lists = new List<int>();
        List<int> listh = new List<int>();
        lists.Add(arr.Length - 1);
        listh.Add(arr.Length - 1);

        for (int index = arr.Length - 2; index >= 0; index--)
        {
            int start = 0; int end = lists.Count - 1;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (arr[lists[mid]] >= arr[index])
                {
                    end = mid;
                }
                else
                {
                    start = mid + 1;
                }
            }

            if (arr[lists[start]] >= arr[index])
            {
                dp[index, 1] = dp[lists[start], 0];
                ans+= dp[index, 1];
                lists.Insert(start, index);
            }
            else
            {
                lists.Add(index);
            }

            start = 0; end = listh.Count - 1;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (arr[listh[mid]] <= arr[index])
                {
                    end = mid;
                }
                else
                {
                    start = mid + 1;
                }
            }

            if (arr[listh[start]] <= arr[index])
            {
                dp[index, 0] = dp[listh[start], 1];
                listh.Insert(start, index);
            }
            else
            {
                listh.Add(index);
            }

        }


        return ans;
    }
}
