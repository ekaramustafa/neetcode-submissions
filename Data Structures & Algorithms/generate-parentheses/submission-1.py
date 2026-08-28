class Solution:
    def generateParenthesis(self, n: int) -> List[str]:
        # ()
        # (())
        # ()()
        # open or close 
        # open := n
        # close := n
        s = []
        curr = ""
        self.solve(s, curr, n, n)
        return s
    
    def solve(self, s, curr, opn, cls):
        if opn == 0 and cls == 0:
            s.append(curr)
            return
        if opn != 0 and cls >= opn:
            self.solve(s, curr + "(", opn - 1, cls)
        if curr and cls != 0:
            self.solve(s, curr + ")", opn, cls - 1)
        

        