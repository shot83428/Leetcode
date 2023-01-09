package leetcode322

func coinChange(coins []int, amount int) int {
	if amount == 0 {
		return 0
	}
	dp := make([]int, amount+1)

	for index := 0; index < len(coins); index++ {
		if coins[index] < len(dp) {
			dp[coins[index]] = 1
		}
	}

	for index := 0; index <= amount; index++ {
		for co := 0; co < len(coins); co++ {
			if index-coins[co] < 0 {
				continue
			}
			if dp[index] == 0 && dp[index-coins[co]] != 0 {
				dp[index] = dp[index-coins[co]] + 1
			} else if dp[index-coins[co]] != 0 && dp[index] > dp[index-coins[co]]+1 {
				dp[index] = dp[index-coins[co]] + 1
			}
		}
	}
	if dp[amount] == 0 {
		return -1
	}
	return dp[amount]
}
