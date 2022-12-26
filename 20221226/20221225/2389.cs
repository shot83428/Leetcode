public class Solution
{
    public int[] AnswerQueries(int[] nums, int[] queries)
    {
        int[] result = new int[queries.Length];
        int max = queries.OrderByDescending(o => o).ToArray()[0];
        Dictionary<int, int> bfs = new Dictionary<int, int>();
        bfs.Add(0, 0);

        for (int index = 0; index < nums.Length; index++)
        {
            Dictionary<int, int> tmp = new Dictionary<int, int>();

            foreach (var list in bfs)
            {
                if (max >= list.Key + nums[index])
                {
                    if (tmp.ContainsKey(list.Key + nums[index]))
                        tmp[list.Key + nums[index]] = Math.Max(list.Value + 1, tmp[list.Key + nums[index]]);
                    else
                        tmp.Add(list.Key + nums[index], list.Value + 1);
                }
            }

            foreach (var item in tmp)
            {
                if (bfs.ContainsKey(item.Key))
                {
                    bfs[item.Key] = Math.Max(item.Value, bfs[item.Key]);
                }
                else
                {
                    bfs.Add(item.Key, item.Value);
                }
            }
        }

        for (int index = 0; index < queries.Length; index++)
        {
            foreach (var list in bfs)
            {
                if (list.Key <= queries[index])
                {
                    result[index] = Math.Max(result[index], list.Value);
                }
            }
        }

        return result;
    }
}

public class Solution
{
    public int[] AnswerQueries(int[] nums, int[] queries)
    {
        int m = queries.Length;
        Array.Sort(nums);
        int[] res = new int[m];

        for (int i = 0; i < m; i++)
        {
            int sum = 0;
            int j = 0;
            for (; j < nums.Length; j++)
            {
                sum += nums[j];
                if (sum > query){
                    break;
                }
            }

            res[i] = j;
        }

        return res;
    }
}

