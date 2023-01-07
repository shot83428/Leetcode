public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        Array.Sort(costs);
        int index=0;
        for(;index<costs.Length;index++)
        {
            coins-=costs[index];
            
            if(coins<0){
                break;
            }
        }
        return index;
    }
}