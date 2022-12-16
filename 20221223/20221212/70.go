package leetcode70

func climbStairs(n int) int {
	dp := make([]int, n)
	dp[0] = 1
	if n > 1 {
		dp[1] = 2
	}
	for index := 2; index < n; index++ {
		dp[index] = dp[index-1] + dp[index-2]
	}

	return dp[n-1]
}
