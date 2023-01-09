using System.Linq;
public class Solution
{
    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        if (source == destination)
            return true;
        if (n <= 1)
        {
            return false;
        }
        bool bo = false;

        for (int i = 0; i < edges.Length && !bo; i++)
        {
            if (edges[i][0] == source)
            {
                // List<int[]> newedges = edges.ToList();
                // newedges.RemoveAt(i);
                var neweg = edges.Where((e,index)=>index!=i).ToArray();
                bo |= ValidPath(n - 1, neweg, edges[i][1], destination);
            }
            else if (edges[i][1] == source)
            {
                // List<int[]> newedges = edges.ToList();
                // newedges.RemoveAt(i);
                var neweg = edges.Where((e,index)=>index!=i).ToArray();
                bo |= ValidPath(n - 1, neweg.ToArray(), edges[i][0], destination);
            }
        }
        return bo;
    }
}

public class Solution {
    public bool ValidPath(int n, int[][] edges, int start, int end) {
        
        List<int>[] graph = new List<int>[n];
        for(int i = 0; i < n; i++)
            graph[i] = new List<int>();
        
        foreach(var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
        
        bool[] visited = new bool[n];
        if(dfs(graph, start, end, visited))
            return true;
        
        return false;
    }
    
    private bool dfs(List<int>[] graph, int start, int end, bool[] visited)
    {
        if(start == end)
            return true;
        
        visited[start] = true;
        foreach(var next in graph[start])
        {
            if(!visited[next])
            {
                if(dfs(graph, next, end, visited))
                    return true;
            }      
        }
        
        return false;
    }
}