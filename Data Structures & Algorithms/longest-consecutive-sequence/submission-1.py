class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        memo = {}
        nums = set(nums)

        longest = 1
        for num in nums:
            memo[num] = True
            
        for num in nums:
            if (num - 1) not in memo:
                length = 1
                while num + length in memo:
                    length +=1
                longest = max(length, longest)
    
        return longest


        