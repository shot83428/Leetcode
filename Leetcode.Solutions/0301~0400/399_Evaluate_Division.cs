namespace Leetcode.Solutions
{
    public class Solution_399
    {
        private IList<bool> reached = new List<bool>();

        private IList<IList<Tuple<int, double>>> adj;

        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            IDictionary<string, int> strToInt = new Dictionary<string, int>();
            adj = new List<IList<Tuple<int, double>>>();
            int cnt = 0;


            foreach (IList<string> curr in equations)
            {
                if (strToInt.ContainsKey(curr[0]) == false)
                {
                    strToInt.Add(curr[0], cnt++);
                    adj.Add(new List<Tuple<int, double>>());
                    reached.Add(false);
                }

                if (strToInt.ContainsKey(curr[1]) == false)
                {
                    strToInt.Add(curr[1], cnt++);
                    adj.Add(new List<Tuple<int, double>>());
                    reached.Add(false);
                }
            }

            for (int index = 0; index < equations.Count; ++index)
            {
                IList<string> curr = equations[index];

                var edge = new Tuple<int, double>(strToInt[curr[1]], values[index]);
                var edge2 = new Tuple<int, double>(strToInt[curr[0]], 1 / values[index]);

                adj[strToInt[curr[0]]].Add(edge);
                adj[strToInt[curr[1]]].Add(edge2);
            }


            double[] res = new double[queries.Count];
            for (int index = 0; index < queries.Count; ++index)
            {
                IList<string> query = queries[index];
                if (strToInt.ContainsKey(query[0]) == false || strToInt.ContainsKey(query[1]) == false)
                {
                    res[index] = -1.0;
                }
                else
                {
                    int node1 = strToInt[query[0]];
                    int node2 = strToInt[query[1]];

                    res[index] = dfs(node1, node2, 1);
                    for (int i = 0; i < reached.Count; ++i)
                    {
                        reached[i] = false;
                    }
                }
            }


            return res;
        }

        private double dfs(int currNode, int targetNode, double currVal)
        {
            if (currNode == targetNode)
            {
                return currVal;
            }

            reached[currNode] = true;

            double max = -1;
            foreach (Tuple<int, double> curr in adj[currNode])
            {
                if (reached[curr.Item1] == false)
                {
                    max = Math.Max(dfs(curr.Item1, targetNode, currVal * curr.Item2), max);
                }
            }

            return max;
        }
    }
}
