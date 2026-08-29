class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        # k = 1
        # 1 4 3 2
        # 
        if h == len(piles):
            return max(piles)
        
        l = 1
        r = max(piles) # 4

        while l < r:
            mid = l + (r-l) // 2
            if self.canSolve(mid, piles.copy(), h):
                r = mid
            else:
                l = mid + 1
        # 1 4
        # 2
        # l = 2
        # 

        return l
    
    def canSolve(self, mid, arr, h):
        ls = [e / mid for e in arr]
        if sum(ls) > h:
            return False
        return True
        