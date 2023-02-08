using System.Collections.Generic;
using System.Linq;
using System;
public class Solution {
    public int TotalFruit(int[] fruits) {
        Queue<int> queue = new Queue<int>();
        Dictionary<int,int> dic = new Dictionary<int, int>();
        int reuslt=0;
        for(int index=0;index<fruits.Length;index++)
        {            
            queue.Enqueue(fruits[index]);            
            if(dic.ContainsKey(fruits[index]))
            {
                dic[fruits[index]]++;
            }
            else
            {
                if(dic.Count==2)
                {
                    while(queue.TryDequeue(out var first))
                    {
                        dic[first]--;
                        if(dic[first]==0)
                        {
                            dic.Remove(first);
                            break;
                        }
                    }
                }
                dic.Add(fruits[indexs],1);
            }
            reuslt = Math.Max(reuslt,queue.Count);
        }
        return reuslt;
    }
}
