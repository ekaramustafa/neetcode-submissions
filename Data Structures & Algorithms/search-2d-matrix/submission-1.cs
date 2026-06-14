public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int row = matrix.Length;
        int col = matrix[0].Length;
        int left = 0;
        int right = row * col - 1;
        while(left <= right){
            int mid = left + (right-left)/2;
            int midRow = mid / col;
            int midCol = mid % col;
            int val = matrix[midRow][midCol];
            if(val == target){
                return true;
            }
            else if (val > target){
                right = mid - 1;
            }
            else{
                left = mid + 1;
            }
        }
        return false;
        
    }
}
