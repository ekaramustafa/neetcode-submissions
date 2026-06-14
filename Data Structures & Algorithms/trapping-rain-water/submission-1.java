class Solution {
    public int trap(int[] height) {

        int[] prefixArray = calculatePrefixArray(height);
        int[] suffixArray = calculateSuffixArray(height);
        int result = 0;

        int l = 0;
        int r = height.length - 1;

        int leftMax = 0;
        int rightMax = 0;
        while (l <= r){
            leftMax = Math.max(leftMax, height[l]);
            rightMax = Math.max(rightMax, height[r]);
            if (height[l] < height[r]){
                result += leftMax - height[l];
                l++;
            } 
            else{
                result += rightMax - height[r];
                r--;
            }
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