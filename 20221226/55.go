package leetcode55

func canJump(nums []int) bool {
	dp := make([]int, len(nums)+1)

	for index := 1; index <= len(nums); index++ {
		if index == 1 {
			dp[index] = 1
		}
		if dp[index] == 1 {
			for walk := index + 1; walk <= index+nums[index-1] && walk <= len(nums); walk++ {
				dp[walk] = 1
			}
		}
		if dp[len(nums)] != 0 {
			return true
		}
	}
	return false
}
