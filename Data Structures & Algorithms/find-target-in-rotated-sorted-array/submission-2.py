class Solution:
    def search(self, nums: List[int], target: int) -> int:
        def findBreakingPoint():
            l, r = 0, len(nums) - 1
            while l < r:
                mid = (r - l) // 2 + l 
                if nums[mid] > nums[r]:
                    l = mid + 1
                else:
                    r = mid
            return l

        pivot = findBreakingPoint()
        
        l, r = 0, len(nums) - 1

        while l <= r:
            mid = ((r - l) // 2 + l)
            pivottedMid = (mid + pivot) % len(nums)
            if nums[pivottedMid] == target:
                return pivottedMid
            if nums[pivottedMid] > target:
                r = mid - 1
            else:
                l = mid + 1
        
        return -1



        

                
    

        