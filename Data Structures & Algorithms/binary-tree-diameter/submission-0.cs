/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int DiameterOfBinaryTree(TreeNode root) {
        if(root == null) return 0;
        int diameter = depth(root.left) + depth(root.right);
        int diameterOfLeft = DiameterOfBinaryTree(root.left);
        int diameterOfRight = DiameterOfBinaryTree(root.right);

        return Math.Max(diameter, Math.Max(diameterOfLeft, diameterOfRight));

    }


    public int depth(TreeNode root){
        if(root == null) return 0;
        return 1 + Math.Max(depth(root.left),depth(root.right)); 
    }
}
