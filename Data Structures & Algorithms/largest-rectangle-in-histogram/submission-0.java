class Solution {
    public int largestRectangleArea(int[] heights) {
        Stack<Integer> stack = new Stack<>(); // stores indices
        int maxArea = 0;

        for (int i = 0; i < heights.length; i++) {

            // current bar is smaller, so it stops taller bars before it
            while (!stack.isEmpty() && heights[i] < heights[stack.peek()]) {
                int poppedIndex = stack.pop();
                int height = heights[poppedIndex];

                // right wall is current index i
                // so usable right side ends at i - 1

                int width;

                if (stack.isEmpty()) {
                    // no smaller bar on the left
                    // so rectangle starts from index 0
                    width = i;
                } else {
                    // stack.peek() is the smaller bar on the left
                    // rectangle starts after it
                    width = i - stack.peek() - 1;
                }

                int area = height * width;
                maxArea = Math.max(maxArea, area);
            }

            // current bar is now unresolved, push it
            stack.push(i);
        }

        // bars left in stack never found a smaller bar on the right
        while (!stack.isEmpty()) {
            int poppedIndex = stack.pop();
            int height = heights[poppedIndex];

            int width;

            if (stack.isEmpty()) {
                width = heights.length;
            } else {
                width = heights.length - stack.peek() - 1;
            }

            int area = height * width;
            maxArea = Math.max(maxArea, area);
        }

        return maxArea;
    }
}