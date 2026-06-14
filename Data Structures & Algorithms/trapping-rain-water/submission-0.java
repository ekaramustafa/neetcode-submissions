class Solution {
    public int trap(int[] height) {

        int[] prefixArray = calculatePrefixArray(height);
        int[] suffixArray = calculateSuffixArray(height);
        int result = 0;
        for (int i = 0; i < height.length; i++){
            int waterAmount = Math.min(prefixArray[i], suffixArray[i]) - height[i];
            result += waterAmount > 0 ? waterAmount : 0;
        }
        return result;
    }

    private static int[] calculatePrefixArray(int[] height){
        int maxLeft = height[0];
        int[] arr = new int[height.length];
        for(int i=0; i < height.length; i++ ){
            maxLeft = Math.max(maxLeft, height[i]);
            arr[i] = maxLeft;
        }
        return arr;
    }

    private static int[] calculateSuffixArray(int[] height){
        int maxLeft = height[height.length - 1];
        int[] arr = new int[height.length];
        for(int i=height.length -1; i > 0; i-- ){
            maxLeft = Math.max(maxLeft, height[i]);
            arr[i] = maxLeft;
        }
        return arr;
    }

    
}