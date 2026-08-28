class Solution:
    def subsetsWithDup(self, nums: List[int]) -> List[List[int]]:
        nums.sort()
        res = []
        self.solve(nums, [], res, 0)
        return res
    
    def solve(self, nums, curr, res, idx):
        if idx == len(nums):
            if curr not in res:
                res.append(curr.copy())
            return
        
        curr.append(nums[idx])
        self.solve(nums, curr, res, idx + 1)
        curr.pop()
        self.solve(nums, curr, res, idx + 1)

    # []
    # [1, 2, 1]
