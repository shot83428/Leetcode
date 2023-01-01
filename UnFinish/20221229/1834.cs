public class Solution {
    public int[] GetOrder(int[][] tasks) {
        int[] res = new int[tasks.Length]{-1};
        int resindex = 0;
        List<int> indexs = new List<int>();
        for(int index=0;resindex<res.Length;index++)
        {
            for(int taskindex=0;taskindex<tasks.Length;taskindex++)
            {
                if(tasks[taskindex][0]==index){
                    indexs.Add(taskindex);
                }
            }
        }
        return res;
    }
}