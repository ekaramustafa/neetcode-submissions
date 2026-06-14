public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {

        int result = 0;
        
        for(int i =0;i<grid.Length;i++){
            for(int j=0;j<grid[0].Length;j++){
                if(grid[i][j] == 1){
                    result = Math.Max(result, AreaDFS(grid,i,j));
                }
            }
        }
        return result;
        
    }

    public int AreaDFS(int[][] grid, int i, int j){
        if(i < 0 || j < 0 || i > grid.Length - 1 || j > grid[0].Length - 1 || grid[i][j] != 1){
            return 0;
        }
        grid[i][j] = -1;
        return 1 + AreaDFS(grid, i + 1, j) + AreaDFS(grid, i - 1, j) + AreaDFS(grid, i, j + 1) + AreaDFS(grid, i, j - 1);
    }
}
