class Solution:
    def subsetsWithDup(self, nums: List[int]) -> List[List[int]]:
        
        res = []

        def dfs(i, subset):
            if i >= len(nums):
                sorted_subset = sorted(subset)
                if sorted_subset not in res:
                    res.append(sorted_subset.copy())
                return
            
            subset.append(nums[i])
            dfs(i + 1, subset)
            subset.pop()
            dfs(i + 1, subset)

        dfs(0, [])
        return res