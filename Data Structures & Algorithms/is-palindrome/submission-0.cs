public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        s = s.ToLower();
        
        while (left < right) {
            while (left < right && !char.IsLetterOrDigit(s[left])) {
                left++;
            }
            while (left < right && !char.IsLetterOrDigit(s[right])) {
                right--;
            }
            if (s[left] != s[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
