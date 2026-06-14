public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        Queue<int[]> q = new Queue<int[]>();
        int m = grid.Length;
        int n = grid[0].Length;
        for(int i =0;i<m;i++){
            for(int j =0;j < n; j++){
                if(grid[i][j] == 0){
                    q.Enqueue(new int[] {i, j});
                }
            }
        } 

        if (q.Count == 0) return;

        int[][] dirs = {new int[] {-1, 0}, new int[] {0, -1}, new int[] {1,0}, new 
        int[] {0,1}};

        while(q.Count > 0){
            int[] cur = q.Dequeue();
            int row = cur[0];
            int col = cur[1];
            foreach(int[] dir in dirs){
                int x = row + dir[0];
                int y = col + dir[1];

                if(x >=m || y>= n || x < 0 || y < 0 || grid[x][y] != int.MaxValue){
                    continue;
                }
                q.Enqueue(new int[] {x, y});
                grid[x][y] = grid[row][col] + 1;
            }
        }
        
    }
}
