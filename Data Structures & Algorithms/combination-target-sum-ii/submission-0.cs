public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        List<List<int>> result = new List<List<int>>();
        List<int> subList = new List<int>();
        Array.Sort(candidates);
        backtrack(result, subList, 0, 0, candidates, target);
        return result;
    }
    private void backtrack(List<List<int>> result, List<int> subList, int currSum, int index, int[] candidates, int target){
        if(currSum == target){
            result.Add(new List<int>(subList));
            return;
        }
        if(currSum > target || index  == candidates.Length){
            return;
        }

        subList.Add(candidates[index]);
        currSum += candidates[index];
        backtrack(result, subList, currSum, index + 1, candidates, target);
        subList.RemoveAt(subList.Count - 1);
        currSum -= candidates[index];

        while( index + 1  < candidates.Length  && candidates[index]  == candidates[index + 1]){
            index++;
        }

        backtrack(result, subList, currSum, index + 1, candidates, target);

    }
}
