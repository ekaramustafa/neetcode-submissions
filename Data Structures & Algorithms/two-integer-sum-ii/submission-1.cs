public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        int left = 0;
        int right = numbers.Length - 1;

        while(left < right){
            int sum = numbers[left] + numbers[right];
            if(sum == target){
                int[] result = new int[2];
                result[0] = left + 1;
                result[1] = right + 1;
                return result;
            }
            else if(sum > target){
                right--;
            }
            else{
                left++;
            }
        }
        
        return null;
    }
}
