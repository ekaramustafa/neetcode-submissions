public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        List<int> subList = new List<int>();
        bool[] visited = new bool[nums.Length];

        backtrack(result, subList, nums, visited);

        return result;
        
    }

    private void backtrack(List<List<int>> result, List<int> subList, int[] nums, bool[] visited){
        if(subList.Count == nums.Length){
            result.Add(new List<int>(subList));
            return;
        }

        for(int i =0;i<nums.Length;i++){
            if(!visited[i]){
                visited[i] = true;
                subList.Add(nums[i]);
                backtrack(result, subList, nums, visited);
                subList.RemoveAt(subList.Count - 1);
                visited[i] = false;
            }
        }


    }
}
