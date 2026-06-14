public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        Array.Sort(nums);
        List<int> subList = new List<int>();
        backtrack(result, subList, nums, 0);
        return result;
    }

    private void backtrack(List<List<int>> result, List<int> subList, int[] nums, int index){
        result.Add(new List<int>(subList));

        for(int i = index; i < nums.Length; i++){
            if(i > index && nums[i] == nums[i - 1])
                continue;
            
            subList.Add(nums[i]);
            backtrack(result, subList, nums, i + 1);
            subList.RemoveAt(subList.Count - 1);
        }


    }
}
