package leetcode1443

import "sort"

const MaxUint = ^uint(0)
const MaxInt = int(MaxUint >> 1)

func minTime(n int, edges [][]int, hasApple []bool) int {
	var dfs func(indexs int, edgePair [][]int) int
	sort.SliceStable(edges, func(i, j int) bool {
		return edges[i][0] < edges[j][0]
	})
	dfs = func(index int, edgePair [][]int) int {
		res := 0
		for i, item := range edgePair {
			if item[0] > index {
				break
			}
			if item[0] == index {
				res += dfs(item[1], edgePair[i+1:])
			} else if item[1] == index {
				res += dfs(item[0], edgePair[i+1:])
			}
		}

		if res > 0 {
			return res + 2
		}
		if hasApple[index] {
			res += 2
		}
		return res
	}
	re := dfs(0, edges) - 2
	if re < 0 {
		return 0
	}
	return re
}
