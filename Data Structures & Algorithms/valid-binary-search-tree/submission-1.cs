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
    public bool IsValidBST(TreeNode root) {
        return helper(root, double.NegativeInfinity, double.PositiveInfinity);
        
    }

    private bool helper(TreeNode node, double lower, double upper){
        if(node == null){
            return true;
        }
        if(!((lower < node.val) && node.val < upper)){
            return false;
        }

        return helper(node.left, lower, node.val) && helper(node.right, node.val, upper);
    
    }
}
