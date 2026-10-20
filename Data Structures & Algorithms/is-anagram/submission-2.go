import "slices"
func isAnagram(s string, t string) bool {
	if len(s) != len(t) {
		return false;
	}
	schars := []rune(s)
	tchars := []rune(t)
	
	slices.Sort(schars)
	slices.Sort(tchars)
	i := 0
	for i < len(schars){
		if schars[i] != tchars[i]{
			return false;
		}
	}

	return true;
}
