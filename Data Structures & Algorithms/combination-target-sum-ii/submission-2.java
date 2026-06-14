class Solution {
    public List<List<Integer>> combinationSum2(int[] candidates, int target) {
        
        List<List<Integer>> result = new ArrayList<>();
        List<Integer> subList = new ArrayList<>();
        Arrays.sort(candidates);
        backtrack(candidates, result, subList, 0, target);

        return result;
    }

    private void backtrack(int[] nums, List<List<Integer>> result, List<Integer> subList,int index, int target){
        if(target == 0){
            result.add(new ArrayList<>(subList));
            return;
        }
        if(target < 0){
            return;
        }

        for(int i =index;i < nums.length; i++){
            if(i > index && nums[i] == nums[i - 1]){
                continue;
            }
            subList.add(nums[i]);
            backtrack(nums,result, subList, i + 1, target - nums[i]);
            subList.remove(subList.size() - 1);
        }


    }
}


