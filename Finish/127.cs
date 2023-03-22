public class Solution {
   public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        Dictionary<string, HashSet<string>> dic = new Dictionary<string, HashSet<string>>();
        foreach (var word in wordList)
        {
            for (int index = 0; index < word.Length; index++)
            {
                var tmp = word.ToArray();
                tmp[index] = '.';
                string pointWord = new string(tmp);
                if (!dic.ContainsKey(pointWord))
                {
                    dic.Add(pointWord, new HashSet<string>());
                }
                dic[pointWord].Add(word);
            }
        }

        Queue<(string, int)> bfs = new Queue<(string, int)>();
        bfs.Enqueue((beginWord, 1));

        HashSet<string> IsNotSelect = wordList.ToHashSet();

        while (bfs.TryDequeue(out var item))
        {
            for (int index = 0; index < item.Item1.Length; index++)
            {
                var tmp = item.Item1.ToArray();
                tmp[index] = '.';
                var pointWord = new string(tmp);
                if (dic.TryGetValue(pointWord, out var set))
                    foreach (var str in set)
                    {
                        if (string.Equals(str, endWord))
                        {
                            return item.Item2 + 1;
                        }

                        if (IsNotSelect.Contains(str))
                        {
                            bfs.Enqueue((str, item.Item2 + 1));
                            IsNotSelect.Remove(str);
                        }
                    }
            }
        }

        return 0;
    }

}