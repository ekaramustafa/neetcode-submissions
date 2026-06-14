public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int minVal = nums[GetMinIndex(nums)];
        int maxVal = nums[GetMaxIndex(nums)];
        int[] countArr = new int[maxVal - minVal + 1];
        int[] result = new int[k];
        for(int i =0;i<nums.Length;i++){
            countArr[nums[i]-minVal]++;
        }

        int j = 0;
        while(j < k){
            int maxIndex = GetMaxIndex(countArr);
            int val = maxIndex + minVal;
            countArr[maxIndex] = 0;
            result[j] = val;
            j++;
        }

        return result;
    }


    private int GetMinIndex(int[] nums){
        int minIndex = 0;
        for(int i =1;i<nums.Length;i++){
            if(nums[minIndex] > nums[i]){
                minIndex = i;
            }
        }
        return minIndex;
    }

    private int GetMaxIndex(int[] nums){
        int maxIndex = 0;
        for(int i =1;i<nums.Length;i++){
            if(nums[maxIndex] < nums[i]){
                maxIndex = i;
            }
        }
        return maxIndex;
    }
}
