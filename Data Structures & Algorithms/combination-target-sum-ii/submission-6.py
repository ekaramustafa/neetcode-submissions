class Solution:
    def combinationSum2(self, candidates: List[int], target: int) -> List[List[int]]:
        res = []
        curr = []
        self.solve(candidates, res, target, 0, curr, 0)
        return res
    

    def solve(self, candidates, res, target, idx, curr, currSum):
        if currSum == target and curr not in res:
            res.append(curr.copy())
            return
        if idx >= len(candidates) or currSum > target:
            return
        curr.append(candidates[idx])
        self.solve(candidates, res, target, idx + 1, curr, currSum + candidates[idx])
        curr.pop()
        self.solve(candidates, res, target, idx + 1, curr, currSum)
        
        
        