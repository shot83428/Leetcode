public class Solution
{
    public IList<string> RestoreIpAddresses(string s)
    {
        List<string> res = new List<string>();
        Queue<(string, string)> queues = new Queue<(string, string)>();
        queues.Enqueue((s, string.Empty));

        while (queues.TryDequeue(out var item))
        {
            if (string.IsNullOrEmpty(item.Item1) && item.Item2.Split('.').Length == 4)
            {
                res.Add(item.Item2);
                continue;
            }

            if (string.IsNullOrEmpty(item.Item1) || item.Item2.Split('.').Length > 4)
            {
                continue;
            }

            for (int j = 0; j < 3; j++)
            {
                if (item.Item1.Length >= j + 1)
                {
                    var val = int.Parse(item.Item1.Substring(0, j + 1));
                    if (j != 0 && val < 10)
                    {
                        break;
                    }
                    if (val <= 255)
                    {
                        if (string.IsNullOrEmpty(item.Item2))
                            queues.Enqueue((item.Item1.Substring(j + 1), string.Format($"{val}")));
                        else
                            queues.Enqueue((item.Item1.Substring(j + 1), string.Format($"{item.Item2}.{val}")));
                    }
                }
            }
        }

        return res;
    }
}
