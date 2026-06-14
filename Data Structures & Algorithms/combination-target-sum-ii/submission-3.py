class Solution:
    def combinationSum2(self, candidates: List[int], target: int) -> List[List[int]]:

        res = []
        def dfs(i, subset, curr_sum):

            if curr_sum == target:
                sorted_subset = sorted(subset)
                if sorted_subset not in res:
                    res.append(sorted_subset.copy())
                    return
            
            if i >= len(candidates) or curr_sum > target:
                return
            
            subset.append(candidates[i])
            dfs(i+1, subset, curr_sum + candidates[i])
            subset.pop()
            dfs(i+1, subset, curr_sum)

        
        dfs(0, [], 0)

        return res

        