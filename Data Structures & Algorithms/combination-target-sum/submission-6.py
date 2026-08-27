class Solution:
    def combinationSum(self, nums: List[int], target: int) -> List[List[int]]:
        res = []
        curr = []
        self.solve(nums, 0, res, curr, 0, target)
        return res
    
    def solve(self, nums, idx, res, curr, currSum, target):
        if currSum == target:
            res.append(curr.copy())
            return
        if idx >= len(nums) or currSum > target:
            return
        curr.append(nums[idx])
        self.solve(nums, idx, res, curr, currSum + nums[idx], target)
        curr.pop()
        self.solve(nums, idx + 1, res, curr, currSum, target)


    # 2,5,6,9
    # [2]
    # [2,2]
    # [2,2,2]
    # [2,2,2,2]
    # [2,2,2,2,2]
    # [2,2,2,2,5]
    # [2,2,2,2,9]
    # [2,2,2,5]
    # [2,2,2,9]
    # [2,2,5]
        
        