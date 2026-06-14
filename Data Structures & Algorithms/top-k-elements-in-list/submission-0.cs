public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int minVal = nums[getMin(nums)];
        int maxVal = nums[getMax(nums)];

        int[] countArray = new int[maxVal-minVal+1];

        for(int i =0;i<nums.Length;i++){
            countArray[nums[i]-minVal]++;
        }
        int[] result = new int[k];
        int j =0;
        while(j < k){
            int idx = getMax(countArray);
            result[j++] = idx + minVal;
            countArray[idx] = 0;
        }
        return result;

        
    }

     private int getMin(int[] nums){
        int idx = 0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i] < nums[idx]){
                idx = i;
            }
        }
        return idx;
    }

    private int getMax(int[] nums){
        int idx = 0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i] > nums[idx]){
                idx = i;
            }
        }
        return idx;

    }
}