public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        List<int[]> result = intervals.ToList();
        result.Add(newInterval);
        result.Sort((x, y) => x[0].CompareTo(y[0]));

        for (int index = 1; index < result.Count; index++)
        {
            if(result[index-1][1]>=result[index][0]&&result[index-1][1]<result[index][1]){
                result[index-1][1]=result[index][1];
                result.RemoveAt(index);
                index--;
            }
            else if(result[index-1][0]<=result[index][0]&&result[index-1][1]>=result[index][1]){
                result.RemoveAt(index);
                index--;
            }
        }
        return result.ToArray();
    }
}