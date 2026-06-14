public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        List<int> subList = new List<int>();

        backtrack(result, subList, nums, 0);
        return result;
    }

    private void backtrack(List<List<int>> result, List<int> subList, int[] nums, int index){
        result.Add(new List<int>(subList));

        for(int i = index; i< nums.Length; i++){
            subList.Add(nums[i]);
            backtrack(result, subList, nums, i + 1);
            subList.RemoveAt(subList.Count - 1);
        }

    }


}
