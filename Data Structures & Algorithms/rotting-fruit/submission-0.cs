public class Solution {
    public int OrangesRotting(int[][] grid) {
        Queue<int[]> queue = new Queue<int[]>();
        int fresh = 0;
        int time = 0;
        for(int i =0;i<grid.Length;i++){
            for(int j=0;j<grid[0].Length;j++){
                if(grid[i][j] == 1){
                    fresh++;
                }
                if(grid[i][j] == 2){
                    queue.Enqueue(new int[] {i,j});
                }
            }
        }

        int[][] dirs = {new int[] {-1, 0},
                        new int[] {0, -1},
                        new int[] {1, 0},
                        new int[] {0, 1}};

        while(fresh > 0 && queue.Count > 0){
            int level = queue.Count;
            for(int i =0;i<level;i++){
                    
                int[] pair = queue.Dequeue();
                int row = pair[0];
                int col = pair[1];

                foreach(int[] dir in dirs){
                    int x = row + dir[0];
                    int y = col + dir[1];

                    if(x < 0 || y < 0 || x >= grid.Length || y >= grid[0].Length || grid[x][y] != 1){
                        continue;
                    }
                    grid[x][y] = 2;
                    queue.Enqueue(new int[] {x , y});
                    fresh--;
                }
            }
            time++;
        } 

        return fresh == 0 ? time : -1;
        
        
    }
}
