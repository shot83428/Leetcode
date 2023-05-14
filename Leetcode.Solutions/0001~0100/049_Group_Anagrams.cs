namespace Leetcode.Solutions
{
    public class Solution_049
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Array.Sort(strs);
            var counting = new Dictionary<string, int[]>();
            foreach (string str in strs)
            {
                var newCount = new int[27];
                foreach (char c in str)
                {
                    newCount[c - 'a']++;
                }
                if (counting.ContainsKey(str))
                {
                    newCount = counting[str];
                    newCount[26]++;
                }
                counting[str] = newCount;
            }

            var res = new List<IList<string>>();
            foreach (var pair in counting)
            {
                bool successed = false;
                for (int i = 0; i < res.Count; i++)
                {
                    if (CompareCountList(counting[res[i][0]], pair.Value))
                    {
                        for (int j = 0; j <= pair.Value[26]; j++)
                        {
                            res[i].Add(pair.Key);
                        }
                        successed = true;
                        break;
                    }
                }
                if (!successed)
                {
                    var list = new List<string>();
                    for (int j = 0; j <= pair.Value[26]; j++)
                    {
                        list.Add(pair.Key);
                    }
                    res.Add(list);
                }
            }

            res.Sort((a, b) => a.Count - b.Count);
            return res;
        }

        private bool CompareCountList(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
