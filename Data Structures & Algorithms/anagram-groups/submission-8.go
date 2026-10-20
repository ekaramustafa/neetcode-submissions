import "slices"

func groupAnagrams(strs []string) [][]string {

	groups := make(map[string][]string)

	for _, str := range strs{
		key := giveSorted(str)
		groups[key] = append(groups[key], str)
	}

	result := make([][]string, 0, len(groups))

	for _ , group := range groups{
		result = append(result, group)
	}

	return result

}

func giveSorted(str string) string {
    chars := []rune(str)
    slices.Sort(chars)
    return string(chars)
}