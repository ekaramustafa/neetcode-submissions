public class Solution {
    public List<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        GenerateParenthesisHelper(result, "", n, n);
        return result;
    }

    private void GenerateParenthesisHelper(List<string> result, string current, int open, int close) {
        if (open == 0 && close == 0) {
            result.Add(current);
            return;
        }

        if (open > 0) {
            GenerateParenthesisHelper(result, current + "(", open - 1, close);
        }

        if (close > open) {
            GenerateParenthesisHelper(result, current + ")", open, close - 1);
        }
    }
}
