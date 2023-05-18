namespace Leetcode.Solutions
{
    public class Solution_1557
    {
        //[[1,2],[3,2],[4,1],[3,4],[0,2]]
        public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
        {
            Dictionary<int, List<int>> pairs = new();
            foreach (var edge in edges)
            {
                if (!pairs.ContainsKey(edge[0]))
                {
                    pairs.Add(edge[0], new List<int>());
                }
                pairs[edge[0]].Add(edge[1]);
            }
            
            for(int index=0;index<n;index++)
            {
                if (pairs.TryGetValue(index,out var set))
                {
                    for(int i = 0; i < set.Count;i++)
                    {
                        if (pairs.ContainsKey(set[i]))
                        {
                            pairs[index].AddRange(pairs[set[i]]);
                            pairs.Remove(set[i]);
                        }
                    }
                }
            }
            var result = pairs.Keys.ToList();
            result.Sort();
            return result;
        }
    }
}
