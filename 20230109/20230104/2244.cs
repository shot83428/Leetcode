public class Solution
{
    public int MinimumRounds(int[] tasks)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int index = 0; index < tasks.Length; index++)
        {
            if (dic.ContainsKey(tasks[index]))
            {
                dic[tasks[index]]++;
            }
            else
            {
                dic.Add(tasks[index], 1);
            }
        }
        int res = 0;
        foreach(var item in dic){
            if(item.Value==1)
                return -1;
            else{
                res += item.Value/3;
                if(item.Value%3!=0){
                    res++;
                }
            }
        }
        return res;
    }
}