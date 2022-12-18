package leetcode76

import "strings"

func minWindow(s string, t string) string {

	hashtable := make(map[byte][]int)
	hashcount := 0
	counting := make(map[byte]int)
	count := 0
	res := ""
	for index := 0; index < len(t); index++ {
		counting[t[index]]++
		count++
	}

	for index := 0; index < len(s); index++ {
		if strings.Index(t, string(s[index])) != -1 {
			_, bo := hashtable[s[index]]
			if bo {
				hashtable[s[index]] = append(hashtable[s[index]], index)
			} else {
				hashtable[s[index]] = append([]int{}, index)
			}
			if len(hashtable[s[index]]) <= counting[s[index]] {
				hashcount++
			}

			if hashcount == count {
				start, end := long(hashtable, counting)
				if end-start < len(res) || res == "" {
					res = s[start : end+1]
				}

			}
		}
	}

	return res
}

func long(table map[byte][]int, counting map[byte]int) (int, int) {

	Start, End := -1, -1
	for word, item := range table {

		if item[len(item)-1] > End {
			End = item[len(item)-1]
		}
		if Start == -1 || item[len(item)-counting[word]] < Start {
			Start = item[len(item)-counting[word]]
		}

	}
	return Start, End
}
