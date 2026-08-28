class Solution:
    def exist(self, board: List[List[str]], word: str) -> bool:
        for i in range(len(board)):
            for j in range(len(board[0])):
                val = self.dfs(board, word, i, j, 0)
                if val:
                    return True
        return False
    
    def dfs(self, board, word, i, j, idx):
        if idx >= len(word):
            return True
        
        if i < 0 or i >= len(board) or j < 0 or j>= len(board[0]) or board[i][j] != word[idx]:
            return False
        return self.dfs(board, word, i+1,j,idx+1) or self.dfs(board, word, i, j+1, idx + 1)