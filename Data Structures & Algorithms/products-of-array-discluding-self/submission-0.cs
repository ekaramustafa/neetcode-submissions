public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefixArr = new int[nums.Length];
        int[] suffixArr = new int[nums.Length];
        prefixArr[0] = 1;
        suffixArr[suffixArr.Length - 1]  = 1;

        for(int i =1;i<prefixArr.Length;i++){
            prefixArr[i] = prefixArr[i-1] * nums[i - 1]; 
        } 

        for(int j = suffixArr.Length -2 ; j>=0;j--){
            suffixArr[j] = suffixArr[j + 1] * nums[j + 1];
        }
        for(int k=0;k<nums.Length;k++){
            nums[k] = prefixArr[k] * suffixArr[k];
        }

        return nums;
        
    }
}
