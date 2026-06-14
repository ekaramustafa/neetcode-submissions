public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //for convenience
        int n = nums.Length;

        //auxilary vars
        int[] prefixArr = new int[n];
        int[] suffixArr = new int[n];
        int[] result = new int[n];
        
        //initialization of boundaries accordingly
        prefixArr[0] = 1;
        suffixArr[n - 1] = 1;
        
        //populate prefix arr 
        for(int i =1;i<n;i++){
            prefixArr[i] = prefixArr[i - 1] * nums[i - 1];
        }

        //populate suffix arr
        for(int j = n - 2; j >=0;j--){
            suffixArr[j] = suffixArr[j + 1] * nums[j + 1];
        }

        //calculate result
        for(int k =0;k<n;k++){
            result[k] = prefixArr[k] * suffixArr[k];
        }

        return result;

    }
}
