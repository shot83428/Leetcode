public class Solution {
public int MinJumps(int[] arr)
    {
        Dictionary<int, HashSet<int>> dic = new Dictionary<int, HashSet<int>>();
        HashSet<int> isPath = new HashSet<int>();

        for (int index = 0; index < arr.Length; index++)
        {
            if (dic.ContainsKey(arr[index]))
            {
                dic[arr[index]].Add(index);
                if (dic[arr[index]].Contains(index - 1) && index - 2 > -1 && arr[index - 2] == arr[index])
                {
                    dic[arr[index]].Remove(index - 1);
                }
            }
            else
            {
                dic.Add(arr[index], new HashSet<int>() { index });
            }
        }

        Queue<int[]> bfs = new Queue<int[]>();
        bfs.Enqueue(new int[2] { 0, 0 });
        isPath.Add(0);
        while (bfs.TryDequeue(out var ints))
        {
            if (ints[1] == arr.Length - 1)
                continue;

            if (ints[0] == arr.Length - 1)
            {
                return ints[1];
            }
            else
            {
                foreach (var item in dic[arr[ints[0]]])
                {
                    if (item != ints[0] && !isPath.Contains(item))
                    {
                        bfs.Enqueue(new int[2] { item, ints[1] + 1 });
                        isPath.Add(item);
                    }
                }
                if (!isPath.Contains(ints[0] + 1))
                {
                    bfs.Enqueue(new int[2] { ints[0] + 1, ints[1] + 1 });
                    isPath.Add(ints[0] + 1);
                }
                if (ints[0] - 1 > 0 && !isPath.Contains(ints[0] - 1))
                {
                    bfs.Enqueue(new int[2] { ints[0] - 1, ints[1] + 1 });
                    isPath.Add(ints[0] - 1);
                }
                dic[arr[ints[0]]].Clear();
            }
        }

        return arr.Length - 1;
    }


}