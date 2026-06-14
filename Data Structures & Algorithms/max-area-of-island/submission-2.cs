public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int result = 0;

        for(int i =0; i < grid.Length; i++){
            for(int j =0; j < grid[0].Length; j++){
                if(grid[i][j] == 1){
                    int area = DFS(grid, i, j);
                    result = Math.Max(area, result);
                }
            }

        }

        return result;
        
    }
    private int DFS(int[][] grid, int i, int j){
        if(i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] != 1){
            return 0;
        }
        grid[i][j] = 0;

        return 1 + DFS(grid, i, j - 1) + DFS(grid, i, j + 1) + DFS(grid, i - 1, j) + DFS(grid, i + 1, j);
   
    }
}


