class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        def check(k):
            return sum((pile + k - 1) // k for pile in piles)

        l, r = 1, max(piles)
        res = r

        while l < r:
            mid = (l + r) // 2
            if check(mid) <= h:
                res = mid
                r = mid
            else:
                l = mid + 1

        return res
