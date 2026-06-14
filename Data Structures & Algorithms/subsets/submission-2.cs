public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        List<int> subList = new List<int>();

        backtrack(result, subList, nums, 0);
        return result;
    }

    private void backtrack(List<List<int>> result, List<int> subList, int[] nums, int index){
        if(index >= nums.Length){
            result.Add(new List<int>(subList));
            return;
        }

        subList.Add(nums[index]);
        backtrack(result, subList, nums, index + 1);
        subList.RemoveAt(subList.Count - 1);
        backtrack(result, subList, nums, index + 1);

    }


}
