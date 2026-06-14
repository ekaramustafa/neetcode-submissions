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
    public bool IsBalanced(TreeNode root) {
        if(root == null) return true;
        if(Math.Abs(depth(root.left) - depth(root.right)) < 2){
            return IsBalanced(root.left) && IsBalanced(root.right);
        }
        else{
            return false;
        }
        
    }


    public int depth(TreeNode p){
        if(p == null) return 0;
        return 1 + Math.Max(depth(p.left), depth(p.right));
    }
}
