using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_934
    {
        private int[][] path = new int[4][] {
        new int[] { 1, 0 }
        , new int[] { -1, 0 }
        , new int[] { 0,1 }
        , new int[] { 0, -1 } };
        public int ShortestBridge(int[][] grid)
        {
            (int x, int y) = FindIsland(grid);
            var bfs = GetWatch(grid, x, y);
            int n = grid.Length;

            while (bfs.TryDequeue(out var item))
            {
                foreach (var way in path)
                {
                    if (!IsInGrid(item.Item1 + way[0], item.Item2 + way[1], n))
                    {
                        continue;
                    }
                    if (grid[item.Item1 + way[0]][item.Item2 + way[1]] == 0)
                    {
                        grid[item.Item1 + way[0]][item.Item2 + way[1]] = grid[item.Item1][item.Item2] - 1;
                        bfs.Enqueue((item.Item1 + way[0], item.Item2 + way[1]));
                    }
                    else if (grid[item.Item1 + way[0]][item.Item2 + way[1]] == 1)
                    {
                        return grid[item.Item1][item.Item2] * -1;
                    }
                }
            }
            return 0;
        }

        private (int, int) FindIsland(int[][] grid)
        {
            int x;
            int y;
            int n = grid.Length;
            for (x = 0; x < grid.Length; x++)
            {
                for (y = 0; y < grid[x].Length; y++)
                {

                    if (!IsInGrid(x, y, n))
                    {
                        continue;
                    }
                    if (grid[x][y] != 0)
                    {
                        return (x, y);
                    }
                }
            }
            return (0, 0);
        }

        private Queue<(int, int)> GetWatch(int[][] grid, int x, int y)
        {
            int n = grid.Length;
            Queue<(int, int)> queue = new();
            Queue<(int, int)> queue2 = new();
            queue2.Enqueue((x, y));
            grid[x][y] = 2;
            while (queue2.TryDequeue(out var item))
            {
                foreach (var way in path)
                {
                    if (!IsInGrid(item.Item1 + way[0], item.Item2 + way[1], n))
                    {
                        continue;
                    }
                    if (grid[item.Item1 + way[0]][item.Item2 + way[1]] == 1)
                    {
                        grid[item.Item1 + way[0]][item.Item2 + way[1]] = 2;
                        queue2.Enqueue((item.Item1 + way[0], item.Item2 + way[1]));
                    }
                    else if (grid[item.Item1 + way[0]][item.Item2 + way[1]] == 0)
                    {
                        grid[item.Item1 + way[0]][item.Item2 + way[1]] = -1;
                        queue.Enqueue((item.Item1 + way[0], item.Item2 + way[1]));
                    }
                }
            }

            return queue;
        }
        private bool IsInGrid(int x, int y, int n)
        {
            if (x < 0 || y < 0) return false;
            if (x >= n || y >= n) return false;
            return true;
        }
    }
}
