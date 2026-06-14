public class Solution {
    public int NumIslands(char[][] grid) {
        if(grid == null) return 0;
        int count = 0;

        for(int i =0;i < grid.Length; i++){
            for(int j =0;j < grid[0].Length; j++){
                if(grid[i][j] == '1'){
                    dfs(grid, i, j);
                    count++;
                }
            }
        }    
        return count; 
    }

    private void dfs(char[][] grid, int i, int j){
        if(i < 0 || j < 0 || i >= grid.Length || j>= grid[0].Length || grid[i][j] != '1')
            return;
        
        //Mark the cell, visit
        grid[i][j] = '0';

        dfs(grid, i - 1, j);
        dfs(grid, i + 1, j);
        dfs(grid, i, j + 1);
        dfs(grid, i, j - 1);
    }
}
