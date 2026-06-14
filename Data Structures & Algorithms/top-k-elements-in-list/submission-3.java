class Solution {
    public int[] topKFrequent(int[] nums, int k) {

        int maxElement = Arrays.stream(nums).max().getAsInt();
        int minElement = Arrays.stream(nums).min().getAsInt();
        int[] countArr = new int[maxElement - minElement + 1];

        //populate countArr
        for (int i =0; i< nums.length; i++)
            countArr[nums[i] - minElement]++;
        
        int[] result = new int[k];

        for (int i =0; i < k; i++){
            int maxIndex = getMaxIndex(countArr);
            int originalNumber = maxIndex + minElement;
            result[i] = originalNumber;
            countArr[maxIndex] = -1;
        }

        return result;
        
    }

    private static int getMaxIndex(int[] arr){
        int maxIndex = 0;
        for (int i =1; i< arr.length; i ++){
            if(arr[i] >= arr[maxIndex]){
                maxIndex = i;
            }
        }
        return maxIndex;
    }
}
