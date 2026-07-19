func lengthOfLongestSubstring(s string) int {
	l := 0
    r := 0
    seen := make(map[byte]bool)
    result := 0
    for r < len(s){
        for seen[s[r]]{
            delete(seen, s[l])
            l++
        }

        seen[s[r]] = true;
        curr := r - l + 1;
        r++
        if curr > result{
            result = curr;
        }
    }

    return result;


}
