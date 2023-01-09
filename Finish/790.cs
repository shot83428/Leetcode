public class Solution {
    public int NumTilings(int n) {
        int modVal = 1000000000 + 7;
        long[] dp = new long[n+1];
        if(n==1){
            return 1;            
        }
        if(n==2){
            return 2;            
        }
        
        dp[0]=1;
        dp[1]=1;
        dp[2]=2;
        for(int index=3;index<=n;index++)
        {
            dp[index]=((dp[index-1]*2)+dp[index-3])%modVal;
        }
        return (int)dp[n];
    }
}