public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right =nums.Length - 1;
        int pivot = FindPivot(nums);
        while(left <= right){
            int mid = left + (right-left)/2;
            int pivottedMid = (mid + pivot) % nums.Length;
            if(nums[pivottedMid] == target){
                return pivottedMid;
            } 
            else if (nums[pivottedMid] > target){
                right = mid - 1;
            }
            else{
                left = mid + 1;
            }
        }

        return -1;
        
    }


    private int FindPivot(int[] nums){
        int left = 0;
        int right = nums.Length - 1;
        while(left < right){
            int mid = left + (right-left)/2;
            if(nums[mid] > nums[right]){
                left = mid + 1;
            }
            else{
                right = mid;
            }
        }
        return left;
    }
}
