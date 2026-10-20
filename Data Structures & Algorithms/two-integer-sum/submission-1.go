func twoSum(nums []int, target int) []int {
	m := make(map[int]int)

	for idx, num := range nums{
		if idx_val, exists := m[target-num]; exists{
			return []int{idx_val, idx}
		}else{
			m[num] = idx
		}
	}
	return nil;
    
}
