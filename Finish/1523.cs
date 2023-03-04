public class Solution {
    public int CountOdds(int low, int high) {
        int count=0;
        count =(high-low)/2;
        if(low%2==0&&high%2==0){
            return count;
        }
        return count+1;        
    }
}