public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> result = new List<List<int>>();
        List<int> subList = new List<int>();
        DFS(nums, result, subList, 0, 0, target);
        return result;
         
    }

    private void DFS(int[] nums, List<List<int>> result, List<int> subList, int index, int currSum, int target){
        if(currSum == target){
            result.Add(new List<int>(subList));
            return;
        }
        if(currSum > target || index >= nums.Length){
            return;
        }
        subList.Add(nums[index]);
        currSum += nums[index];
        DFS(nums, result, subList, index, currSum, target);
        subList.RemoveAt(subList.Count - 1);
        currSum -= nums[index];
        DFS(nums, result, subList, index + 1, currSum, target);
    }
}
