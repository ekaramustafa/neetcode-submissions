func characterReplacement(s string, k int) int {

    l := 0
    r := 0
    result := 1
    counter := k;
    for r < len(s){
        if s[r] != s[l]{
            if counter > 0{
                counter--
            } else {
                counter = k
                l = r
            }
            
        }
        curr := r - l + 1
        if curr > result{
            result = curr
        }
        r++
    }

    return result


}
