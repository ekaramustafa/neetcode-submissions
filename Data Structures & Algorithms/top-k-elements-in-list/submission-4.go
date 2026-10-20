import "slices"
func topKFrequent(nums []int, k int) []int {
	
	minElement := slices.Min(nums)
	maxElement := slices.Max(nums)
	arr := make([]int, maxElement - minElement + 1)
	result := make([]int, k)
	for _, num := range nums{
		arr[num - minElement]++
	}

	if k > 0{
		idx := len(nums)-k
		result = append(result, nums[idx]+minElement)
		nums[idx] = -1
		k--
	}
	return result

}
