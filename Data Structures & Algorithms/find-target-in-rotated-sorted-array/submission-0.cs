public class Solution {
    public int Search(int[] nums, int target) {

        //[4,5,6,1,2,3]
        //[1,2,3,4,5,6]
        int minIndex = FindMinIndex(nums);
        int left = 0;
        int right = nums.Length - 1;

        while(left <= right){
            int mid = left  + (right-left)/2;
            int adjustedMid = (mid + minIndex) % nums.Length;
            if(nums[adjustedMid] == target){
                return adjustedMid;
            }
            else if (nums[adjustedMid] > target){
                right = mid - 1;
            }
            else{
                left = mid + 1;
            }

        }

        return -1;
        
    }


    public int FindMinIndex(int[] nums){
        int left = 0;
        int right = nums.Length - 1;

        while(left < right){
            int mid = left + (right - left)/2;
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
