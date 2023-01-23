//把向量拆成點 左上 右上
//左邊的點 一定都是選高的
//所以左邊的通通改為負的就反過來成為一定找最矮
//重點是右邊是找兩個點相交取矮+取前一個交叉點以及到最底要抓0
//所以相對於左邊就是堆上去找第二個或是前一個
//因此heightCounts是一個max Dictionary 去紀錄最高
//<0就是左邊季統計數量
//>0就是右邊要將相對高度扣除抓他的下一個點去放在result
//範例假如一個凸 最高是10中間是5
//10 1 ,5 1 ,0 0(高度,數量)
//遇到有10扣掉勝5 1,0 0
//result會抓到5但是高度是10的x軸的點交叉點
//10 但是heightCounts會得到最低的點 5 1 
//就會的到 5及x軸放在height的點
public class Solution {
    public IList<IList<int>> GetSkyline(int[][] buildings) 
    {
        var points = new List<IList<int>>();
        
        for(int i=0; i<buildings.Length; i++)
        {
            points.Add(new int[]{buildings[i][0], -buildings[i][2]});
            points.Add(new int[]{buildings[i][1],  buildings[i][2]});
        }        
        points.Sort((a,b)=>{
            if(a[0] != b[0])
            {
                return a[0].CompareTo(b[0]);
            }

            return a[1].CompareTo(b[1]);
        });
        var result = new List<IList<int>>();

		var heightCounts = new SortedDictionary<int, int>(Comparer<int>.Create((a,b)=>-a.CompareTo(b)));
        
        heightCounts.Add(0, 0);
        var bef = 0;

        foreach(var p in points)
        {
            if(p[1]<0)
            {
				if(!heightCounts.ContainsKey(-p[1]))
                {
                    heightCounts[-p[1]] = 0;
                }

                heightCounts[-p[1]]++;
            }
            else 
            {
                heightCounts[p[1]]--;

                if(heightCounts[p[1]] <= 0)
                {
                     heightCounts.Remove(p[1]);
                }
            }
            
            int nowHeigest = heightCounts.First().Key;
            if(bef != nowHeigest)
            {
                result.Add(new int[]{p[0], nowHeigest});
                bef =nowHeigest;
            }
        }
        return result;
    }
}
