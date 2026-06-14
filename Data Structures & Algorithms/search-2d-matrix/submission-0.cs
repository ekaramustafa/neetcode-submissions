public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int row = matrix.Length;
        int col = matrix[0].Length;
        int left = 0;
        int right = row * col - 1;
        
        int currRow;
        int currCol;

        while(left <= right){
            int mid = left + (right - left)/2;
            currRow = mid / col;
            currCol = mid % col;
            if(matrix[currRow][currCol] == target){
                return true;
            }
            else if (matrix[currRow][currCol] > target){
                right = mid - 1;
            }
            else{
                left = mid + 1;
            }

        }

        return false;


        
    }
}
