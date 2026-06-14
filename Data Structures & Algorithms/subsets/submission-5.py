class Solution:
    def subsets(self, nums: List[int]) -> List[List[int]]:
        def solve(i, sub):
            if i == len(nums):
                res.append(sub.copy())
                return
            
            sub.append(nums[i])
            solve(i + 1, sub)
            sub.pop()
            solve(i + 1, sub)
        res = []

        solve(0, [])
        return res
    
            
        