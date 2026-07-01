class Solution:
    def findDuplicate(self, nums: List[int]) -> int:
        for i in range(len(nums)):
            idx = nums[i] - 1 
            if nums[idx] * nums[i] < 0:
                return abs(nums[i])
            else:
                nums[idx] = -nums[i]
        
        