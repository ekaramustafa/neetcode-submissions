import "slices"
func topKFrequent(nums []int, k int) []int {
	
	minElement := slices.Min(nums)
	maxElement := slices.Max(nums)
	arr := make([]int, maxElement - minElement + 1)
	result := make([]int, 0, k)
	for _, num := range nums{
		arr[num - minElement]++
	}

    for k > 0 {
        idx := slices.Index(arr, slices.Max(arr))

        result = append(result, idx+minElement)

        arr[idx] = -1
        k--
    }
	return result
}
