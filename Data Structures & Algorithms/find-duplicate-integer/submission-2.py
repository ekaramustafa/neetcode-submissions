class Solution:
    def findDuplicate(self, nums: List[int]) -> int:
        for i in range(len(nums)):
            idx = nums[i] - 1 
            if nums[idx] < 0:
                return nums[i]
            else:
                nums[idx] = -nums[i]
        
        

        