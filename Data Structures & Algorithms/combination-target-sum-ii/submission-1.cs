public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        List<List<int>> list = new List<List<int>>();
        List<int> subList = new List<int>();


        backtrack(list, subList, candidates, target, 0);

        return list;
        
    }

    private void backtrack(List<List<int>> list, List<int> subList, int[] candidates, int target, int index){
        if(target == 0){
            list.Add(new List<int>(subList));
            return;
        }

        for(int i=index; i<candidates.Length;i++){
            if(i > index && candidates[i] == candidates[i-1]){
                continue;
            }
            subList.Add(candidates[i]);
            backtrack(list, subList, candidates, target - candidates[i], i + 1);
            subList.RemoveAt(subList.Count - 1);
        }

    }
}
