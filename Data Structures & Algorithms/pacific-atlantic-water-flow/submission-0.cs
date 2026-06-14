public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {
        int row = heights.Length;
        int col = heights[0].Length;

        HashSet<int> pac = new HashSet<int>();
        HashSet<int> atl = new HashSet<int>();

        for(int i =0;i<row;i++){
            dfs(i, 0, pac, heights[i][0], row, col, heights);
            dfs(i, col - 1, atl, heights[i][col - 1], row, col, heights);
        }

        for(int j =0;j<col;j++){
            dfs(0, j, pac, heights[0][j], row, col, heights);
            dfs(row - 1, j, atl, heights[row - 1][j], row, col, heights);
        }

        List<List<int>> list = new List<List<int>>();
        for(int i = 0;i< row;i++){
            for(int j = 0; j< col;j++){
                int coord = i * col + j;
                if(pac.Contains(coord) && atl.Contains(coord)){
                    list.Add(new List<int> { i , j});
                }
            }
        }
        return list;
        
    }

    private void dfs(int x, int y, HashSet<int> visit,int prevHeight, int row, int col, int[][] heights){
        int coord = x * col + y;
        if(x < 0 || y < 0 || x == row || y == col || heights[x][y] < prevHeight || visit.Contains(coord)){
            return;
        }
        visit.Add(coord);
        dfs(x + 1, y, visit, heights[x][y], row, col, heights);
        dfs(x - 1, y, visit, heights[x][y], row, col, heights);
        dfs(x, y + 1, visit, heights[x][y], row, col, heights);
        dfs(x, y - 1, visit, heights[x][y], row, col, heights);

    }
}
