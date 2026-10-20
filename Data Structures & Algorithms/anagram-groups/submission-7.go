import "slices"

func groupAnagrams(strs []string) [][]string {

	groups := make(map[string][]string)

	for _, str := range strs{
		key := giveSorted(str)
		groups[key] = append(groups[key], str)
	}

	return groups

}

func giveSorted(str string) string {
    chars := []rune(str)
    slices.Sort(chars)
    return string(chars)
}