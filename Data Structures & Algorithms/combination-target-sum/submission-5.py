class Solution:
    def combinationSum(self, nums: List[int], target: int) -> List[List[int]]:

        def solve(i, sub, currSum):
            if currSum == target:
                res.append(sub.copy())
                return
            
            if i == len(nums) or currSum > target:
                return
            
            sub.append(nums[i])
            solve(i, sub, currSum + nums[i])
            sub.pop()
            solve(i+1, sub, currSum)
        
        res = []
        solve(0, [], 0)
        
        return res
        