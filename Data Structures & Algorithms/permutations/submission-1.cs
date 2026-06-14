public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> list = new List<List<int>>();
        List<int> subList = new List<int>();
        backtrack(list, subList, nums, new bool[nums.Length]);
        return list;
    }

    private void backtrack(List<List<int>> list, List<int> subList, int[] nums, bool[] visited){
        if(subList.Count == nums.Length){
            list.Add(new List<int>(subList));
            return;
        }

        for(int i=0;i<nums.Length;i++){
            if(visited[i]){
                continue;
            }
            subList.Add(nums[i]);
            visited[i] = true;
            backtrack(list, subList, nums, visited); 
            subList.RemoveAt(subList.Count -1);
            visited[i] = false;
        }
    }
}
