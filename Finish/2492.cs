public class Solution {
    public int MinScore(int n, int[][] roads)
    {
        for(int index = 0; index < roads.Length; index++)
        {
            if (roads[index][0] > roads[index][1])
            {
                (roads[index][0], roads[index][1]) = (roads[index][1], roads[index][0]);
            }
        }
        roads = roads.OrderBy(x => x[0]).ToArray();
        HashSet<int> indexs = new HashSet<int>() { };
        HashSet<int> vals = new HashSet<int>() { 1 };
        int ans = int.MaxValue;
        int count = 0;
        do
        {
            count = indexs.Count;
            for (int index = 0; index < roads.Length; index++)
            {
                if (indexs.Contains(index))
                    continue;
                if (!vals.Contains(roads[index][0]) && !vals.Contains(roads[index][1]))
                    continue;

                if (vals.Contains(roads[index][0]))
                {
                    vals.Add(roads[index][1]);

                }
                else if (vals.Contains(roads[index][1]))
                {
                    vals.Add(roads[index][0]);

                }
                indexs.Add(index);
                ans = Math.Min(ans, roads[index][2]);
            }
        } while (count != indexs.Count);

        return ans;
    }
}