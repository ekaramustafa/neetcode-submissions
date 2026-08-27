class Solution:
    def combinationSum2(self, candidates: List[int], target: int) -> List[List[int]]:
        candidates.sort()

        res = []
        curr = []
        self.backtrack(candidates, 0, res, curr, 0, target)
        return res
            

    def backtrack(self, candidates, idx, res, curr, currSum, target):
        if currSum == target:
            res.append(curr.copy())
            return
        
        for i in range(idx, len(candidates)):
            if i > idx and candidates[i] == candidates[i-1]:
                continue

            if currSum + candidates[i] > target:
                break
        
            curr.append(candidates[i])
            self.backtrack(candidates, i + 1, res, curr, currSum + candidates[i], target)
            curr.pop()
    
    # 1,2,2,4,5,6,9
    # 1
    # 1,2
    # 1,2,2
    # 
