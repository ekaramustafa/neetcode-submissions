class Solution:
    def combinationSum2(self, candidates: List[int], target: int) -> List[List[int]]:
        candidates = sorted(candidates)
        seen = set()
        def solve(i, sub, currSum):
            if currSum == target:
                t = tuple(sub.copy())
                if t not in seen:
                    res.append(sub.copy())
                    seen.add(t)
                return
            
            if i == len(candidates) or currSum > target:
                return
            
            sub.append(candidates[i])
            solve(i+1, sub, currSum + candidates[i])
            sub.pop()
            solve(i+1, sub, currSum)
        
        res = []
        solve(0, [], 0)
        return res
        