public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        List<int> sublist = new List<int>();

        DFS(nums, result, sublist, 0); 
        return result;
    }

    public void DFS(int[] nums, List<List<int>> result, List<int> subList, int index){
        if(index >= nums.Length){
            result.Add(new List<int>(subList));
            return;
        }
        subList.Add(nums[index]);
        DFS(nums, result, subList, index + 1);
        subList.RemoveAt(subList.Count - 1);
        DFS(nums, result, subList, index + 1);

    } 
}
