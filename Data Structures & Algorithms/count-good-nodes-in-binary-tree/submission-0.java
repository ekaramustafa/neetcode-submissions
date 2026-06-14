/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

class Solution {
    public int goodNodes(TreeNode root) {
        int maxVal = Integer.MIN_VALUE;
        return solve(root, maxVal);
        
    }

    public int solve(TreeNode root, int maxVal){
        if(root == null) return 0;

        if(root.val >= maxVal){
            return 1 + solve(root.left, root.val) + solve(root.right, root.val);
        }
        else{
            return solve(root.left, maxVal) + solve(root.right, maxVal);
        }
    }
}
