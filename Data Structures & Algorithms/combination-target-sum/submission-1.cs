public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> result = new List<List<int>>();
        List<int> subList = new List<int>();

        backtrack(result, subList, nums, target, 0, 0);

        return result; 
        
    }

    private void backtrack(List<List<int>> result, List<int> subList, int[] nums, int target, int currSum, int index){
        if(index == nums.Length || currSum > target){
            return;
        }
        
        if(currSum == target){
            result.Add(new List<int>(subList));
            return;
        }
        subList.Add(nums[index]);
        backtrack(result, subList, nums, target, currSum + nums[index], index);
        subList.RemoveAt(subList.Count - 1);
        backtrack(result, subList, nums, target, currSum, index + 1);

    }
}
